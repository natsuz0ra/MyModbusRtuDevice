namespace MyModbusRtuDevice.Forms
{
    partial class StatusAlarm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.alarmProcBtn = new AntdUI.Button();
            this.exportBtn = new AntdUI.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datePickerRange = new AntdUI.DatePickerRange();
            this.label1 = new AntdUI.Label();
            this.searchBtn = new AntdUI.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.is_selected = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.d_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.d_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.v_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.value = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.time = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.state = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.Controls.Add(this.panel1);
            this.panel4.Controls.Add(this.panel2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1083, 40);
            this.panel4.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.alarmProcBtn);
            this.panel1.Controls.Add(this.exportBtn);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(868, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(215, 40);
            this.panel1.TabIndex = 8;
            // 
            // alarmProcBtn
            // 
            this.alarmProcBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.alarmProcBtn.Location = new System.Drawing.Point(104, 5);
            this.alarmProcBtn.Name = "alarmProcBtn";
            this.alarmProcBtn.Radius = 5;
            this.alarmProcBtn.Size = new System.Drawing.Size(104, 31);
            this.alarmProcBtn.TabIndex = 9;
            this.alarmProcBtn.Text = "报警处理";
            this.alarmProcBtn.Type = AntdUI.TTypeMini.Error;
            this.alarmProcBtn.Click += new System.EventHandler(this.alarmProcBtn_Click);
            // 
            // exportBtn
            // 
            this.exportBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.exportBtn.Location = new System.Drawing.Point(9, 5);
            this.exportBtn.Name = "exportBtn";
            this.exportBtn.Radius = 5;
            this.exportBtn.Size = new System.Drawing.Size(90, 31);
            this.exportBtn.TabIndex = 8;
            this.exportBtn.Text = "导出";
            this.exportBtn.Type = AntdUI.TTypeMini.Success;
            this.exportBtn.Click += new System.EventHandler(this.exportBtn_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.datePickerRange);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.searchBtn);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(469, 40);
            this.panel2.TabIndex = 7;
            // 
            // datePickerRange
            // 
            this.datePickerRange.Format = "yyyy-MM-dd HH:mm:ss";
            this.datePickerRange.Location = new System.Drawing.Point(74, 4);
            this.datePickerRange.Name = "datePickerRange";
            this.datePickerRange.Size = new System.Drawing.Size(291, 33);
            this.datePickerRange.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(8, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "起止时间";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.searchBtn.Location = new System.Drawing.Point(370, 5);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Radius = 5;
            this.searchBtn.Size = new System.Drawing.Size(90, 31);
            this.searchBtn.TabIndex = 6;
            this.searchBtn.Text = "刷新";
            this.searchBtn.Type = AntdUI.TTypeMini.Primary;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeColumns = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.is_selected,
            this.d_id,
            this.d_name,
            this.addr,
            this.v_name,
            this.value,
            this.message,
            this.time,
            this.state});
            this.dataGridView1.Location = new System.Drawing.Point(0, 40);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1083, 526);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // is_selected
            // 
            this.is_selected.DataPropertyName = "IsSelected";
            this.is_selected.HeaderText = "选择";
            this.is_selected.Name = "is_selected";
            this.is_selected.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.is_selected.Width = 40;
            // 
            // d_id
            // 
            this.d_id.DataPropertyName = "SlaveId";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.d_id.DefaultCellStyle = dataGridViewCellStyle2;
            this.d_id.HeaderText = "设备ID";
            this.d_id.Name = "d_id";
            this.d_id.ReadOnly = true;
            this.d_id.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.d_id.Width = 80;
            // 
            // d_name
            // 
            this.d_name.DataPropertyName = "DeviceName";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.d_name.DefaultCellStyle = dataGridViewCellStyle3;
            this.d_name.HeaderText = "设备名称";
            this.d_name.Name = "d_name";
            this.d_name.ReadOnly = true;
            this.d_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // addr
            // 
            this.addr.DataPropertyName = "Address";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.addr.DefaultCellStyle = dataGridViewCellStyle4;
            this.addr.HeaderText = "点位地址";
            this.addr.Name = "addr";
            this.addr.ReadOnly = true;
            this.addr.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.addr.Width = 80;
            // 
            // v_name
            // 
            this.v_name.DataPropertyName = "VariableName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.v_name.DefaultCellStyle = dataGridViewCellStyle5;
            this.v_name.HeaderText = "点位名称";
            this.v_name.Name = "v_name";
            this.v_name.ReadOnly = true;
            this.v_name.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // value
            // 
            this.value.DataPropertyName = "Value";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.value.DefaultCellStyle = dataGridViewCellStyle6;
            this.value.HeaderText = "报警值";
            this.value.Name = "value";
            this.value.ReadOnly = true;
            this.value.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // message
            // 
            this.message.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.message.DataPropertyName = "Message";
            this.message.HeaderText = "报警消息";
            this.message.MinimumWidth = 100;
            this.message.Name = "message";
            this.message.ReadOnly = true;
            this.message.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // time
            // 
            this.time.DataPropertyName = "Time";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.time.DefaultCellStyle = dataGridViewCellStyle7;
            this.time.HeaderText = "报警时间";
            this.time.Name = "time";
            this.time.ReadOnly = true;
            this.time.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.time.Width = 150;
            // 
            // state
            // 
            this.state.DataPropertyName = "State";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.state.DefaultCellStyle = dataGridViewCellStyle8;
            this.state.HeaderText = "状态";
            this.state.Name = "state";
            this.state.ReadOnly = true;
            this.state.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // StatusAlarm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1083, 566);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StatusAlarm";
            this.Text = "StatusAlarm";
            this.panel4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel4;
        private AntdUI.Label label1;
        private System.Windows.Forms.Panel panel2;
        private AntdUI.DatePickerRange datePickerRange;
        private AntdUI.Button searchBtn;
        private System.Windows.Forms.Panel panel1;
        private AntdUI.Button alarmProcBtn;
        private AntdUI.Button exportBtn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_selected;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn d_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn addr;
        private System.Windows.Forms.DataGridViewTextBoxColumn v_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn value;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
        private System.Windows.Forms.DataGridViewTextBoxColumn time;
        private System.Windows.Forms.DataGridViewTextBoxColumn state;
    }
}