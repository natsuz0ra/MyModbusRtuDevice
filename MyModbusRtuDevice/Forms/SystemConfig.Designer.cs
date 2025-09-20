namespace MyModbusRtuDevice.Forms
{
    partial class SystemConfig
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            AntdUI.Tabs.StyleCard styleCard1 = new AntdUI.Tabs.StyleCard();
            AntdUI.Tabs.StyleCard styleCard2 = new AntdUI.Tabs.StyleCard();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabs5 = new AntdUI.Tabs();
            this.tabPage5 = new AntdUI.TabPage();
            this.writeTimeoutInput = new AntdUI.InputNumber();
            this.label9 = new AntdUI.Label();
            this.writeBufferInput = new AntdUI.InputNumber();
            this.label8 = new AntdUI.Label();
            this.readTimeoutInput = new AntdUI.InputNumber();
            this.label7 = new AntdUI.Label();
            this.readBufferInput = new AntdUI.InputNumber();
            this.label6 = new AntdUI.Label();
            this.stopBitsDropList = new AntdUI.Dropdown();
            this.label5 = new AntdUI.Label();
            this.parityDropList = new AntdUI.Dropdown();
            this.label4 = new AntdUI.Label();
            this.dataBitsDropList = new AntdUI.Dropdown();
            this.label3 = new AntdUI.Label();
            this.baudDropList = new AntdUI.Dropdown();
            this.label2 = new AntdUI.Label();
            this.serialPortsDropList = new AntdUI.Dropdown();
            this.label1 = new AntdUI.Label();
            this.tabs1 = new AntdUI.Tabs();
            this.tabPage1 = new AntdUI.TabPage();
            this.removeVariableBtn1 = new AntdUI.Button();
            this.addVariableBtn1 = new AntdUI.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.v_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.offset = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.color = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.min = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.max = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deviceNameInput2 = new AntdUI.Input();
            this.label11 = new AntdUI.Label();
            this.slaveInput1 = new AntdUI.Input();
            this.label10 = new AntdUI.Label();
            this.tabPage4 = new AntdUI.TabPage();
            this.tabPage6 = new AntdUI.TabPage();
            this.tabs5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.tabs1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabs5
            // 
            this.tabs5.Controls.Add(this.tabPage5);
            this.tabs5.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabs5.Location = new System.Drawing.Point(12, 12);
            this.tabs5.Name = "tabs5";
            this.tabs5.Pages.Add(this.tabPage5);
            this.tabs5.Size = new System.Drawing.Size(193, 542);
            styleCard1.Border = 0;
            this.tabs5.Style = styleCard1;
            this.tabs5.TabIndex = 2;
            this.tabs5.Text = "tabs5";
            this.tabs5.Type = AntdUI.TabType.Card;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.writeTimeoutInput);
            this.tabPage5.Controls.Add(this.label9);
            this.tabPage5.Controls.Add(this.writeBufferInput);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.readTimeoutInput);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.readBufferInput);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.stopBitsDropList);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.parityDropList);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Controls.Add(this.dataBitsDropList);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Controls.Add(this.baudDropList);
            this.tabPage5.Controls.Add(this.label2);
            this.tabPage5.Controls.Add(this.serialPortsDropList);
            this.tabPage5.Controls.Add(this.label1);
            this.tabPage5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage5.Location = new System.Drawing.Point(0, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(193, 515);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "|  通讯参数 ";
            // 
            // writeTimeoutInput
            // 
            this.writeTimeoutInput.Location = new System.Drawing.Point(75, 337);
            this.writeTimeoutInput.Name = "writeTimeoutInput";
            this.writeTimeoutInput.Size = new System.Drawing.Size(103, 35);
            this.writeTimeoutInput.TabIndex = 17;
            this.writeTimeoutInput.Text = "0";
            this.writeTimeoutInput.ValueChanged += new AntdUI.DecimalEventHandler(this.writeTimeoutInput_ValueChanged);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(16, 343);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 23);
            this.label9.TabIndex = 16;
            this.label9.Text = "写入超时";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // writeBufferInput
            // 
            this.writeBufferInput.Location = new System.Drawing.Point(75, 296);
            this.writeBufferInput.Name = "writeBufferInput";
            this.writeBufferInput.Size = new System.Drawing.Size(103, 35);
            this.writeBufferInput.TabIndex = 15;
            this.writeBufferInput.Text = "0";
            this.writeBufferInput.ValueChanged += new AntdUI.DecimalEventHandler(this.writeBufferInput_ValueChanged);
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(16, 302);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 23);
            this.label8.TabIndex = 14;
            this.label8.Text = "写入缓冲";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // readTimeoutInput
            // 
            this.readTimeoutInput.Location = new System.Drawing.Point(75, 255);
            this.readTimeoutInput.Name = "readTimeoutInput";
            this.readTimeoutInput.Size = new System.Drawing.Size(103, 35);
            this.readTimeoutInput.TabIndex = 13;
            this.readTimeoutInput.Text = "0";
            this.readTimeoutInput.ValueChanged += new AntdUI.DecimalEventHandler(this.readTimeoutInput_ValueChanged);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(16, 261);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(51, 23);
            this.label7.TabIndex = 12;
            this.label7.Text = "读取超时";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // readBufferInput
            // 
            this.readBufferInput.Location = new System.Drawing.Point(75, 214);
            this.readBufferInput.Name = "readBufferInput";
            this.readBufferInput.Size = new System.Drawing.Size(103, 35);
            this.readBufferInput.TabIndex = 11;
            this.readBufferInput.Text = "0";
            this.readBufferInput.ValueChanged += new AntdUI.DecimalEventHandler(this.readBufferInput_ValueChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(16, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 23);
            this.label6.TabIndex = 10;
            this.label6.Text = "读取缓冲";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // stopBitsDropList
            // 
            this.stopBitsDropList.Location = new System.Drawing.Point(75, 173);
            this.stopBitsDropList.Name = "stopBitsDropList";
            this.stopBitsDropList.ShowArrow = true;
            this.stopBitsDropList.Size = new System.Drawing.Size(103, 35);
            this.stopBitsDropList.TabIndex = 9;
            this.stopBitsDropList.Text = "None";
            this.stopBitsDropList.Type = AntdUI.TTypeMini.Primary;
            this.stopBitsDropList.SelectedValueChanged += new AntdUI.ObjectNEventHandler(this.stopBitsDropList_SelectedValueChanged);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(16, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 23);
            this.label5.TabIndex = 8;
            this.label5.Text = "停止位";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // parityDropList
            // 
            this.parityDropList.Location = new System.Drawing.Point(75, 132);
            this.parityDropList.Name = "parityDropList";
            this.parityDropList.ShowArrow = true;
            this.parityDropList.Size = new System.Drawing.Size(103, 35);
            this.parityDropList.TabIndex = 7;
            this.parityDropList.Text = "None";
            this.parityDropList.Type = AntdUI.TTypeMini.Primary;
            this.parityDropList.SelectedValueChanged += new AntdUI.ObjectNEventHandler(this.parityDropList_SelectedValueChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(16, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "校验位";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // dataBitsDropList
            // 
            this.dataBitsDropList.Items.AddRange(new object[] {
            "7",
            "8"});
            this.dataBitsDropList.Location = new System.Drawing.Point(75, 91);
            this.dataBitsDropList.Name = "dataBitsDropList";
            this.dataBitsDropList.ShowArrow = true;
            this.dataBitsDropList.Size = new System.Drawing.Size(103, 35);
            this.dataBitsDropList.TabIndex = 5;
            this.dataBitsDropList.Text = "7";
            this.dataBitsDropList.Type = AntdUI.TTypeMini.Primary;
            this.dataBitsDropList.SelectedValueChanged += new AntdUI.ObjectNEventHandler(this.dataBitsDropList_SelectedValueChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(16, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 23);
            this.label3.TabIndex = 4;
            this.label3.Text = "数据位";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // baudDropList
            // 
            this.baudDropList.Items.AddRange(new object[] {
            "300",
            "600",
            "1200",
            "2400",
            "4800",
            "9600",
            "14400",
            "19200",
            "38400",
            "56000",
            "115200",
            "128000",
            "256000"});
            this.baudDropList.Location = new System.Drawing.Point(75, 50);
            this.baudDropList.Name = "baudDropList";
            this.baudDropList.ShowArrow = true;
            this.baudDropList.Size = new System.Drawing.Size(103, 35);
            this.baudDropList.TabIndex = 3;
            this.baudDropList.Text = "9600";
            this.baudDropList.Type = AntdUI.TTypeMini.Primary;
            this.baudDropList.SelectedValueChanged += new AntdUI.ObjectNEventHandler(this.baudDropList_SelectedValueChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(16, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "波特率";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // serialPortsDropList
            // 
            this.serialPortsDropList.Location = new System.Drawing.Point(75, 9);
            this.serialPortsDropList.Name = "serialPortsDropList";
            this.serialPortsDropList.ShowArrow = true;
            this.serialPortsDropList.Size = new System.Drawing.Size(103, 35);
            this.serialPortsDropList.TabIndex = 1;
            this.serialPortsDropList.Text = "COM1";
            this.serialPortsDropList.Type = AntdUI.TTypeMini.Primary;
            this.serialPortsDropList.SelectedValueChanged += new AntdUI.ObjectNEventHandler(this.serialPortsDropList_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(16, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "串口名称";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabs1
            // 
            this.tabs1.Controls.Add(this.tabPage1);
            this.tabs1.Controls.Add(this.tabPage4);
            this.tabs1.Controls.Add(this.tabPage6);
            this.tabs1.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabs1.Location = new System.Drawing.Point(221, 12);
            this.tabs1.Name = "tabs1";
            this.tabs1.Pages.Add(this.tabPage1);
            this.tabs1.Pages.Add(this.tabPage4);
            this.tabs1.Pages.Add(this.tabPage6);
            this.tabs1.Size = new System.Drawing.Size(850, 542);
            styleCard2.Border = 0;
            this.tabs1.Style = styleCard2;
            this.tabs1.TabIndex = 3;
            this.tabs1.Text = "tabs1";
            this.tabs1.Type = AntdUI.TabType.Card;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.removeVariableBtn1);
            this.tabPage1.Controls.Add(this.addVariableBtn1);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.deviceNameInput2);
            this.tabPage1.Controls.Add(this.label11);
            this.tabPage1.Controls.Add(this.slaveInput1);
            this.tabPage1.Controls.Add(this.label10);
            this.tabPage1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage1.Location = new System.Drawing.Point(0, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(850, 515);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "  设备1  ";
            // 
            // removeVariableBtn1
            // 
            this.removeVariableBtn1.Location = new System.Drawing.Point(743, 6);
            this.removeVariableBtn1.Name = "removeVariableBtn1";
            this.removeVariableBtn1.Size = new System.Drawing.Size(91, 38);
            this.removeVariableBtn1.TabIndex = 24;
            this.removeVariableBtn1.Text = "删除变量";
            this.removeVariableBtn1.Type = AntdUI.TTypeMini.Error;
            // 
            // addVariableBtn1
            // 
            this.addVariableBtn1.Location = new System.Drawing.Point(646, 6);
            this.addVariableBtn1.Name = "addVariableBtn1";
            this.addVariableBtn1.Size = new System.Drawing.Size(91, 38);
            this.addVariableBtn1.TabIndex = 23;
            this.addVariableBtn1.Text = "添加变量";
            this.addVariableBtn1.Type = AntdUI.TTypeMini.Success;
            this.addVariableBtn1.Click += new System.EventHandler(this.addVariableBtn1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.v_name,
            this.addr,
            this.rate,
            this.offset,
            this.color,
            this.min,
            this.max});
            this.dataGridView1.Location = new System.Drawing.Point(17, 50);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(817, 448);
            this.dataGridView1.TabIndex = 22;
            // 
            // v_name
            // 
            this.v_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.v_name.DataPropertyName = "Name";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.v_name.DefaultCellStyle = dataGridViewCellStyle2;
            this.v_name.HeaderText = "变量名称";
            this.v_name.Name = "v_name";
            this.v_name.ReadOnly = true;
            this.v_name.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // addr
            // 
            this.addr.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addr.DataPropertyName = "Address";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.addr.DefaultCellStyle = dataGridViewCellStyle3;
            this.addr.HeaderText = "变量地址";
            this.addr.Name = "addr";
            this.addr.ReadOnly = true;
            this.addr.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // rate
            // 
            this.rate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.rate.DataPropertyName = "Rate";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.rate.DefaultCellStyle = dataGridViewCellStyle4;
            this.rate.HeaderText = "系数";
            this.rate.Name = "rate";
            this.rate.ReadOnly = true;
            this.rate.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // offset
            // 
            this.offset.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.offset.DataPropertyName = "Offset";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.offset.DefaultCellStyle = dataGridViewCellStyle5;
            this.offset.HeaderText = "偏移量";
            this.offset.Name = "offset";
            this.offset.ReadOnly = true;
            this.offset.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // color
            // 
            this.color.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.color.DataPropertyName = "Color";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.color.DefaultCellStyle = dataGridViewCellStyle6;
            this.color.HeaderText = "图表颜色";
            this.color.Name = "color";
            this.color.ReadOnly = true;
            this.color.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // min
            // 
            this.min.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.min.DataPropertyName = "Min";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.min.DefaultCellStyle = dataGridViewCellStyle7;
            this.min.HeaderText = "最小预警";
            this.min.Name = "min";
            this.min.ReadOnly = true;
            this.min.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // max
            // 
            this.max.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.max.DataPropertyName = "Max";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.max.DefaultCellStyle = dataGridViewCellStyle8;
            this.max.HeaderText = "最大预警";
            this.max.Name = "max";
            this.max.ReadOnly = true;
            this.max.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // deviceNameInput2
            // 
            this.deviceNameInput2.Location = new System.Drawing.Point(259, 9);
            this.deviceNameInput2.Name = "deviceNameInput2";
            this.deviceNameInput2.Size = new System.Drawing.Size(260, 35);
            this.deviceNameInput2.TabIndex = 21;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(202, 15);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(51, 23);
            this.label11.TabIndex = 20;
            this.label11.Text = "设备名称";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // slaveInput1
            // 
            this.slaveInput1.Location = new System.Drawing.Point(74, 9);
            this.slaveInput1.Name = "slaveInput1";
            this.slaveInput1.Size = new System.Drawing.Size(119, 35);
            this.slaveInput1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(17, 15);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 23);
            this.label10.TabIndex = 18;
            this.label10.Text = "从站地址";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage4.Location = new System.Drawing.Point(0, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(850, 515);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "  设备2  ";
            // 
            // tabPage6
            // 
            this.tabPage6.BackColor = System.Drawing.Color.White;
            this.tabPage6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPage6.Location = new System.Drawing.Point(0, 27);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Size = new System.Drawing.Size(850, 515);
            this.tabPage6.TabIndex = 2;
            this.tabPage6.Text = "  设备3  ";
            // 
            // SystemConfig
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1083, 566);
            this.Controls.Add(this.tabs1);
            this.Controls.Add(this.tabs5);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemConfig";
            this.Text = "SystemConfig";
            this.tabs5.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.tabs1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Tabs tabs5;
        private AntdUI.TabPage tabPage5;
        private AntdUI.Dropdown serialPortsDropList;
        private AntdUI.Label label1;
        private AntdUI.Dropdown dataBitsDropList;
        private AntdUI.Label label3;
        private AntdUI.Dropdown baudDropList;
        private AntdUI.Label label2;
        private AntdUI.Dropdown stopBitsDropList;
        private AntdUI.Label label5;
        private AntdUI.Dropdown parityDropList;
        private AntdUI.Label label4;
        private AntdUI.InputNumber readBufferInput;
        private AntdUI.Label label6;
        private AntdUI.InputNumber writeTimeoutInput;
        private AntdUI.Label label9;
        private AntdUI.InputNumber writeBufferInput;
        private AntdUI.Label label8;
        private AntdUI.InputNumber readTimeoutInput;
        private AntdUI.Label label7;
        private AntdUI.Tabs tabs1;
        private AntdUI.TabPage tabPage6;
        private AntdUI.TabPage tabPage4;
        private AntdUI.TabPage tabPage1;
        private AntdUI.Label label10;
        private AntdUI.Input deviceNameInput2;
        private AntdUI.Label label11;
        private AntdUI.Input slaveInput1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private AntdUI.Button addVariableBtn1;
        private AntdUI.Button removeVariableBtn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn offset;
        private System.Windows.Forms.DataGridViewTextBoxColumn color;
        private System.Windows.Forms.DataGridViewTextBoxColumn min;
        private System.Windows.Forms.DataGridViewTextBoxColumn max;
    }
}