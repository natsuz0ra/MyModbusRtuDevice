namespace MyModbusRtuDevice.Forms
{
    partial class AddVariable
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
            this.label1 = new AntdUI.Label();
            this.variableNameInput = new AntdUI.Input();
            this.label2 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.addrInput = new AntdUI.InputNumber();
            this.label5 = new AntdUI.Label();
            this.colorPicker = new AntdUI.ColorPicker();
            this.minValueInput = new AntdUI.InputNumber();
            this.label6 = new AntdUI.Label();
            this.maxValueInput = new AntdUI.InputNumber();
            this.label7 = new AntdUI.Label();
            this.confirmBtn = new AntdUI.Button();
            this.rateInput = new AntdUI.Input();
            this.offsetInput = new AntdUI.Input();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "变量地址";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // variableNameInput
            // 
            this.variableNameInput.Location = new System.Drawing.Point(87, 54);
            this.variableNameInput.Name = "variableNameInput";
            this.variableNameInput.Size = new System.Drawing.Size(183, 35);
            this.variableNameInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(16, 59);
            this.label2.Margin = new System.Windows.Forms.Padding(4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 3;
            this.label2.Text = "变量名称";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(16, 100);
            this.label3.Margin = new System.Windows.Forms.Padding(4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 24);
            this.label3.TabIndex = 5;
            this.label3.Text = "系数";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(16, 141);
            this.label4.Margin = new System.Windows.Forms.Padding(4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 24);
            this.label4.TabIndex = 7;
            this.label4.Text = "偏移量";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // addrInput
            // 
            this.addrInput.Location = new System.Drawing.Point(87, 13);
            this.addrInput.Name = "addrInput";
            this.addrInput.Size = new System.Drawing.Size(183, 35);
            this.addrInput.TabIndex = 9;
            this.addrInput.Text = "0";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(16, 182);
            this.label5.Margin = new System.Windows.Forms.Padding(4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 24);
            this.label5.TabIndex = 12;
            this.label5.Text = "图表颜色";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // colorPicker
            // 
            this.colorPicker.Location = new System.Drawing.Point(87, 177);
            this.colorPicker.Name = "colorPicker";
            this.colorPicker.Size = new System.Drawing.Size(183, 35);
            this.colorPicker.TabIndex = 13;
            this.colorPicker.Text = "col";
            this.colorPicker.Value = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(119)))), ((int)(((byte)(255)))));
            // 
            // minValueInput
            // 
            this.minValueInput.Location = new System.Drawing.Point(87, 218);
            this.minValueInput.Name = "minValueInput";
            this.minValueInput.Size = new System.Drawing.Size(183, 35);
            this.minValueInput.TabIndex = 15;
            this.minValueInput.Text = "0";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(16, 223);
            this.label6.Margin = new System.Windows.Forms.Padding(4);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 14;
            this.label6.Text = "最小预警值";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // maxValueInput
            // 
            this.maxValueInput.Location = new System.Drawing.Point(87, 259);
            this.maxValueInput.Name = "maxValueInput";
            this.maxValueInput.Size = new System.Drawing.Size(183, 35);
            this.maxValueInput.TabIndex = 17;
            this.maxValueInput.Text = "0";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(16, 264);
            this.label7.Margin = new System.Windows.Forms.Padding(4);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 24);
            this.label7.TabIndex = 16;
            this.label7.Text = "最大预警值";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(176, 300);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(94, 32);
            this.confirmBtn.TabIndex = 18;
            this.confirmBtn.Text = "确定";
            this.confirmBtn.Click += new System.EventHandler(this.confirmBtn_Click);
            // 
            // rateInput
            // 
            this.rateInput.Location = new System.Drawing.Point(87, 95);
            this.rateInput.Name = "rateInput";
            this.rateInput.Size = new System.Drawing.Size(183, 35);
            this.rateInput.TabIndex = 19;
            // 
            // offsetInput
            // 
            this.offsetInput.Location = new System.Drawing.Point(87, 136);
            this.offsetInput.Name = "offsetInput";
            this.offsetInput.Size = new System.Drawing.Size(183, 35);
            this.offsetInput.TabIndex = 20;
            // 
            // AddVariable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(282, 347);
            this.Controls.Add(this.offsetInput);
            this.Controls.Add(this.rateInput);
            this.Controls.Add(this.confirmBtn);
            this.Controls.Add(this.maxValueInput);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.minValueInput);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.colorPicker);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.addrInput);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.variableNameInput);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "AddVariable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加变量";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Label label1;
        private AntdUI.Input variableNameInput;
        private AntdUI.Label label2;
        private AntdUI.Label label3;
        private AntdUI.Label label4;
        private AntdUI.InputNumber addrInput;
        private AntdUI.Label label5;
        private AntdUI.ColorPicker colorPicker;
        private AntdUI.InputNumber minValueInput;
        private AntdUI.Label label6;
        private AntdUI.InputNumber maxValueInput;
        private AntdUI.Label label7;
        private AntdUI.Button confirmBtn;
        private AntdUI.Input rateInput;
        private AntdUI.Input offsetInput;
    }
}