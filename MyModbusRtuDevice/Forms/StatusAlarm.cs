using MyModbusRtuDevice.Common;
using MyModbusRtuDevice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyModbusRtuDevice.Forms
{
    public partial class StatusAlarm : Form
    {
        // 历史告警数据
        private BindingList<AlarmModel> historyAlarmList = new BindingList<AlarmModel>();

        public StatusAlarm()
        {
            InitializeComponent();
            this.Load += StatusAlarm_Load;
        }

        private void StatusAlarm_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = AppSession.AlarmList;
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = historyAlarmList;
            datePickerRange.Value = new DateTime[] { DateTime.Now.AddDays(-7), DateTime.Now }; // 默认选择最近一小时
            // 启动时加载近期的告警数据，实时数据为近期数据+最新实时数据
            InitRealTimeData();
        }

        /// <summary>
        /// 添加告警信息
        /// </summary>
        /// <param name="alarm"></param>
        public void AddAlarmInfo(AlarmModel alarm)
        {
            // 如果已经存在相同的告警，则不添加
            if (AppSession.AlarmData.Any(p => p.SlaveId == alarm.SlaveId && p.Address == alarm.Address && p.State == "正在告警"))
                return;

            int id = AppSession.DBService.AddAlarmValue(alarm);
            alarm.Id = id;
            this.Invoke(new Action(() =>
            {
                // 添加到第一项，最新的位于顶上
                AppSession.AlarmList.Insert(0, alarm);
            }));
        }

        private void alarmProcBtn_Click(object sender, EventArgs e)
        {
            foreach (AlarmModel row in AppSession.AlarmList)
            {
                if (row.IsSelected)
                {
                    row.State = "已处理";
                    row.IsSelected = false;
                    AppSession.DBService.UpdateAlarmState(row.SlaveId, row.Address, "已处理");
                    AppSession.AlarmData.RemoveAll(p => p.SlaveId == row.SlaveId && p.Address == row.Address);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = AppSession.AlarmList;
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            SetStateColor(e.RowIndex);
        }

        private void SetStateColor(int index)
        {
            if (AppSession.AlarmList[index].State.Equals("正在告警"))
                dataGridView1.Rows[index].Cells["state"].Style.ForeColor = Color.Red;
            else
                dataGridView1.Rows[index].Cells["state"].Style.ForeColor = Color.ForestGreen;
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            GetHistoryData();
        }

        /// <summary>
        /// 查询历史告警数据
        /// </summary>
        private void GetHistoryData()
        {
            var startTime = datePickerRange.Value[0];
            var endTime = datePickerRange.Value[1];

            var dt = AppSession.DBService.GetAlarmsByTime(startTime, endTime);
            historyAlarmList.Clear();
            foreach (var item in dt.AsEnumerable())
            {
                AlarmModel model = new AlarmModel()
                {
                    Id = Convert.ToInt32(item["id"]),
                    SlaveId = Convert.ToInt32(item["d_id"]),
                    DeviceName = item["d_name"].ToString(),
                    Address = item["addr"].ToString(),
                    VariableName = item["v_name"].ToString(),
                    Value = Convert.ToDouble(item["value"]),
                    Message = item["message"].ToString(),
                    Time = ((DateTime)item["time"]).ToString("yyyy/MM/dd HH:mm:ss"),
                    State = item["state"].ToString()
                };
                historyAlarmList.Add(model);
            }
        }

        /// <summary>
        /// 初始化实时告警数据
        /// </summary>
        private void InitRealTimeData()
        {
            var startTime = DateTime.Now.AddDays(-7);
            var endTime = DateTime.Now;

            var dt = AppSession.DBService.GetAlarmsByTime(startTime, endTime);
            foreach (var item in dt.AsEnumerable())
            {
                AlarmModel model = new AlarmModel()
                {
                    Id = Convert.ToInt32(item["id"]),
                    SlaveId = Convert.ToInt32(item["d_id"]),
                    DeviceName = item["d_name"].ToString(),
                    Address = item["addr"].ToString(),
                    VariableName = item["v_name"].ToString(),
                    Value = Convert.ToDouble(item["value"]),
                    Message = item["message"].ToString(),
                    Time = ((DateTime)item["time"]).ToString("yyyy/MM/dd HH:mm:ss"),
                    State = item["state"].ToString()
                };
                AppSession.AlarmList.Add(model);
            }
        }

        /// <summary>
        /// 导出查询到的告警记录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exportBtn_Click(object sender, EventArgs e)
        {
            string csvData = "";
            // 添加表头
            dataGridView1.Columns.Cast<DataGridViewColumn>().ToList().ForEach(c =>
            {
                if (c.Name != "is_selected") // 排除选择列
                    csvData += c.HeaderText + ",";
            });
            csvData = csvData.TrimEnd(',') + "\n";

            // 添加数据行
            foreach (var col in historyAlarmList)
            {
                // 拼接csv格式数据
                csvData += $"{col.SlaveId},{col.DeviceName},{col.Address},{col.VariableName},{col.Value},{col.Message},{col.Time},{col.State}\n";
            }
            // 导出为文件，名称格式为【告警数据_yyyy_MM_dd_HH_mm_ss.csv】
            string fileName = $"告警数据_{DateTime.Now.ToString("yyyy_MM_dd_HH_mm_ss")}.csv";
            // 使用System.IO.File.WriteAllText，将文件写到桌面上
            string desktopPath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string filePath = Path.Combine(desktopPath, fileName);
            System.IO.File.WriteAllText(filePath, csvData);
            MessageBox.Show("导出成功，已保存到桌面", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
