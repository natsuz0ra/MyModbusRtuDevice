using Modbus.Device;
using MyModbusRtuDevice.Common.Events;
using MyModbusRtuDevice.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Net.Configuration;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MyModbusRtuDevice.Common
{
    public class ModbusService
    {
        private ModbusMaster master;
        private SerialPort serialPort;
        private CancellationTokenSource cts;
        private bool isConnected = false; // 是否建立连接

        private CommunicationModel cm;

        // 错误通知事件
        private event ConnectErrorEventHandler connectErrorEvent;
        // 数据刷新事件
        private RefreshFormMonitorDataEventHandler refreshFormMonitorData;
        // 日志记录事件
        private ShowLogEventHandler showLogEventHandler;
        // 告警事件
        private AlarmEventHandler alarmEventHandler;

        public ModbusService()
        {
            // 读取配置文件，获取设备信息
            cm = JsonConvert.DeserializeObject<CommunicationModel>(File.ReadAllText("config.json"));
        }

        /// <summary>
        /// 建立连接
        /// </summary>
        public void Connect()
        {
            // ModbusRTU 一主多从，创建一个RTU对象
            serialPort = new SerialPort(cm.PortName)
            {
                BaudRate = cm.BaudRate,
                DataBits = cm.DateBit,
                Parity = cm.Parity,
                StopBits = cm.StopBits,
                ReadBufferSize = cm.ReadBuffterSize,
                ReadTimeout = cm.ReadTimeout,
                WriteBufferSize = cm.WriteBuffterSize,
                WriteTimeout = cm.WriteTimeout
            };
            master = ModbusSerialMaster.CreateRtu(serialPort);
            serialPort.Open(); // 打开串口

            cts = new CancellationTokenSource(); // 创建取消令牌源
            int tryCount = 0; // 重试次数

            ShowLog("通信已建立，正在监听。");

            // 轮询读取每个设备的点位数据
            Task.Run(async () =>
            {
                int index = 0;
                while (!cts.IsCancellationRequested)
                {
                    // 逐个读取设备中的寄存器值
                    var device = cm.DeviceList[index];
                    foreach (var v in device.Variable)
                    {
                        try
                        {
                            ushort[] res = master.ReadHoldingRegisters(device.SlaveId, v.Address, 1);
                            if (res != null)
                            {
                                v.Value = res[0];
                                var db = AppSession.DBService;
                                db.AddMontiorValue(device.SlaveId, v.Address.ToString(), v.Value.ToString());

                                double v_d = Convert.ToDouble(v.Value);

                                if (v_d < v.Min || v_d > v.Max)
                                {
                                    string msg = v_d < v.Min ? "低于最小" : "高于最大";
                                    // 触发告警事件
                                    AlarmModel alarm = new AlarmModel
                                    {
                                        IsSelected = false,
                                        SlaveId = device.SlaveId,
                                        DeviceName = device.Name,
                                        Address = v.Address.ToString(),
                                        VariableName = v.Name,
                                        Value = v_d,
                                        Message = $"{msg}警戒值",
                                        Time = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"),
                                        State = "正在告警"
                                    };
                                    alarmEventHandler?.Invoke(alarm);
                                    showLogEventHandler?.Invoke($"设备[{device.SlaveId}]变量[{v.Address}:{v.Name}]值[{v_d}]告警");
                                }
                            }
                            else
                                throw new Exception("读取结果为空");
                        }
                        catch (Exception ex)
                        {
                            tryCount++;
                            if (tryCount >= 3)
                            {
                                // 如果重试次数超过3次，抛出错误事件
                                OnConnectErrorThrow(1000, $"设备[{device.SlaveId}]读取寄存器[{v.Address}]失败: {ex.Message}", true);
                                return; // 退出任务
                            }
                            else
                            {
                                // 重试读取
                                continue;
                            }
                        }
                    }

                    index++;
                    if (index >= cm.DeviceList.Count)
                    {
                        index = 0; // 如果超过设备数量，重置索引
                        refreshFormMonitorData(); // 触发数据刷新事件
                        await Task.Delay(10000); // 每十秒执行一次循环
                    }
                }
                serialPort.Close(); // 取消任务时关闭串口
            }, cts.Token);
            isConnected = true;
        }

        /// <summary>
        /// 关闭连接
        /// </summary>
        public void Disconnect()
        {
            if (!isConnected)
                return;

            cts.Cancel();
            serialPort.Close(); // 关闭串口
            isConnected = false; // 设置连接状态为未连接

            ShowLog("通信已断开。");
        }

        /// <summary>
        /// 获取数据模型
        /// </summary>
        /// <returns></returns>
        public CommunicationModel GetCommunicationModel()
        {
            return cm;
        }

        /// <summary>
        /// 获取通信状态
        /// </summary>
        /// <returns></returns>
        public bool IsConnected()
        {
            return isConnected;
        }

        public bool WriteSigleCoil(byte slaveId, ushort address, bool value)
        {
            if (!isConnected)
                return false;

            try
            {
                master.WriteSingleCoil(slaveId, address, value);
                return true;
            }
            catch (Exception ex)
            {
                OnConnectErrorThrow(1001, $"写入线圈状态失败: {ex.Message}", false);
                return false;
            }
        }

        // 创建一个特定格式的json文件
        // 数据持久化
        private void CreateJson()
        {
            CommunicationModel cm = new CommunicationModel
            {
                PortName = "COM1",
                BaudRate = 9600,
                DateBit = 8,
                Parity = Parity.None,
                StopBits = StopBits.One,
                ReadBuffterSize = 4096,
                ReadTimeout = 1000,
                WriteBuffterSize = 4096,
                WriteTimeout = 1000,
                DeviceList = new List<DeviceModel>(),
            };

            cm.DeviceList.Add(new DeviceModel
            {
                SlaveId = 1,
                Name = "油气过滤器",
                Variable = new List<VariableModel>
                {
                    new VariableModel { Address = 0, Rate = 1.0, Offset = 0, Color = System.Drawing.Color.Red },
                    new VariableModel { Address = 1, Rate = 1.0, Offset = 0, Color = System.Drawing.Color.FromArgb(255, 255, 0) },
                },
            });

            cm.DeviceList.Add(new DeviceModel
            {
                SlaveId = 2,
                Name = "油气过滤器2",
                Variable = new List<VariableModel>
                {
                    new VariableModel { Address = 0, Rate = 1.0, Offset = 0 },
                    new VariableModel { Address = 1, Rate = 1.0, Offset = 0 },
                },
            });

            string data = JsonConvert.SerializeObject(cm);
            File.WriteAllText("config.json", data);
        }

        public void SubscribeConnectErrorEvent(ConnectErrorEventHandler handler)
        {
            if (handler == null) return;
            // 先取消订阅，防止重复订阅
            connectErrorEvent -= handler;
            connectErrorEvent += handler;
        }

        public void SubscribeRefreshFormMonitorDataEvent(RefreshFormMonitorDataEventHandler handler)
        {
            if (handler != null)
            {
                // 先取消订阅，防止重复订阅
                refreshFormMonitorData -= handler;
                refreshFormMonitorData += handler;
            }
        }

        public void SubscribeShowLogEvent(ShowLogEventHandler handler)
        {
            if (handler != null)
            {
                // 先取消订阅，防止重复订阅
                showLogEventHandler -= handler;
                showLogEventHandler += handler;
            }
        }

        public void SubscribeAlarmEvent(AlarmEventHandler handler)
        {
            if (handler != null)
            {
                // 先取消订阅，防止重复订阅
                alarmEventHandler -= handler;
                alarmEventHandler += handler;
            }
        }

        public void OnConnectErrorThrow(int code, string msg, bool disconnect)
        {
            ConnectErrorEventArgs e = new ConnectErrorEventArgs(code, msg, disconnect);
            connectErrorEvent?.Invoke(this, e);
        }

        private void ShowLog(string msg)
        {
            showLogEventHandler?.Invoke($"{msg}");
        }
    }
}
