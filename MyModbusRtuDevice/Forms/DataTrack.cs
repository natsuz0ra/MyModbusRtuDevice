using AntdUI;
using AntdUI.Controls.Charts;
using MyModbusRtuDevice.Common;
using MyModbusRtuDevice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MyModbusRtuDevice.Forms
{
    public partial class DataTrack : Form
    {
        public DataTrack()
        {
            InitializeComponent();
            this.Load += DataTrack_Load; // 窗体加载事件
        }

        private void DataTrack_Load(object sender, EventArgs e)
        {
            datePickerRange.Value = new DateTime[] { DateTime.Now.AddHours(-1), DateTime.Now }; // 默认选择最近一小时
        }

        private void autoTrackSw_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            datePickerRange.Enabled = !e.Value;
            searchBtn.Enabled = !e.Value;
            ClearAllChartData();
        }

        private void VariableCheckbox_CheckedChanged(object sender, AntdUI.BoolEventArgs e)
        {
            var checkbox = sender as AntdUI.Checkbox;
            var series = checkbox.Tag as System.Windows.Forms.DataVisualization.Charting.Series;
            // 控制图标曲线的显示与隐藏
            series.Enabled = e.Value;
        }

        bool isInit = false;

        public void SetDeviceInfo(List<DeviceModel> devices)
        {
            if (isInit)
                return;

            isInit = true;

            // 设置设备名
            deviceNameLabel1.Text = devices[0].Name;
            deviceNameLabel2.Text = devices[1].Name;
            deviceNameLabel3.Text = devices[2].Name;

            // 设置点位名
            deviceVerPanel1.Controls.Clear();
            chart1.Series.Clear();
            int offset = 0;
            foreach (var item in devices[0].Variable)
            {
                // 图表曲线
                var series = new System.Windows.Forms.DataVisualization.Charting.Series()
                {
                    Name = item.Name,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    IsVisibleInLegend = true,
                    LegendText = item.Name,
                    Color = item.Color,
                };
                chart1.Series.Add(series);

                // 点位选择复选框
                var verCheckbox = new AntdUI.Checkbox()
                {
                    Name = "verCheckbox" + offset,
                    Text = item.Name,
                    AutoSize = false,
                    Width = 82,
                    Height = 18,
                    Location = new Point(12, 11 + 23 * offset),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("微软雅黑", 9),
                    ForeColor = Color.FromArgb(80, 80, 80),
                    Padding = new Padding(5, 0, 0, 0),
                    Checked = true,
                    Tag = series // 关联图表曲线
                };
                verCheckbox.CheckedChanged += VariableCheckbox_CheckedChanged;
                deviceVerPanel1.Controls.Add(verCheckbox);
                offset++;
            }

            deviceVerPanel2.Controls.Clear();
            chart2.Series.Clear();
            offset = 0;
            foreach (var item in devices[1].Variable)
            {
                // 图表曲线
                var series = new System.Windows.Forms.DataVisualization.Charting.Series()
                {
                    Name = item.Name,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    IsVisibleInLegend = true,
                    LegendText = item.Name,
                    Color = item.Color,
                };
                chart2.Series.Add(series);

                // 点位选择复选框
                var verCheckbox = new AntdUI.Checkbox()
                {
                    Name = "verCheckbox" + offset,
                    Text = item.Name,
                    AutoSize = false,
                    Width = 82,
                    Height = 18,
                    Location = new Point(12, 11 + 23 * offset),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("微软雅黑", 9),
                    ForeColor = Color.FromArgb(80, 80, 80),
                    Padding = new Padding(5, 0, 0, 0),
                    Checked = true,
                    Tag = series // 关联图表曲线
                };
                verCheckbox.CheckedChanged += VariableCheckbox_CheckedChanged;
                deviceVerPanel2.Controls.Add(verCheckbox);
                offset++;
            }

            deviceVerPanel3.Controls.Clear();
            chart3.Series.Clear();
            offset = 0;
            foreach (var item in devices[2].Variable)
            {
                // 图表曲线
                var series = new System.Windows.Forms.DataVisualization.Charting.Series()
                {
                    Name = item.Name,
                    ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line,
                    IsVisibleInLegend = true,
                    LegendText = item.Name,
                    Color = item.Color,
                };
                chart3.Series.Add(series);

                // 点位选择复选框
                var verCheckbox = new AntdUI.Checkbox()
                {
                    Name = "verCheckbox" + offset,
                    Text = item.Name,
                    AutoSize = false,
                    Width = 82,
                    Height = 18,
                    Location = new Point(12, 11 + 23 * offset),
                    TextAlign = ContentAlignment.MiddleLeft,
                    Font = new Font("微软雅黑", 9),
                    ForeColor = Color.FromArgb(80, 80, 80),
                    Padding = new Padding(5, 0, 0, 0),
                    Checked = true,
                    Tag = series // 关联图表曲线
                };
                verCheckbox.CheckedChanged += VariableCheckbox_CheckedChanged;
                deviceVerPanel3.Controls.Add(verCheckbox);
                offset++;
            }
        }

        /// <summary>
        /// 获取监控数据
        /// </summary>
        /// <param name="device"></param>
        public void GetMonitorDatas()
        {
            // 数据自动填充的开关，如果关闭则不进行数据更新
            if (!autoTrackSw.Checked) return;

            var cm = AppSession.ModbusService.GetCommunicationModel();

            // 主线程更新UI
            this.Invoke(new Action(() =>
            {
                var now = DateTime.Now;
                foreach (var device in cm.DeviceList)
                {
                    if (device.SlaveId == 1)
                    {
                        for (int i = 0; i < device.Variable.Count(); i++)
                        {
                            chart1.Series[i].Points.AddXY(now, (double)(ushort)device.Variable[i].Value);
                            if (chart1.Series[i].Points.Count > 30)
                            {
                                // 移除最早的坐标点，避免数据过多
                                chart1.Series[i].Points.RemoveAt(0);
                                // 重置x轴的起点和终点，移除坐标点后不进行重置的话，会导致图表显示不正确
                                chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[i].Points[0].XValue;
                                chart1.ChartAreas[0].AxisX.Maximum = chart1.Series[i].Points[29].XValue;
                            }
                        }
                    }
                    if (device.SlaveId == 2)
                    {
                        for (int i = 0; i < device.Variable.Count(); i++)
                        {
                            chart2.Series[i].Points.AddXY(now, (double)(ushort)device.Variable[i].Value);
                            if (chart2.Series[i].Points.Count > 30)
                            {
                                // 移除最早的坐标点，避免数据过多
                                chart2.Series[i].Points.RemoveAt(0);
                                // 重置x轴的起点和终点，移除坐标点后不进行重置的话，会导致图表显示不正确
                                chart2.ChartAreas[0].AxisX.Minimum = chart2.Series[i].Points[0].XValue;
                                chart2.ChartAreas[0].AxisX.Maximum = chart2.Series[i].Points[29].XValue;
                            }
                        }

                    }
                    if (device.SlaveId == 3)
                    {
                        for (int i = 0; i < device.Variable.Count(); i++)
                        {
                            chart3.Series[i].Points.AddXY(now, (double)(ushort)device.Variable[i].Value);
                            if (chart3.Series[i].Points.Count > 30)
                            {
                                // 移除最早的坐标点，避免数据过多
                                chart3.Series[i].Points.RemoveAt(0);
                                // 重置x轴的起点和终点，移除坐标点后不进行重置的话，会导致图表显示不正确
                                chart3.ChartAreas[0].AxisX.Minimum = chart3.Series[i].Points[0].XValue;
                                chart3.ChartAreas[0].AxisX.Maximum = chart3.Series[i].Points[29].XValue;
                            }
                        }
                    }
                }
            }));
        }

        private void ClearAllChartData()
        {
            // 清除现有图表数据
            foreach (var series in chart1.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart2.Series)
            {
                series.Points.Clear();
            }
            foreach (var series in chart3.Series)
            {
                series.Points.Clear();
            }
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            var startTime = datePickerRange.Value[0];
            var endTime = datePickerRange.Value[1];

            var db = AppSession.DBService;
            var data = db.GetMontiorValues(startTime, endTime);

            ClearAllChartData();

            // 处理chart1的数据
            {
                var rows = data.AsEnumerable().Where(d => d["d_id"].ToString() == "1");
                var v1 = rows.Where(d => d["addr"].ToString() == "0");
                foreach (var row in v1)
                {
                    chart1.Series[0].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }
                var v2 = rows.Where(d => d["addr"].ToString() == "1");
                foreach (var row in v2)
                {
                    chart1.Series[1].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }
                var v3 = rows.Where(d => d["addr"].ToString() == "2");
                foreach (var row in v3)
                {
                    chart1.Series[2].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }

                if (chart1.Series[0].Points.Count > 0)
                {
                    chart1.ChartAreas[0].AxisX.Minimum = chart1.Series[0].Points[0].XValue;
                    chart1.ChartAreas[0].AxisX.Maximum = chart1.Series[0].Points[chart1.Series[0].Points.Count - 1].XValue;
                }
            }

            // 处理chart2的数据
            {
                var rows = data.AsEnumerable().Where(d => d["d_id"].ToString() == "2");
                var v1 = rows.Where(d => d["addr"].ToString() == "0");
                foreach (var row in v1)
                {
                    chart2.Series[0].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }
                var v2 = rows.Where(d => d["addr"].ToString() == "1");
                foreach (var row in v2)
                {
                    chart2.Series[1].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }
                var v3 = rows.Where(d => d["addr"].ToString() == "10");
                foreach (var row in v3)
                {
                    chart2.Series[2].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }
                var v4 = rows.Where(d => d["addr"].ToString() == "11");
                foreach (var row in v4)
                {
                    chart2.Series[3].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }
                var v5 = rows.Where(d => d["addr"].ToString() == "12");
                foreach (var row in v5)
                {
                    chart2.Series[4].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }

                if (chart2.Series[0].Points.Count > 0)
                {
                    chart2.ChartAreas[0].AxisX.Minimum = chart2.Series[0].Points[0].XValue;
                    chart2.ChartAreas[0].AxisX.Maximum = chart2.Series[0].Points[chart2.Series[0].Points.Count - 1].XValue;
                }
            }

            // 处理chart3的数据
            {
                var rows = data.AsEnumerable().Where(d => d["d_id"].ToString() == "3");
                var v1 = rows.Where(d => d["addr"].ToString() == "0");
                foreach (var row in v1)
                {
                    chart3.Series[0].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }
                var v2 = rows.Where(d => d["addr"].ToString() == "1");
                foreach (var row in v2)
                {
                    chart3.Series[1].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }
                var v3 = rows.Where(d => d["addr"].ToString() == "2");
                foreach (var row in v3)
                {
                    chart3.Series[2].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }
                var v4 = rows.Where(d => d["addr"].ToString() == "3");
                foreach (var row in v4)
                {
                    chart3.Series[3].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }
                var v5 = rows.Where(d => d["addr"].ToString() == "4");
                foreach (var row in v5)
                {
                    chart3.Series[4].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }
                var v6 = rows.Where(d => d["addr"].ToString() == "5");
                foreach (var row in v6)
                {
                    chart3.Series[5].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }
                var v7 = rows.Where(d => d["addr"].ToString() == "6");
                foreach (var row in v7)
                {
                    chart3.Series[6].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }
                var v8 = rows.Where(d => d["addr"].ToString() == "7");
                foreach (var row in v8)
                {
                    chart3.Series[7].Points.AddXY(DateTime.Parse(row["time"].ToString()), Convert.ToDouble(row["value"].ToString()));
                }

                if (chart3.Series[0].Points.Count > 0)
                {
                    chart3.ChartAreas[0].AxisX.Minimum = chart3.Series[0].Points[0].XValue;
                    chart3.ChartAreas[0].AxisX.Maximum = chart3.Series[0].Points[chart3.Series[0].Points.Count - 1].XValue;
                }
            }
        }
    }
}
