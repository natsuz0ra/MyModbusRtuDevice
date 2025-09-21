using MyModbusRtuDevice.Common;
using MyModbusRtuDevice.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyModbusRtuDevice.Forms
{
    public partial class SystemConfig : Form
    {
        public SystemConfig()
        {
            InitializeComponent();
            this.Load += SystemConfig_Load;
        }

        private void SystemConfig_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void serialPortsDropList_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            serialPortsDropList.SelectedValue = e.Value;
            serialPortsDropList.Text = serialPortsDropList.SelectedValue.ToString();

            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.PortName = serialPortsDropList.SelectedValue.ToString();
        }

        private void baudDropList_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            baudDropList.SelectedValue = e.Value;
            baudDropList.Text = baudDropList.SelectedValue.ToString();

            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.BaudRate = Convert.ToInt32(baudDropList.SelectedValue);
        }

        private void dataBitsDropList_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            dataBitsDropList.SelectedValue = e.Value;
            dataBitsDropList.Text = dataBitsDropList.SelectedValue.ToString();

            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.DateBit = Convert.ToInt32(dataBitsDropList.SelectedValue);
        }

        private void parityDropList_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            parityDropList.SelectedValue = e.Value;
            parityDropList.Text = parityDropList.SelectedValue.ToString();

            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.Parity = (Parity)Enum.Parse(typeof(Parity), parityDropList.SelectedValue.ToString());
        }

        private void stopBitsDropList_SelectedValueChanged(object sender, AntdUI.ObjectNEventArgs e)
        {
            stopBitsDropList.SelectedValue = e.Value;
            stopBitsDropList.Text = stopBitsDropList.SelectedValue.ToString();

            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBitsDropList.SelectedValue.ToString());
        }

        private void readBufferInput_ValueChanged(object sender, AntdUI.DecimalEventArgs e)
        {
            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.ReadBuffterSize = Convert.ToInt32(e.Value);
        }

        private void readTimeoutInput_ValueChanged(object sender, AntdUI.DecimalEventArgs e)
        {
            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.ReadTimeout = Convert.ToInt32(e.Value);
        }

        private void writeBufferInput_ValueChanged(object sender, AntdUI.DecimalEventArgs e)
        {
            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.WriteBuffterSize = Convert.ToInt32(e.Value);
        }

        private void writeTimeoutInput_ValueChanged(object sender, AntdUI.DecimalEventArgs e)
        {
            var cm = AppSession.ModbusService.GetCommunicationModel();
            cm.WriteTimeout = Convert.ToInt32(e.Value);
        }

        /// <summary>
        /// 初始化数据和页面控件
        /// </summary>
        private void InitData()
        {
            // 初始化可用的串口列表
            serialPortsDropList.Items.AddRange(SerialPort.GetPortNames());
            // 初始化校验位列表
            parityDropList.Items.AddRange(Enum.GetNames(typeof(Parity)));
            // 初始化停止位列表
            stopBitsDropList.Items.AddRange(Enum.GetNames(typeof(StopBits)));

            // 初始化选择项和显示值，从读取的配置中获取
            var cm = AppSession.ModbusService.GetCommunicationModel();

            // 通用配置数据
            serialPortsDropList.SelectedValue = serialPortsDropList.Items.ToArray<string>().First(p => p == cm.PortName);
            serialPortsDropList.Text = serialPortsDropList.SelectedValue.ToString();
            baudDropList.SelectedValue = baudDropList.Items.ToArray<string>().First(p => p == cm.BaudRate.ToString());
            baudDropList.Text = baudDropList.SelectedValue.ToString();
            dataBitsDropList.SelectedValue = dataBitsDropList.Items.ToArray<string>().First(p => p == cm.DateBit.ToString());
            dataBitsDropList.Text = dataBitsDropList.SelectedValue.ToString();
            parityDropList.SelectedValue = parityDropList.Items.ToArray<string>().First(p => p == cm.Parity.ToString());
            parityDropList.Text = parityDropList.SelectedValue.ToString();
            stopBitsDropList.SelectedValue = stopBitsDropList.Items.ToArray<string>().First(p => p == cm.StopBits.ToString());
            stopBitsDropList.Text = stopBitsDropList.SelectedValue.ToString();

            readBufferInput.Value = Convert.ToDecimal(cm.ReadBuffterSize);
            readTimeoutInput.Value = Convert.ToDecimal(cm.ReadTimeout);
            writeBufferInput.Value = Convert.ToDecimal(cm.WriteBuffterSize);
            writeTimeoutInput.Value = Convert.ToDecimal(cm.WriteTimeout);

            // 根据设备列表动态生成对应的页面控件
            tabs.Pages.Clear();
            for (int i = 0; i < cm.DeviceList.Count; i++)
            {
                DeviceModel device = cm.DeviceList[i];

                // 标签页
                AntdUI.TabPage page = new AntdUI.TabPage();
                page.BackColor = System.Drawing.Color.White;
                page.Dock = DockStyle.Fill;
                page.Location = new System.Drawing.Point(0, 27);
                page.Name = $"tabPage{i}";
                page.Size = new System.Drawing.Size(850, 515);
                page.TabIndex = 0;
                page.Text = $"  设备{device.SlaveId}  ";

                // 文本标签1
                AntdUI.Label label1 = new AntdUI.Label();
                label1.Location = new System.Drawing.Point(17, 15);
                label1.Name = "label10";
                label1.Size = new System.Drawing.Size(51, 23);
                label1.TabIndex = 18;
                label1.Text = "从站地址";
                label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                page.Controls.Add(label1);

                // 从站地址输入框
                AntdUI.Input slaveInput = new AntdUI.Input();
                slaveInput.Location = new System.Drawing.Point(74, 9);
                slaveInput.Name = $"slaveInput{i}";
                slaveInput.Size = new System.Drawing.Size(119, 35);
                slaveInput.TabIndex = 19;
                slaveInput.Text = device.SlaveId.ToString();
                page.Controls.Add(slaveInput);

                // 文本标签2
                AntdUI.Label label2 = new AntdUI.Label();
                label2.Location = new System.Drawing.Point(202, 15);
                label2.Name = "label11";
                label2.Size = new System.Drawing.Size(51, 23);
                label2.TabIndex = 20;
                label2.Text = "设备名称";
                label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
                page.Controls.Add(label2);

                // 设备名输入框
                AntdUI.Input deviceNameInput = new AntdUI.Input();
                deviceNameInput.Location = new System.Drawing.Point(259, 9);
                deviceNameInput.Name = $"deviceNameInput{i}";
                deviceNameInput.Size = new System.Drawing.Size(260, 35);
                deviceNameInput.TabIndex = 21;
                deviceNameInput.Text = device.Name;
                page.Controls.Add(deviceNameInput);

                // 表格字段
                DataGridViewTextBoxColumn v_name = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn addr = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn rate = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn offset = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn color = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn min = new DataGridViewTextBoxColumn();
                DataGridViewTextBoxColumn max = new DataGridViewTextBoxColumn();

                {
                    v_name.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    v_name.DataPropertyName = "Name";
                    v_name.DefaultCellStyle = new DataGridViewCellStyle() { Alignment = DataGridViewContentAlignment.MiddleCenter };
                    v_name.HeaderText = "变量名称";
                    v_name.Name = "v_name";
                    v_name.ReadOnly = true;
                    v_name.Resizable = DataGridViewTriState.True;

                    addr.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    addr.DataPropertyName = "Address";
                    addr.DefaultCellStyle = new DataGridViewCellStyle() { Alignment = DataGridViewContentAlignment.MiddleCenter };
                    addr.HeaderText = "变量地址";
                    addr.Name = "addr";
                    addr.ReadOnly = true;
                    addr.Resizable = DataGridViewTriState.True;

                    rate.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    rate.DataPropertyName = "Rate";
                    rate.DefaultCellStyle = new DataGridViewCellStyle() { Alignment = DataGridViewContentAlignment.MiddleCenter };
                    rate.HeaderText = "系数";
                    rate.Name = "rate";
                    rate.ReadOnly = true;
                    rate.Resizable = DataGridViewTriState.True;

                    offset.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    offset.DataPropertyName = "Offset";
                    offset.DefaultCellStyle = new DataGridViewCellStyle() { Alignment = DataGridViewContentAlignment.MiddleCenter };
                    offset.HeaderText = "偏移量";
                    offset.Name = "offset";
                    offset.ReadOnly = true;
                    offset.Resizable = DataGridViewTriState.True;

                    color.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    color.DataPropertyName = "Color";
                    color.DefaultCellStyle = new DataGridViewCellStyle() { Alignment = DataGridViewContentAlignment.MiddleCenter };
                    color.HeaderText = "图表颜色";
                    color.Name = "color";
                    color.ReadOnly = true;
                    color.Resizable = DataGridViewTriState.True;

                    min.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    min.DataPropertyName = "Min";
                    min.DefaultCellStyle = new DataGridViewCellStyle() { Alignment = DataGridViewContentAlignment.MiddleCenter };
                    min.HeaderText = "最小预警";
                    min.Name = "min";
                    min.ReadOnly = true;
                    min.Resizable = DataGridViewTriState.True;

                    max.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    max.DataPropertyName = "Max";
                    max.DefaultCellStyle = new DataGridViewCellStyle() { Alignment = DataGridViewContentAlignment.MiddleCenter };
                    max.HeaderText = "最大预警";
                    max.Name = "max";
                    max.ReadOnly = true;
                    max.Resizable = DataGridViewTriState.True;
                }

                // 表格
                DataGridView dataGridView = new DataGridView();
                dataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
                dataGridView.BorderStyle = BorderStyle.None;
                DataGridViewCellStyle dataGridViewCellStyle = new DataGridViewCellStyle();
                dataGridViewCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                dataGridViewCellStyle.BackColor = System.Drawing.SystemColors.Control;
                dataGridViewCellStyle.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
                dataGridViewCellStyle.ForeColor = System.Drawing.SystemColors.WindowText;
                dataGridViewCellStyle.SelectionBackColor = System.Drawing.SystemColors.Highlight;
                dataGridViewCellStyle.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
                dataGridViewCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle;
                dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
                dataGridView.Columns.AddRange(new DataGridViewColumn[] {
                    v_name,
                    addr,
                    rate,
                    offset,
                    color,
                    min,
                    max});
                dataGridView.Location = new System.Drawing.Point(17, 50);
                dataGridView.Name = $"dataGridView{i}";
                dataGridView.RowHeadersVisible = false;
                dataGridView.RowTemplate.Height = 23;
                dataGridView.RowTemplate.Resizable = DataGridViewTriState.False;
                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView.Size = new System.Drawing.Size(817, 448);
                dataGridView.TabIndex = 22;
                dataGridView.AutoGenerateColumns = false;
                dataGridView.DataSource = device.Variable;
                page.Controls.Add(dataGridView);

                // 添加变量按钮
                AntdUI.Button addVariableBtn = new AntdUI.Button();
                addVariableBtn.Location = new System.Drawing.Point(646, 6);
                addVariableBtn.Name = $"addVariableBtn{i}";
                addVariableBtn.Size = new System.Drawing.Size(91, 38);
                addVariableBtn.TabIndex = 23;
                addVariableBtn.Text = "添加变量";
                addVariableBtn.Type = AntdUI.TTypeMini.Success;
                addVariableBtn.Click += new System.EventHandler(this.addVariableBtn_Click);
                page.Controls.Add(addVariableBtn);

                // 删除变量按钮
                AntdUI.Button removeVariableBtn = new AntdUI.Button();
                removeVariableBtn.Location = new System.Drawing.Point(743, 6);
                removeVariableBtn.Name = $"removeVariableBtn{i}";
                removeVariableBtn.Size = new System.Drawing.Size(91, 38);
                removeVariableBtn.TabIndex = 24;
                removeVariableBtn.Text = "删除变量";
                removeVariableBtn.Type = AntdUI.TTypeMini.Error;
                removeVariableBtn.Click += new System.EventHandler(this.removeVariableBtn_Click);
                page.Controls.Add(removeVariableBtn);

                tabs.Pages.Add(page);
            }
        }

        /// <summary>
        /// 新增变量按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addVariableBtn_Click(object sender, EventArgs e)
        {
            // 从控件名中获取索引，找到所需的控件
            AntdUI.Button btn = sender as AntdUI.Button;
            if (btn == null)
                return;
            int index = Convert.ToInt32(btn.Name.Replace("addVariableBtn", ""));

            AddVariable avForm = new AddVariable(index);
            avForm.AcceptAction = new Action<int, VariableModel>(AddVariable);
            avForm.ShowDialog();
        }

        /// <summary>
        /// 删除变量按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void removeVariableBtn_Click(object sender, EventArgs e)
        {
            // 从控件名中获取索引，找到所需的控件
            AntdUI.Button btn = sender as AntdUI.Button;
            if (btn == null)
                return;
            int index = Convert.ToInt32(btn.Name.Replace("removeVariableBtn", ""));

            // 从tabs中找到对应的DataGridView控件
            Control.ControlCollection cc = tabs.Pages[index].Controls;
            Control[] controls = tabs.Pages[index].Controls.Find($"dataGridView{index}", false);
            if (controls.Count() == 0)
                return;
            DataGridView dataGridView = controls[0] as DataGridView;
            if (dataGridView == null)
                return;

            var cm = AppSession.ModbusService.GetCommunicationModel();
            DeviceModel device = cm.DeviceList[index];

            if (dataGridView.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dataGridView.SelectedRows)
                {
                    device.Variable.RemoveAt(row.Index);
                }
                dataGridView.DataSource = null;
                dataGridView.DataSource = device.Variable;
            }
        }

        /// <summary>
        /// 新增变量，通用方法
        /// </summary>
        /// <param name="slaveId"></param>
        /// <param name="variable"></param>
        private void AddVariable(int index, VariableModel variable)
        {
            var cm = AppSession.ModbusService.GetCommunicationModel();
            var variables = cm.DeviceList[index].Variable;
            variables.Add(variable);
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = variables;
        }

        private void saveCfgBtn_Click(object sender, EventArgs e)
        {
            try
            {
                var cm = AppSession.ModbusService.GetCommunicationModel();
                cm.PortName = serialPortsDropList.Text;
                cm.BaudRate = Convert.ToInt32(baudDropList.Text);
                cm.DateBit = Convert.ToInt32(dataBitsDropList.Text);
                cm.Parity = (Parity)Enum.Parse(typeof(Parity), parityDropList.Text);
                cm.StopBits = (StopBits)Enum.Parse(typeof(StopBits), stopBitsDropList.Text);
                cm.ReadBuffterSize = Convert.ToInt32(readBufferInput.Value);
                cm.ReadTimeout = Convert.ToInt32(readTimeoutInput.Value);
                cm.WriteBuffterSize = Convert.ToInt32(writeBufferInput.Value);
                cm.WriteTimeout = Convert.ToInt32(writeTimeoutInput.Value);

                for (int i = 0; i < cm.DeviceList.Count(); i++)
                {
                    Control[] slaveInputs = tabs.Pages[i].Controls.Find($"slaveInput{i}", false);
                    Control[] deviceNameInputs = tabs.Pages[i].Controls.Find($"deviceNameInput{i}", false);
                    if (slaveInputs.Count() == 0 || deviceNameInputs.Count() == 0)
                        continue;
                    AntdUI.Input slaveInput = slaveInputs[0] as AntdUI.Input;
                    AntdUI.Input deviceNameInput = deviceNameInputs[0] as AntdUI.Input;
                    if (slaveInput == null || deviceNameInput == null)
                        continue;
                    cm.DeviceList[i].SlaveId = Convert.ToByte(slaveInput.Text);
                    cm.DeviceList[i].Name = deviceNameInput.Text;
                }

                AppSession.ModbusService.SaveCommunicationModel();
                MessageBox.Show("配置保存成功", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"保存失败，请检查配置\n{ex.Message}", "提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
