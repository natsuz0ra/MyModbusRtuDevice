using AntdUI;
using Modbus.Device;
using MyModbusRtuDevice.Common;
using MyModbusRtuDevice.Common.Events;
using MyModbusRtuDevice.Forms;
using MyModbusRtuDevice.Models;
using Newtonsoft.Json;
using Sunny.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace MyModbusRtuDevice
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.Load += MainForm_Load; // 窗体加载事件
        }

        // 初始化操作建议放这里，否则一些操作无法生效
        private void MainForm_Load(object sender, EventArgs e)
        {
            SelectButton(buttonSystemOverview); // 推荐放这里
            AppSession.ModbusService.SubscribeConnectErrorEvent(OnConnectError);

            // 启动时加载历史告警数据，这个列表不用于展示，仅用于去重
            // 读取全部告警数据
            var dt = AppSession.DBService.GetAlarms();
            foreach (var item in dt.AsEnumerable())
            {
                AlarmModel model = new AlarmModel()
                {
                    SlaveId = Convert.ToInt32(item["d_id"]),
                    Address = item["addr"].ToString(),
                    State = item["state"].ToString()
                };
                AppSession.AlarmData.Add(model);
            }
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region 处理顶栏窗口移动
        Point startP;
        bool moveStatus = false;
        private void panelTop_MouseDown(object sender, MouseEventArgs e)
        {
            startP = e.Location;
            moveStatus = true;
        }

        private void panelTop_MouseMove(object sender, MouseEventArgs e)
        {
            if (moveStatus)
            {
                Point p = Control.MousePosition;
                p.Offset(-startP.X, -startP.Y);
                this.Location = p;
            }
        }

        private void panelTop_MouseUp(object sender, MouseEventArgs e)
        {
            moveStatus = false;
        }
        #endregion

        /// <summary>
        /// 更新时间，每秒执行一次
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timeUpdater_Tick(object sender, EventArgs e)
        {
            timeLabel.Text = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");
        }

        // 展示窗体
        private void ShowForm<T>() where T : Form, new()
        {
            bool has = false;
            // 遍历当前面板中的所有控件，查找是否已经有这个窗体
            foreach (var ctl in viewPanel.Controls)
            {
                Form f = ctl as Form;
                if (f.GetType() == typeof(T))
                {
                    // 如果已经有这个窗体了，那么直接显示它
                    f.Show();
                    has = true;
                }
                else
                {
                    // 如果不是这个窗体，那么隐藏它
                    f.Hide();
                }
            }

            // 如果已经有这个窗体了，那么直接返回
            if (has) return;

            // 如果没有这个窗体，那么创建一个新的窗体
            T form = new T();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            form.WindowState = FormWindowState.Maximized;

            viewPanel.Controls.Add(form);
            form.Show();
        }

        /// <summary>
        /// 获取窗体实例
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private T GetForm<T>() where T : Form
        {
            foreach (var ctl in viewPanel.Controls)
            {
                if (ctl.GetType() == typeof(T))
                {
                    return ctl as T;
                }
            }
            return null;
        }

        private AntdUI.Button selectedPageButton;

        // 按钮点击事件
        private void SelectButtonEvent(object sender, EventArgs args)
        {
            AntdUI.Button selectedButton = sender as AntdUI.Button;
            SelectButton(selectedButton);
        }

        // 按钮点击处理
        private void SelectButton(AntdUI.Button button)
        {
            if (button == null || button == selectedPageButton) return; // 如果没有选中按钮，或者已经是当前选中的按钮，那么直接返回
            //button.BackColor = System.Drawing.Color.FromArgb(64, 158, 254); // 设置选中颜色
            button.ForeColor = Color.White; // 设置文字颜色
            button.Type = AntdUI.TTypeMini.Primary; // 设置按钮类型为主按钮
            ResetButton(selectedPageButton);
            selectedPageButton = button;

            var service = AppSession.ModbusService;

            // 展示子窗体
            // 系统概况页
            if (button == buttonSystemOverview)
            {
                ShowForm<SystemOverview>();
                service.SubscribeRefreshFormMonitorDataEvent(GetForm<SystemOverview>().GetMonitorDatas);
                service.SubscribeShowLogEvent(GetForm<SystemOverview>().ShowLog);
            }
            // 数据跟踪页
            if (button == buttonDataTrack)
            {
                ShowForm<DataTrack>();
                GetForm<DataTrack>().SetDeviceInfo(service.GetCommunicationModel().DeviceList);
                service.SubscribeRefreshFormMonitorDataEvent(GetForm<DataTrack>().GetMonitorDatas);
            }
            // 状态预警页
            if (button == buttonStatusAlarm)
            {
                ShowForm<StatusAlarm>();
                service.SubscribeAlarmEvent(GetForm<StatusAlarm>().AddAlarmInfo);
            }
            // 系统配置页
            if (button == buttonSystemConfig)
            {
                ShowForm<SystemConfig>();
            }
        }

        // 恢复按钮原始状态
        private void ResetButton(AntdUI.Button button)
        {
            if (button == null) return; // 如果没有选中的按钮，直接返回
            //button.BackColor = System.Drawing.Color.Transparent;
            button.ForeColor = System.Drawing.Color.DimGray;
            button.Type = AntdUI.TTypeMini.Default; // 恢复按钮类型
        }

        /// <summary>
        /// 连接按钮点击事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnect_Click(object sender, EventArgs e)
        {
            AntdUI.Button btn = sender as AntdUI.Button;
            if (btn == null)
                return;

            var service = AppSession.ModbusService;

            if (!service.IsConnected())
            {
                // 如果没有连接，那么尝试连接
                try
                {
                    Connect(btn);
                }
                catch (Exception ex)
                {
                    connectStatusLabel.Text = "连接失败";
                    connectStatusLabel2.Text = $"连接失败：[-1] {ex.Message}";
                    statusPanel.BackColor = Color.Red;
                    return;
                }
            }
            else
            {
                Disconnect(btn); // 如果已经连接，那么断开连接
            }
        }

        /// <summary>
        /// 连接操作
        /// </summary>
        private void Connect(AntdUI.Button btn)
        {
            var service = AppSession.ModbusService;
            service.Connect(); // 启动数据监控
            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            btn.Text = "断开连接";
            btn.IconSvg = "DisconnectOutlined";
            connectStatusLabel.Text = "通信连接已建立，正在监控中...";
            connectStatusLabel2.Text = "已连接";
            statusPanel.BackColor = Color.Green;
        }

        private void Disconnect(AntdUI.Button btn)
        {
            var service = AppSession.ModbusService;
            service.Disconnect(); // 断开连接
            btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            btn.Text = "连接";
            btn.IconSvg = "ApiOutlined";
            connectStatusLabel.Text = "等待通信连接...";
            connectStatusLabel2.Text = "未连接";
            statusPanel.BackColor = Color.Yellow;
        }

        /// <summary>
        /// 通信出错时的处理方法
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnConnectError(object sender, ConnectErrorEventArgs e)
        {
            ConnectErrorEventArgs args = e as ConnectErrorEventArgs;
            int code = -1;
            string message = "未知错误";
            if (args != null)
            {
                code = args.Code;
                message = args.Message;
            }

            if (!args.Disconnect)
                return; // 如果不需要断开连接，那么直接返回

            Disconnect(btnConnect); // 断开连接按钮状态
            connectStatusLabel.Text = "通信错误";
            connectStatusLabel2.Text = $"通信错误：[{code}] {message}";
            statusPanel.BackColor = Color.Red;
        }

        private void SaveData()
        {

        }
    }
}
