using MyModbusRtuDevice.Common;
using MyModbusRtuDevice.Models;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyModbusRtuDevice.Forms
{
    public partial class SystemOverview : Form
    {
        public SystemOverview()
        {
            InitializeComponent();
            this.Load += SystemOverview_Load;
        }

        private void SystemOverview_Load(object sender, EventArgs e)
        {
            label7.BringToFront();
            label12.BringToFront();
            label17.BringToFront();

            Timer timer = new Timer();
            timer.Interval = 100; // 设置为0.1秒
            timer.Tick += (se, ev) =>
            {
                uiPipe1.Invalidate();
                uiPipe2.Invalidate();
                uiPipe3.Invalidate();
                uiPipe4.Invalidate();
                uiPipe5.Invalidate();
                uiPipe6.Invalidate();
                uiPipe7.Invalidate();
                uiPipe8.Invalidate();
                uiPipe9.Invalidate();
                uiPipe10.Invalidate();
                uiPipe11.Invalidate();
                uiPipe12.Invalidate();
                uiPipe13.Invalidate();
                uiPipe14.Invalidate();
            };
            timer.Start();
        }

        /// <summary>
        /// 获取监控数据
        /// </summary>
        /// <param name="device"></param>
        public void GetMonitorDatas()
        {
            var cm = AppSession.ModbusService.GetCommunicationModel();

            // 主线程更新UI
            this.Invoke(new Action(() =>
            {
                foreach (var device in cm.DeviceList)
                {
                    // 处理数据，在控件上显示
                    if (device.SlaveId == 1)
                    {
                        labelRunNum.Text = device.Variable.Find(v => v.Address == 0)?.Value?.ToString() ?? "0";
                        labelStopNum.Text = device.Variable.Find(v => v.Address == 1)?.Value?.ToString() ?? "0";
                        labelErrNum.Text = device.Variable.Find(v => v.Address == 2)?.Value?.ToString() ?? "0";
                    }
                    else if (device.SlaveId == 2)
                    {
                        // 转原类型ushort后再转int
                        rpMainPipePressure.Value = int.TryParse(device.Variable.Find(v => v.Address == 10)?.Value?.ToString(), out int pressure) ? pressure : 0;
                        rpMainPipeTraffic.Value = int.TryParse(device.Variable.Find(v => v.Address == 11)?.Value?.ToString(), out int traffic) ? traffic : 0;
                        rpMainPipeLeakage.Value = int.TryParse(device.Variable.Find(v => v.Address == 12)?.Value?.ToString(), out int leakage) ? leakage : 0;
                    }
                    else if (device.SlaveId == 3)
                    {
                        lbValveOpening1.Text = $"{device.Variable.Find(v => v.Address == 0)?.Value?.ToString() ?? "0"}%";
                        lbInputPressure1.Text = $"{device.Variable.Find(v => v.Address == 1)?.Value?.ToString() ?? "0"} MPa";
                        lbCurrentTraffic1.Text = $"{(float.TryParse(device.Variable.Find(v => v.Address == 2)?.Value?.ToString(), out float traffic) ? traffic / 100 : 0):F2} m³";

                        lbValveOpening2.Text = $"{device.Variable.Find(v => v.Address == 3)?.Value?.ToString() ?? "0"}%";
                        lbOutputPressure1.Text = $"{device.Variable.Find(v => v.Address == 4)?.Value?.ToString() ?? "0"} MPa";
                        lbOutputPressure2.Text = $"{device.Variable.Find(v => v.Address == 5)?.Value?.ToString() ?? "0"} MPa";

                        lbValveOpening3.Text = $"{device.Variable.Find(v => v.Address == 6)?.Value?.ToString() ?? "0"}%";
                        lbCurrentTraffic2.Text = $"{(float.TryParse(device.Variable.Find(v => v.Address == 7)?.Value?.ToString(), out float traffic2) ? traffic2 / 100 : 0):F2} m³";
                    }
                }
            }));
        }

        /// <summary>
        /// 打印日志
        /// </summary>
        /// <param name="msg"></param>
        public void ShowLog(string msg)
        {
            this.Invoke(new Action(() =>
            {
                logListBox.Items.Insert(0, msg);
            }));
        }

        private void switch1_Click(object sender, EventArgs e)
        {
            AntdUI.Switch sw = sender as AntdUI.Switch;
            if (sw == null)
                return;
            bool ok = AppSession.ModbusService.WriteSigleCoil(1, 0, sw.Checked);
            if (!ok)
            {
                sw.Checked = !sw.Checked;
            }
        }

        private void switch2_Click(object sender, EventArgs e)
        {
            AntdUI.Switch sw = sender as AntdUI.Switch;
            if (sw == null)
                return;
            bool ok = AppSession.ModbusService.WriteSigleCoil(1, 1, sw.Checked);
            if (!ok)
            {
                sw.Checked = !sw.Checked;
            }
        }

        private void switch3_Click(object sender, EventArgs e)
        {
            AntdUI.Switch sw = sender as AntdUI.Switch;
            if (sw == null)
                return;
            bool ok = AppSession.ModbusService.WriteSigleCoil(1, 2, sw.Checked);
            if (!ok)
            {
                sw.Checked = !sw.Checked;
            }
        }

        private void uiTurnSwitch1_Click(object sender, EventArgs e)
        {
            Sunny.UI.UITurnSwitch sw = sender as Sunny.UI.UITurnSwitch;
            if (sw == null)
                return;

            bool ok = AppSession.ModbusService.WriteSigleCoil(2, 0, sw.Active);
            if (!ok)
            {
                sw.Active = !sw.Active;
            }
        }

        private void uiTurnSwitch2_Click(object sender, EventArgs e)
        {
            Sunny.UI.UITurnSwitch sw = sender as Sunny.UI.UITurnSwitch;
            if (sw == null)
                return;

            bool ok = AppSession.ModbusService.WriteSigleCoil(2, 1, sw.Active);
            if (!ok)
            {
                sw.Active = !sw.Active;
            }
        }

        private void uiTurnSwitch3_Click(object sender, EventArgs e)
        {
            Sunny.UI.UITurnSwitch sw = sender as Sunny.UI.UITurnSwitch;
            if (sw == null)
                return;

            bool ok = AppSession.ModbusService.WriteSigleCoil(2, 2, sw.Active);
            if (!ok)
            {
                sw.Active = !sw.Active;
            }
        }

        private void uiTurnSwitch4_Click(object sender, EventArgs e)
        {
            Sunny.UI.UITurnSwitch sw = sender as Sunny.UI.UITurnSwitch;
            if (sw == null)
                return;

            bool ok = AppSession.ModbusService.WriteSigleCoil(2, 3, sw.Active);
            if (!ok)
            {
                sw.Active = !sw.Active;
            }
        }
    }
}
