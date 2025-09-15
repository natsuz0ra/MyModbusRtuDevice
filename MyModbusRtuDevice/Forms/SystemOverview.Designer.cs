namespace MyModbusRtuDevice.Forms
{
    partial class SystemOverview
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
            AntdUI.Tabs.StyleCard styleCard11 = new AntdUI.Tabs.StyleCard();
            AntdUI.Tabs.StyleCard styleCard12 = new AntdUI.Tabs.StyleCard();
            AntdUI.Tabs.StyleCard styleCard13 = new AntdUI.Tabs.StyleCard();
            AntdUI.Tabs.StyleCard styleCard14 = new AntdUI.Tabs.StyleCard();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint41 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 32D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint42 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint43 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 43D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint44 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 21D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint45 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 35D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint46 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 12D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint47 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 83D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint48 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 36D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint49 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9D, 68D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint50 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 92D);
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint51 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(1D, 32D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint52 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(2D, 10D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint53 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(3D, 43D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint54 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(4D, 21D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint55 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(5D, 35D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint56 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(6D, 12D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint57 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(7D, 83D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint58 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(8D, 36D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint59 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(9D, 68D);
            System.Windows.Forms.DataVisualization.Charting.DataPoint dataPoint60 = new System.Windows.Forms.DataVisualization.Charting.DataPoint(10D, 92D);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SystemOverview));
            AntdUI.Tabs.StyleCard styleCard15 = new AntdUI.Tabs.StyleCard();
            this.tabs1 = new AntdUI.Tabs();
            this.tabPage1 = new AntdUI.TabPage();
            this.labelErrNum = new AntdUI.Label();
            this.labelStopNum = new AntdUI.Label();
            this.label4 = new AntdUI.Label();
            this.label3 = new AntdUI.Label();
            this.labelRunNum = new AntdUI.Label();
            this.label1 = new AntdUI.Label();
            this.tabs2 = new AntdUI.Tabs();
            this.tabPage2 = new AntdUI.TabPage();
            this.rpMainPipeLeakage = new Sunny.UI.UIRoundProcess();
            this.label17 = new AntdUI.Label();
            this.rpMainPipeTraffic = new Sunny.UI.UIRoundProcess();
            this.label12 = new AntdUI.Label();
            this.label23 = new AntdUI.Label();
            this.label22 = new AntdUI.Label();
            this.label21 = new AntdUI.Label();
            this.label16 = new AntdUI.Label();
            this.label11 = new AntdUI.Label();
            this.label20 = new AntdUI.Label();
            this.label15 = new AntdUI.Label();
            this.label10 = new AntdUI.Label();
            this.label19 = new AntdUI.Label();
            this.label14 = new AntdUI.Label();
            this.label9 = new AntdUI.Label();
            this.label18 = new AntdUI.Label();
            this.label13 = new AntdUI.Label();
            this.label8 = new AntdUI.Label();
            this.rpMainPipePressure = new Sunny.UI.UIRoundProcess();
            this.label7 = new AntdUI.Label();
            this.tabs3 = new AntdUI.Tabs();
            this.tabPage3 = new AntdUI.TabPage();
            this.label26 = new AntdUI.Label();
            this.label25 = new AntdUI.Label();
            this.label24 = new AntdUI.Label();
            this.switch3 = new AntdUI.Switch();
            this.switch2 = new AntdUI.Switch();
            this.switch1 = new AntdUI.Switch();
            this.tabs4 = new AntdUI.Tabs();
            this.tabPage4 = new AntdUI.TabPage();
            this.label33 = new AntdUI.Label();
            this.label32 = new AntdUI.Label();
            this.label29 = new AntdUI.Label();
            this.label30 = new AntdUI.Label();
            this.label27 = new AntdUI.Label();
            this.label31 = new AntdUI.Label();
            this.label28 = new AntdUI.Label();
            this.uiRoundProcess4 = new Sunny.UI.UIRoundProcess();
            this.chart2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.uiPipe1 = new Sunny.UI.UIPipe();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.uiPipe2 = new Sunny.UI.UIPipe();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label34 = new AntdUI.Label();
            this.lbValveOpening2 = new AntdUI.Label();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.uiPipe3 = new Sunny.UI.UIPipe();
            this.uiPipe4 = new Sunny.UI.UIPipe();
            this.lbValveOpening3 = new AntdUI.Label();
            this.label37 = new AntdUI.Label();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.lbCurrentTraffic2 = new AntdUI.Label();
            this.label39 = new AntdUI.Label();
            this.uiPipe5 = new Sunny.UI.UIPipe();
            this.uiPipe6 = new Sunny.UI.UIPipe();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.uiPipe7 = new Sunny.UI.UIPipe();
            this.uiPipe8 = new Sunny.UI.UIPipe();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.uiPipe9 = new Sunny.UI.UIPipe();
            this.pictureBox13 = new System.Windows.Forms.PictureBox();
            this.uiPipe10 = new Sunny.UI.UIPipe();
            this.uiPipe11 = new Sunny.UI.UIPipe();
            this.uiPipe12 = new Sunny.UI.UIPipe();
            this.pictureBox14 = new System.Windows.Forms.PictureBox();
            this.pictureBox15 = new System.Windows.Forms.PictureBox();
            this.lbOutputPressure1 = new AntdUI.Label();
            this.label41 = new AntdUI.Label();
            this.lbOutputPressure2 = new AntdUI.Label();
            this.label43 = new AntdUI.Label();
            this.uiPipe13 = new Sunny.UI.UIPipe();
            this.uiPipe14 = new Sunny.UI.UIPipe();
            this.lbValveOpening1 = new AntdUI.Label();
            this.label45 = new AntdUI.Label();
            this.lbInputPressure1 = new AntdUI.Label();
            this.label47 = new AntdUI.Label();
            this.lbCurrentTraffic1 = new AntdUI.Label();
            this.label49 = new AntdUI.Label();
            this.uiTurnSwitch1 = new Sunny.UI.UITurnSwitch();
            this.uiTurnSwitch2 = new Sunny.UI.UITurnSwitch();
            this.uiTurnSwitch3 = new Sunny.UI.UITurnSwitch();
            this.uiTurnSwitch4 = new Sunny.UI.UITurnSwitch();
            this.label50 = new AntdUI.Label();
            this.label51 = new AntdUI.Label();
            this.label52 = new AntdUI.Label();
            this.label53 = new AntdUI.Label();
            this.tabs5 = new AntdUI.Tabs();
            this.tabPage5 = new AntdUI.TabPage();
            this.logListBox = new System.Windows.Forms.ListBox();
            this.tabs1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabs2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabs3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabs4.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).BeginInit();
            this.tabs5.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabs1
            // 
            this.tabs1.Controls.Add(this.tabPage1);
            this.tabs1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabs1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabs1.Location = new System.Drawing.Point(12, 12);
            this.tabs1.Name = "tabs1";
            this.tabs1.Pages.Add(this.tabPage1);
            this.tabs1.Size = new System.Drawing.Size(200, 120);
            styleCard11.Border = 0;
            this.tabs1.Style = styleCard11;
            this.tabs1.TabIndex = 0;
            this.tabs1.Text = "tabs1";
            this.tabs1.Type = AntdUI.TabType.Card;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.White;
            this.tabPage1.Controls.Add(this.labelErrNum);
            this.tabPage1.Controls.Add(this.labelStopNum);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.labelRunNum);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(3, 27);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(194, 90);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "|  设备状态 ";
            // 
            // labelErrNum
            // 
            this.labelErrNum.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.labelErrNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(99)))));
            this.labelErrNum.Location = new System.Drawing.Point(127, 45);
            this.labelErrNum.Name = "labelErrNum";
            this.labelErrNum.Size = new System.Drawing.Size(47, 23);
            this.labelErrNum.TabIndex = 5;
            this.labelErrNum.Text = "0";
            this.labelErrNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelStopNum
            // 
            this.labelStopNum.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.labelStopNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.labelStopNum.Location = new System.Drawing.Point(74, 45);
            this.labelStopNum.Name = "labelStopNum";
            this.labelStopNum.Size = new System.Drawing.Size(47, 23);
            this.labelStopNum.TabIndex = 4;
            this.labelStopNum.Text = "0";
            this.labelStopNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.label4.Location = new System.Drawing.Point(127, 16);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 23);
            this.label4.TabIndex = 3;
            this.label4.Text = "故障";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.label3.Location = new System.Drawing.Point(74, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 23);
            this.label3.TabIndex = 2;
            this.label3.Text = "停机";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelRunNum
            // 
            this.labelRunNum.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.labelRunNum.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.labelRunNum.Location = new System.Drawing.Point(21, 45);
            this.labelRunNum.Name = "labelRunNum";
            this.labelRunNum.Size = new System.Drawing.Size(47, 23);
            this.labelRunNum.TabIndex = 1;
            this.labelRunNum.Text = "0";
            this.labelRunNum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(158)))), ((int)(((byte)(158)))));
            this.label1.Location = new System.Drawing.Point(21, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "运行";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabs2
            // 
            this.tabs2.Controls.Add(this.tabPage2);
            this.tabs2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabs2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabs2.Location = new System.Drawing.Point(218, 12);
            this.tabs2.Name = "tabs2";
            this.tabs2.Pages.Add(this.tabPage2);
            this.tabs2.Size = new System.Drawing.Size(653, 120);
            styleCard12.Border = 0;
            this.tabs2.Style = styleCard12;
            this.tabs2.TabIndex = 1;
            this.tabs2.Text = "tabs2";
            this.tabs2.Type = AntdUI.TabType.Card;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.White;
            this.tabPage2.Controls.Add(this.rpMainPipeLeakage);
            this.tabPage2.Controls.Add(this.label17);
            this.tabPage2.Controls.Add(this.rpMainPipeTraffic);
            this.tabPage2.Controls.Add(this.label12);
            this.tabPage2.Controls.Add(this.label23);
            this.tabPage2.Controls.Add(this.label22);
            this.tabPage2.Controls.Add(this.label21);
            this.tabPage2.Controls.Add(this.label16);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label20);
            this.tabPage2.Controls.Add(this.label15);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.label19);
            this.tabPage2.Controls.Add(this.label14);
            this.tabPage2.Controls.Add(this.label9);
            this.tabPage2.Controls.Add(this.label18);
            this.tabPage2.Controls.Add(this.label13);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.rpMainPipePressure);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Location = new System.Drawing.Point(3, 27);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(647, 90);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "|  实时监测 ";
            // 
            // rpMainPipeLeakage
            // 
            this.rpMainPipeLeakage.BackColor = System.Drawing.Color.Transparent;
            this.rpMainPipeLeakage.DecimalPlaces = 0;
            this.rpMainPipeLeakage.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.rpMainPipeLeakage.ForeColor = System.Drawing.Color.Gray;
            this.rpMainPipeLeakage.ForeColor2 = System.Drawing.Color.Black;
            this.rpMainPipeLeakage.Inner = 28;
            this.rpMainPipeLeakage.Location = new System.Drawing.Point(489, 3);
            this.rpMainPipeLeakage.MinimumSize = new System.Drawing.Size(1, 1);
            this.rpMainPipeLeakage.Name = "rpMainPipeLeakage";
            this.rpMainPipeLeakage.Outer = 40;
            this.rpMainPipeLeakage.ProcessBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rpMainPipeLeakage.ProcessColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.rpMainPipeLeakage.ShowProcess = true;
            this.rpMainPipeLeakage.Size = new System.Drawing.Size(85, 85);
            this.rpMainPipeLeakage.StartAngle = 225;
            this.rpMainPipeLeakage.SweepAngle = 270;
            this.rpMainPipeLeakage.TabIndex = 18;
            this.rpMainPipeLeakage.Text = "0%";
            // 
            // label17
            // 
            this.label17.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label17.Location = new System.Drawing.Point(465, 9);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(22, 69);
            this.label17.TabIndex = 17;
            this.label17.Text = "主管漏点";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rpMainPipeTraffic
            // 
            this.rpMainPipeTraffic.BackColor = System.Drawing.Color.Transparent;
            this.rpMainPipeTraffic.DecimalPlaces = 0;
            this.rpMainPipeTraffic.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.rpMainPipeTraffic.ForeColor = System.Drawing.Color.Gray;
            this.rpMainPipeTraffic.ForeColor2 = System.Drawing.Color.Black;
            this.rpMainPipeTraffic.Inner = 28;
            this.rpMainPipeTraffic.Location = new System.Drawing.Point(269, 3);
            this.rpMainPipeTraffic.MinimumSize = new System.Drawing.Size(1, 1);
            this.rpMainPipeTraffic.Name = "rpMainPipeTraffic";
            this.rpMainPipeTraffic.Outer = 40;
            this.rpMainPipeTraffic.ProcessBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rpMainPipeTraffic.ProcessColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.rpMainPipeTraffic.ShowProcess = true;
            this.rpMainPipeTraffic.Size = new System.Drawing.Size(85, 85);
            this.rpMainPipeTraffic.StartAngle = 225;
            this.rpMainPipeTraffic.SweepAngle = 270;
            this.rpMainPipeTraffic.TabIndex = 16;
            this.rpMainPipeTraffic.Text = "0%";
            // 
            // label12
            // 
            this.label12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label12.Location = new System.Drawing.Point(245, 9);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(22, 69);
            this.label12.TabIndex = 15;
            this.label12.Text = "主管流量";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label23
            // 
            this.label23.BackColor = System.Drawing.Color.Gainsboro;
            this.label23.Location = new System.Drawing.Point(436, 20);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(1, 50);
            this.label23.TabIndex = 14;
            this.label23.Text = "";
            // 
            // label22
            // 
            this.label22.BackColor = System.Drawing.Color.Gainsboro;
            this.label22.Location = new System.Drawing.Point(216, 20);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(1, 50);
            this.label22.TabIndex = 13;
            this.label22.Text = "";
            // 
            // label21
            // 
            this.label21.BackColor = System.Drawing.Color.Transparent;
            this.label21.Location = new System.Drawing.Point(580, 67);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(41, 15);
            this.label21.TabIndex = 12;
            this.label21.Text = "11.2";
            this.label21.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label16
            // 
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Location = new System.Drawing.Point(360, 67);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(41, 15);
            this.label16.TabIndex = 12;
            this.label16.Text = "11.2";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label11
            // 
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Location = new System.Drawing.Point(139, 67);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 15);
            this.label11.TabIndex = 12;
            this.label11.Text = "11.2";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.BackColor = System.Drawing.Color.Transparent;
            this.label20.Location = new System.Drawing.Point(580, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(41, 15);
            this.label20.TabIndex = 11;
            this.label20.Text = "45.2";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label15
            // 
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Location = new System.Drawing.Point(360, 30);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(41, 15);
            this.label15.TabIndex = 11;
            this.label15.Text = "45.2";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label10
            // 
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Location = new System.Drawing.Point(139, 30);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 15);
            this.label10.TabIndex = 11;
            this.label10.Text = "45.2";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label19
            // 
            this.label19.BackColor = System.Drawing.Color.Transparent;
            this.label19.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.label19.Location = new System.Drawing.Point(580, 45);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(41, 23);
            this.label19.TabIndex = 10;
            this.label19.Text = "最小值";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label14
            // 
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.label14.Location = new System.Drawing.Point(360, 45);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 23);
            this.label14.TabIndex = 10;
            this.label14.Text = "最小值";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label9
            // 
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.label9.Location = new System.Drawing.Point(139, 45);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 23);
            this.label9.TabIndex = 10;
            this.label9.Text = "最小值";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label18.Location = new System.Drawing.Point(580, 8);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 23);
            this.label18.TabIndex = 9;
            this.label18.Text = "最大值";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label13
            // 
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label13.Location = new System.Drawing.Point(360, 8);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(41, 23);
            this.label13.TabIndex = 9;
            this.label13.Text = "最大值";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label8
            // 
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label8.Location = new System.Drawing.Point(139, 8);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(41, 23);
            this.label8.TabIndex = 9;
            this.label8.Text = "最大值";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // rpMainPipePressure
            // 
            this.rpMainPipePressure.BackColor = System.Drawing.Color.Transparent;
            this.rpMainPipePressure.DecimalPlaces = 0;
            this.rpMainPipePressure.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.rpMainPipePressure.ForeColor = System.Drawing.Color.Gray;
            this.rpMainPipePressure.ForeColor2 = System.Drawing.Color.Black;
            this.rpMainPipePressure.Inner = 28;
            this.rpMainPipePressure.Location = new System.Drawing.Point(49, 3);
            this.rpMainPipePressure.MinimumSize = new System.Drawing.Size(1, 1);
            this.rpMainPipePressure.Name = "rpMainPipePressure";
            this.rpMainPipePressure.Outer = 40;
            this.rpMainPipePressure.ProcessBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.rpMainPipePressure.ProcessColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(158)))), ((int)(((byte)(254)))));
            this.rpMainPipePressure.ShowProcess = true;
            this.rpMainPipePressure.Size = new System.Drawing.Size(85, 85);
            this.rpMainPipePressure.StartAngle = 225;
            this.rpMainPipePressure.SweepAngle = 270;
            this.rpMainPipePressure.TabIndex = 8;
            this.rpMainPipePressure.Text = "0%";
            // 
            // label7
            // 
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label7.Location = new System.Drawing.Point(25, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(22, 69);
            this.label7.TabIndex = 6;
            this.label7.Text = "主管压力";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabs3
            // 
            this.tabs3.Controls.Add(this.tabPage3);
            this.tabs3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.tabs3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabs3.Location = new System.Drawing.Point(877, 12);
            this.tabs3.Name = "tabs3";
            this.tabs3.Pages.Add(this.tabPage3);
            this.tabs3.Size = new System.Drawing.Size(196, 120);
            styleCard13.Border = 0;
            this.tabs3.Style = styleCard13;
            this.tabs3.TabIndex = 1;
            this.tabs3.Text = "tabs3";
            this.tabs3.Type = AntdUI.TabType.Card;
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.White;
            this.tabPage3.Controls.Add(this.label26);
            this.tabPage3.Controls.Add(this.label25);
            this.tabPage3.Controls.Add(this.label24);
            this.tabPage3.Controls.Add(this.switch3);
            this.tabPage3.Controls.Add(this.switch2);
            this.tabPage3.Controls.Add(this.switch1);
            this.tabPage3.Location = new System.Drawing.Point(3, 27);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(190, 90);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "|  设备控制 ";
            // 
            // label26
            // 
            this.label26.Location = new System.Drawing.Point(130, 14);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(54, 23);
            this.label26.TabIndex = 5;
            this.label26.Text = "开关三";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label25
            // 
            this.label25.Location = new System.Drawing.Point(68, 14);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(54, 23);
            this.label25.TabIndex = 4;
            this.label25.Text = "开关二";
            this.label25.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.Location = new System.Drawing.Point(7, 14);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(54, 23);
            this.label24.TabIndex = 3;
            this.label24.Text = "开关一";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // switch3
            // 
            this.switch3.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.switch3.FillHover = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(152)))), ((int)(((byte)(0)))));
            this.switch3.Location = new System.Drawing.Point(129, 43);
            this.switch3.Name = "switch3";
            this.switch3.Size = new System.Drawing.Size(56, 35);
            this.switch3.TabIndex = 2;
            this.switch3.Text = "switch3";
            this.switch3.Click += new System.EventHandler(this.switch3_Click);
            // 
            // switch2
            // 
            this.switch2.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.switch2.FillHover = System.Drawing.Color.FromArgb(((int)(((byte)(233)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.switch2.Location = new System.Drawing.Point(67, 43);
            this.switch2.Name = "switch2";
            this.switch2.Size = new System.Drawing.Size(56, 35);
            this.switch2.TabIndex = 1;
            this.switch2.Text = "switch2";
            this.switch2.Click += new System.EventHandler(this.switch2_Click);
            // 
            // switch1
            // 
            this.switch1.CheckedText = "";
            this.switch1.Fill = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.switch1.FillHover = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.switch1.Location = new System.Drawing.Point(6, 43);
            this.switch1.Name = "switch1";
            this.switch1.Size = new System.Drawing.Size(56, 35);
            this.switch1.TabIndex = 0;
            this.switch1.Text = "switch1";
            this.switch1.Click += new System.EventHandler(this.switch1_Click);
            // 
            // tabs4
            // 
            this.tabs4.Controls.Add(this.tabPage4);
            this.tabs4.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabs4.Location = new System.Drawing.Point(12, 140);
            this.tabs4.Name = "tabs4";
            this.tabs4.Pages.Add(this.tabPage4);
            this.tabs4.Size = new System.Drawing.Size(197, 414);
            styleCard14.Border = 0;
            this.tabs4.Style = styleCard14;
            this.tabs4.TabIndex = 2;
            this.tabs4.Text = "tabs4";
            this.tabs4.Type = AntdUI.TabType.Card;
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.White;
            this.tabPage4.Controls.Add(this.label33);
            this.tabPage4.Controls.Add(this.label32);
            this.tabPage4.Controls.Add(this.label29);
            this.tabPage4.Controls.Add(this.label30);
            this.tabPage4.Controls.Add(this.label27);
            this.tabPage4.Controls.Add(this.label31);
            this.tabPage4.Controls.Add(this.label28);
            this.tabPage4.Controls.Add(this.uiRoundProcess4);
            this.tabPage4.Controls.Add(this.chart2);
            this.tabPage4.Controls.Add(this.chart1);
            this.tabPage4.Location = new System.Drawing.Point(3, 27);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(191, 384);
            this.tabPage4.TabIndex = 0;
            this.tabPage4.Text = "|  总体数据监测 ";
            // 
            // label33
            // 
            this.label33.BackColor = System.Drawing.Color.Transparent;
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label33.Location = new System.Drawing.Point(7, 262);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(133, 23);
            this.label33.TabIndex = 22;
            this.label33.Text = "生产进度";
            // 
            // label32
            // 
            this.label32.BackColor = System.Drawing.Color.Transparent;
            this.label32.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label32.Location = new System.Drawing.Point(7, 133);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(133, 23);
            this.label32.TabIndex = 21;
            this.label32.Text = "耗电量：kWh";
            // 
            // label29
            // 
            this.label29.BackColor = System.Drawing.Color.Transparent;
            this.label29.Location = new System.Drawing.Point(122, 351);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(41, 15);
            this.label29.TabIndex = 20;
            this.label29.Text = "350";
            this.label29.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label30
            // 
            this.label30.BackColor = System.Drawing.Color.Transparent;
            this.label30.Location = new System.Drawing.Point(122, 314);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(41, 15);
            this.label30.TabIndex = 19;
            this.label30.Text = "1000";
            this.label30.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label27
            // 
            this.label27.BackColor = System.Drawing.Color.Transparent;
            this.label27.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.label27.Location = new System.Drawing.Point(115, 329);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(48, 23);
            this.label27.TabIndex = 20;
            this.label27.Text = "实际产量";
            this.label27.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label31
            // 
            this.label31.BackColor = System.Drawing.Color.Transparent;
            this.label31.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label31.Location = new System.Drawing.Point(7, 7);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(133, 23);
            this.label31.TabIndex = 19;
            this.label31.Text = "生气效率：kwH/Nm3";
            // 
            // label28
            // 
            this.label28.BackColor = System.Drawing.Color.Transparent;
            this.label28.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label28.Location = new System.Drawing.Point(115, 291);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(48, 23);
            this.label28.TabIndex = 19;
            this.label28.Text = "生产计划";
            this.label28.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // uiRoundProcess4
            // 
            this.uiRoundProcess4.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.uiRoundProcess4.ForeColor2 = System.Drawing.Color.Black;
            this.uiRoundProcess4.Inner = 0;
            this.uiRoundProcess4.Location = new System.Drawing.Point(25, 291);
            this.uiRoundProcess4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiRoundProcess4.Name = "uiRoundProcess4";
            this.uiRoundProcess4.Outer = 35;
            this.uiRoundProcess4.ShowProcess = true;
            this.uiRoundProcess4.Size = new System.Drawing.Size(75, 75);
            this.uiRoundProcess4.TabIndex = 2;
            this.uiRoundProcess4.Text = "35.0%";
            this.uiRoundProcess4.Value = 35;
            // 
            // chart2
            // 
            chartArea5.AxisX.Interval = 1D;
            chartArea5.AxisX.IsLabelAutoFit = false;
            chartArea5.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea5.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            chartArea5.AxisX.LineWidth = 0;
            chartArea5.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea5.AxisY.IsLabelAutoFit = false;
            chartArea5.AxisY.LabelAutoFitMaxFontSize = 5;
            chartArea5.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            chartArea5.AxisY.LineColor = System.Drawing.Color.LightGray;
            chartArea5.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea5.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea5.Name = "ChartArea1";
            this.chart2.ChartAreas.Add(chartArea5);
            this.chart2.Location = new System.Drawing.Point(-7, 155);
            this.chart2.Name = "chart2";
            series5.ChartArea = "ChartArea1";
            series5.Color = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            series5.Name = "Series1";
            series5.Points.Add(dataPoint41);
            series5.Points.Add(dataPoint42);
            series5.Points.Add(dataPoint43);
            series5.Points.Add(dataPoint44);
            series5.Points.Add(dataPoint45);
            series5.Points.Add(dataPoint46);
            series5.Points.Add(dataPoint47);
            series5.Points.Add(dataPoint48);
            series5.Points.Add(dataPoint49);
            series5.Points.Add(dataPoint50);
            this.chart2.Series.Add(series5);
            this.chart2.Size = new System.Drawing.Size(204, 101);
            this.chart2.TabIndex = 1;
            this.chart2.Text = "chart2";
            // 
            // chart1
            // 
            chartArea6.AxisX.Interval = 1D;
            chartArea6.AxisX.IsLabelAutoFit = false;
            chartArea6.AxisX.LabelAutoFitMaxFontSize = 6;
            chartArea6.AxisX.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            chartArea6.AxisX.LineWidth = 0;
            chartArea6.AxisX.MajorGrid.LineColor = System.Drawing.Color.LightGray;
            chartArea6.AxisY.IsLabelAutoFit = false;
            chartArea6.AxisY.LabelAutoFitMaxFontSize = 5;
            chartArea6.AxisY.LabelStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F);
            chartArea6.AxisY.LineColor = System.Drawing.Color.LightGray;
            chartArea6.AxisY.MajorGrid.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            chartArea6.AxisY.MajorGrid.LineDashStyle = System.Windows.Forms.DataVisualization.Charting.ChartDashStyle.Dash;
            chartArea6.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea6);
            this.chart1.Location = new System.Drawing.Point(-7, 29);
            this.chart1.Name = "chart1";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Color = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            series6.Name = "Series1";
            series6.Points.Add(dataPoint51);
            series6.Points.Add(dataPoint52);
            series6.Points.Add(dataPoint53);
            series6.Points.Add(dataPoint54);
            series6.Points.Add(dataPoint55);
            series6.Points.Add(dataPoint56);
            series6.Points.Add(dataPoint57);
            series6.Points.Add(dataPoint58);
            series6.Points.Add(dataPoint59);
            series6.Points.Add(dataPoint60);
            this.chart1.Series.Add(series6);
            this.chart1.Size = new System.Drawing.Size(204, 101);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(252, 139);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(35, 35);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(331, 143);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(43, 43);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 4;
            this.pictureBox2.TabStop = false;
            // 
            // uiPipe1
            // 
            this.uiPipe1.Active = true;
            this.uiPipe1.FlowColor = System.Drawing.Color.DodgerBlue;
            this.uiPipe1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPipe1.Location = new System.Drawing.Point(223, 157);
            this.uiPipe1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe1.Name = "uiPipe1";
            this.uiPipe1.Radius = 16;
            this.uiPipe1.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPipe1.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPipe1.ShowFocusColor = true;
            this.uiPipe1.Size = new System.Drawing.Size(611, 16);
            this.uiPipe1.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe1.StyleCustomMode = true;
            this.uiPipe1.TabIndex = 5;
            this.uiPipe1.Text = "uiPipe1";
            this.uiPipe1.ZoomScaleDisabled = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(694, 143);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(40, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(519, 139);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(40, 40);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 7;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(425, 249);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(150, 150);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 8;
            this.pictureBox5.TabStop = false;
            // 
            // uiPipe2
            // 
            this.uiPipe2.Active = true;
            this.uiPipe2.FlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiPipe2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPipe2.Location = new System.Drawing.Point(223, 355);
            this.uiPipe2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe2.Name = "uiPipe2";
            this.uiPipe2.Radius = 16;
            this.uiPipe2.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPipe2.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPipe2.ShowFocusColor = true;
            this.uiPipe2.Size = new System.Drawing.Size(554, 16);
            this.uiPipe2.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe2.StyleCustomMode = true;
            this.uiPipe2.TabIndex = 9;
            this.uiPipe2.Text = "uiPipe2";
            this.uiPipe2.ZoomScaleDisabled = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(252, 336);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(35, 35);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 10;
            this.pictureBox6.TabStop = false;
            // 
            // label34
            // 
            this.label34.Location = new System.Drawing.Point(238, 296);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(62, 23);
            this.label34.TabIndex = 11;
            this.label34.Text = "阀门开度：";
            // 
            // lbValveOpening2
            // 
            this.lbValveOpening2.Location = new System.Drawing.Point(238, 314);
            this.lbValveOpening2.Name = "lbValveOpening2";
            this.lbValveOpening2.Size = new System.Drawing.Size(62, 19);
            this.lbValveOpening2.TabIndex = 12;
            this.lbValveOpening2.Text = "0%";
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(339, 336);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(40, 40);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 13;
            this.pictureBox7.TabStop = false;
            // 
            // uiPipe3
            // 
            this.uiPipe3.Active = true;
            this.uiPipe3.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiPipe3.FlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiPipe3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPipe3.Location = new System.Drawing.Point(389, 371);
            this.uiPipe3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe3.Name = "uiPipe3";
            this.uiPipe3.Radius = 16;
            this.uiPipe3.RadiusSides = Sunny.UI.UICornerRadiusSides.RightBottom;
            this.uiPipe3.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPipe3.ShowFocusColor = true;
            this.uiPipe3.Size = new System.Drawing.Size(16, 141);
            this.uiPipe3.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe3.StyleCustomMode = true;
            this.uiPipe3.TabIndex = 14;
            this.uiPipe3.Text = "uiPipe3";
            this.uiPipe3.ZoomScaleDisabled = true;
            // 
            // uiPipe4
            // 
            this.uiPipe4.Active = true;
            this.uiPipe4.FlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiPipe4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPipe4.Location = new System.Drawing.Point(223, 496);
            this.uiPipe4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe4.Name = "uiPipe4";
            this.uiPipe4.Radius = 16;
            this.uiPipe4.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPipe4.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPipe4.ShowFocusColor = true;
            this.uiPipe4.Size = new System.Drawing.Size(182, 16);
            this.uiPipe4.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe4.StyleCustomMode = true;
            this.uiPipe4.TabIndex = 15;
            this.uiPipe4.Text = "uiPipe4";
            this.uiPipe4.ZoomScaleDisabled = true;
            // 
            // lbValveOpening3
            // 
            this.lbValveOpening3.Location = new System.Drawing.Point(238, 456);
            this.lbValveOpening3.Name = "lbValveOpening3";
            this.lbValveOpening3.Size = new System.Drawing.Size(62, 19);
            this.lbValveOpening3.TabIndex = 18;
            this.lbValveOpening3.Text = "0%";
            // 
            // label37
            // 
            this.label37.Location = new System.Drawing.Point(238, 438);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(62, 23);
            this.label37.TabIndex = 17;
            this.label37.Text = "阀门开度：";
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(252, 477);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(35, 35);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 16;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(339, 457);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(40, 40);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 19;
            this.pictureBox9.TabStop = false;
            // 
            // lbCurrentTraffic2
            // 
            this.lbCurrentTraffic2.Location = new System.Drawing.Point(331, 531);
            this.lbCurrentTraffic2.Name = "lbCurrentTraffic2";
            this.lbCurrentTraffic2.Size = new System.Drawing.Size(69, 19);
            this.lbCurrentTraffic2.TabIndex = 21;
            this.lbCurrentTraffic2.Text = "0 m³";
            // 
            // label39
            // 
            this.label39.Location = new System.Drawing.Point(330, 513);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(69, 23);
            this.label39.TabIndex = 20;
            this.label39.Text = "当前流量：";
            // 
            // uiPipe5
            // 
            this.uiPipe5.Active = true;
            this.uiPipe5.FlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiPipe5.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPipe5.Location = new System.Drawing.Point(403, 450);
            this.uiPipe5.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe5.Name = "uiPipe5";
            this.uiPipe5.Radius = 16;
            this.uiPipe5.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPipe5.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPipe5.ShowFocusColor = true;
            this.uiPipe5.Size = new System.Drawing.Size(182, 16);
            this.uiPipe5.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe5.StyleCustomMode = true;
            this.uiPipe5.TabIndex = 22;
            this.uiPipe5.Text = "uiPipe5";
            this.uiPipe5.ZoomScaleDisabled = true;
            // 
            // uiPipe6
            // 
            this.uiPipe6.Active = true;
            this.uiPipe6.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiPipe6.FlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiPipe6.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPipe6.Location = new System.Drawing.Point(569, 450);
            this.uiPipe6.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe6.Name = "uiPipe6";
            this.uiPipe6.Radius = 16;
            this.uiPipe6.RadiusSides = Sunny.UI.UICornerRadiusSides.RightTop;
            this.uiPipe6.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPipe6.ShowFocusColor = true;
            this.uiPipe6.Size = new System.Drawing.Size(16, 46);
            this.uiPipe6.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe6.StyleCustomMode = true;
            this.uiPipe6.TabIndex = 23;
            this.uiPipe6.Text = "uiPipe6";
            this.uiPipe6.ZoomScaleDisabled = true;
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(434, 431);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(35, 35);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 24;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox11.Image")));
            this.pictureBox11.Location = new System.Drawing.Point(522, 472);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(193, 94);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 25;
            this.pictureBox11.TabStop = false;
            // 
            // uiPipe7
            // 
            this.uiPipe7.Active = true;
            this.uiPipe7.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiPipe7.FlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiPipe7.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPipe7.Location = new System.Drawing.Point(629, 450);
            this.uiPipe7.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe7.Name = "uiPipe7";
            this.uiPipe7.Radius = 16;
            this.uiPipe7.RadiusSides = Sunny.UI.UICornerRadiusSides.LeftTop;
            this.uiPipe7.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPipe7.ShowFocusColor = true;
            this.uiPipe7.Size = new System.Drawing.Size(16, 46);
            this.uiPipe7.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe7.StyleCustomMode = true;
            this.uiPipe7.TabIndex = 26;
            this.uiPipe7.Text = "uiPipe7";
            this.uiPipe7.ZoomScaleDisabled = true;
            // 
            // uiPipe8
            // 
            this.uiPipe8.Active = true;
            this.uiPipe8.FlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiPipe8.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPipe8.Location = new System.Drawing.Point(629, 450);
            this.uiPipe8.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe8.Name = "uiPipe8";
            this.uiPipe8.Radius = 16;
            this.uiPipe8.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPipe8.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPipe8.ShowFocusColor = true;
            this.uiPipe8.Size = new System.Drawing.Size(166, 16);
            this.uiPipe8.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe8.StyleCustomMode = true;
            this.uiPipe8.TabIndex = 27;
            this.uiPipe8.Text = "uiPipe8";
            this.uiPipe8.ZoomScaleDisabled = true;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.Location = new System.Drawing.Point(694, 340);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(40, 40);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 28;
            this.pictureBox12.TabStop = false;
            // 
            // uiPipe9
            // 
            this.uiPipe9.Active = true;
            this.uiPipe9.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiPipe9.FlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiPipe9.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPipe9.Location = new System.Drawing.Point(778, 157);
            this.uiPipe9.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe9.Name = "uiPipe9";
            this.uiPipe9.Radius = 16;
            this.uiPipe9.RadiusSides = Sunny.UI.UICornerRadiusSides.RightBottom;
            this.uiPipe9.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPipe9.ShowFocusColor = true;
            this.uiPipe9.Size = new System.Drawing.Size(16, 309);
            this.uiPipe9.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe9.StyleCustomMode = true;
            this.uiPipe9.TabIndex = 29;
            this.uiPipe9.Text = "uiPipe9";
            this.uiPipe9.ZoomScaleDisabled = true;
            // 
            // pictureBox13
            // 
            this.pictureBox13.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox13.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox13.Image")));
            this.pictureBox13.Location = new System.Drawing.Point(778, 397);
            this.pictureBox13.Name = "pictureBox13";
            this.pictureBox13.Size = new System.Drawing.Size(35, 35);
            this.pictureBox13.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox13.TabIndex = 30;
            this.pictureBox13.TabStop = false;
            // 
            // uiPipe10
            // 
            this.uiPipe10.Active = true;
            this.uiPipe10.FlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiPipe10.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPipe10.Location = new System.Drawing.Point(702, 490);
            this.uiPipe10.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe10.Name = "uiPipe10";
            this.uiPipe10.Radius = 16;
            this.uiPipe10.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPipe10.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPipe10.ShowFocusColor = true;
            this.uiPipe10.Size = new System.Drawing.Size(132, 16);
            this.uiPipe10.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe10.StyleCustomMode = true;
            this.uiPipe10.TabIndex = 31;
            this.uiPipe10.Text = "uiPipe10";
            this.uiPipe10.ZoomScaleDisabled = true;
            // 
            // uiPipe11
            // 
            this.uiPipe11.Active = true;
            this.uiPipe11.FlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiPipe11.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPipe11.Location = new System.Drawing.Point(569, 293);
            this.uiPipe11.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe11.Name = "uiPipe11";
            this.uiPipe11.Radius = 16;
            this.uiPipe11.RadiusSides = Sunny.UI.UICornerRadiusSides.None;
            this.uiPipe11.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPipe11.ShowFocusColor = true;
            this.uiPipe11.Size = new System.Drawing.Size(119, 16);
            this.uiPipe11.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe11.StyleCustomMode = true;
            this.uiPipe11.TabIndex = 32;
            this.uiPipe11.Text = "uiPipe11";
            this.uiPipe11.ZoomScaleDisabled = true;
            // 
            // uiPipe12
            // 
            this.uiPipe12.Active = true;
            this.uiPipe12.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiPipe12.FlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.uiPipe12.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPipe12.Location = new System.Drawing.Point(672, 157);
            this.uiPipe12.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe12.Name = "uiPipe12";
            this.uiPipe12.Radius = 16;
            this.uiPipe12.RadiusSides = Sunny.UI.UICornerRadiusSides.RightBottom;
            this.uiPipe12.ShowFocusColor = true;
            this.uiPipe12.Size = new System.Drawing.Size(16, 152);
            this.uiPipe12.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe12.StyleCustomMode = true;
            this.uiPipe12.TabIndex = 33;
            this.uiPipe12.Text = "uiPipe12";
            this.uiPipe12.ZoomScaleDisabled = true;
            // 
            // pictureBox14
            // 
            this.pictureBox14.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox14.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox14.Image")));
            this.pictureBox14.Location = new System.Drawing.Point(595, 255);
            this.pictureBox14.Name = "pictureBox14";
            this.pictureBox14.Size = new System.Drawing.Size(40, 40);
            this.pictureBox14.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox14.TabIndex = 34;
            this.pictureBox14.TabStop = false;
            // 
            // pictureBox15
            // 
            this.pictureBox15.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox15.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox15.Image")));
            this.pictureBox15.Location = new System.Drawing.Point(595, 314);
            this.pictureBox15.Name = "pictureBox15";
            this.pictureBox15.Size = new System.Drawing.Size(40, 40);
            this.pictureBox15.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox15.TabIndex = 35;
            this.pictureBox15.TabStop = false;
            // 
            // lbOutputPressure1
            // 
            this.lbOutputPressure1.Location = new System.Drawing.Point(595, 232);
            this.lbOutputPressure1.Name = "lbOutputPressure1";
            this.lbOutputPressure1.Size = new System.Drawing.Size(60, 19);
            this.lbOutputPressure1.TabIndex = 37;
            this.lbOutputPressure1.Text = "0 Mpa";
            // 
            // label41
            // 
            this.label41.Location = new System.Drawing.Point(595, 214);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(60, 23);
            this.label41.TabIndex = 36;
            this.label41.Text = "输出压力：";
            // 
            // lbOutputPressure2
            // 
            this.lbOutputPressure2.Location = new System.Drawing.Point(595, 390);
            this.lbOutputPressure2.Name = "lbOutputPressure2";
            this.lbOutputPressure2.Size = new System.Drawing.Size(60, 19);
            this.lbOutputPressure2.TabIndex = 39;
            this.lbOutputPressure2.Text = "0 Mpa";
            // 
            // label43
            // 
            this.label43.Location = new System.Drawing.Point(595, 372);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(60, 23);
            this.label43.TabIndex = 38;
            this.label43.Text = "输出压力：";
            // 
            // uiPipe13
            // 
            this.uiPipe13.Active = true;
            this.uiPipe13.Direction = Sunny.UI.UILine.LineDirection.Vertical;
            this.uiPipe13.FlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiPipe13.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPipe13.Location = new System.Drawing.Point(383, 157);
            this.uiPipe13.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe13.Name = "uiPipe13";
            this.uiPipe13.Radius = 16;
            this.uiPipe13.RadiusSides = ((Sunny.UI.UICornerRadiusSides)(((Sunny.UI.UICornerRadiusSides.LeftTop | Sunny.UI.UICornerRadiusSides.RightTop) 
            | Sunny.UI.UICornerRadiusSides.LeftBottom)));
            this.uiPipe13.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPipe13.ShowFocusColor = true;
            this.uiPipe13.Size = new System.Drawing.Size(16, 152);
            this.uiPipe13.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe13.StyleCustomMode = true;
            this.uiPipe13.TabIndex = 40;
            this.uiPipe13.Text = "uiPipe13";
            this.uiPipe13.ZoomScaleDisabled = true;
            // 
            // uiPipe14
            // 
            this.uiPipe14.Active = true;
            this.uiPipe14.FlowColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.uiPipe14.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiPipe14.Location = new System.Drawing.Point(383, 293);
            this.uiPipe14.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiPipe14.Name = "uiPipe14";
            this.uiPipe14.Radius = 16;
            this.uiPipe14.RectSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.None;
            this.uiPipe14.ShowFocusColor = true;
            this.uiPipe14.Size = new System.Drawing.Size(49, 16);
            this.uiPipe14.Style = Sunny.UI.UIStyle.Custom;
            this.uiPipe14.StyleCustomMode = true;
            this.uiPipe14.TabIndex = 41;
            this.uiPipe14.Text = "uiPipe14";
            this.uiPipe14.ZoomScaleDisabled = true;
            // 
            // lbValveOpening1
            // 
            this.lbValveOpening1.Location = new System.Drawing.Point(238, 205);
            this.lbValveOpening1.Name = "lbValveOpening1";
            this.lbValveOpening1.Size = new System.Drawing.Size(62, 19);
            this.lbValveOpening1.TabIndex = 43;
            this.lbValveOpening1.Text = "0%";
            // 
            // label45
            // 
            this.label45.Location = new System.Drawing.Point(238, 187);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(62, 23);
            this.label45.TabIndex = 42;
            this.label45.Text = "阀门开度：";
            // 
            // lbInputPressure1
            // 
            this.lbInputPressure1.Location = new System.Drawing.Point(317, 205);
            this.lbInputPressure1.Name = "lbInputPressure1";
            this.lbInputPressure1.Size = new System.Drawing.Size(60, 19);
            this.lbInputPressure1.TabIndex = 45;
            this.lbInputPressure1.Text = "0 Mpa";
            // 
            // label47
            // 
            this.label47.Location = new System.Drawing.Point(317, 187);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(60, 23);
            this.label47.TabIndex = 44;
            this.label47.Text = "输入压力：";
            // 
            // lbCurrentTraffic1
            // 
            this.lbCurrentTraffic1.Location = new System.Drawing.Point(507, 205);
            this.lbCurrentTraffic1.Name = "lbCurrentTraffic1";
            this.lbCurrentTraffic1.Size = new System.Drawing.Size(69, 19);
            this.lbCurrentTraffic1.TabIndex = 47;
            this.lbCurrentTraffic1.Text = "0 m³";
            // 
            // label49
            // 
            this.label49.Location = new System.Drawing.Point(506, 187);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(69, 23);
            this.label49.TabIndex = 46;
            this.label49.Text = "当前流量：";
            // 
            // uiTurnSwitch1
            // 
            this.uiTurnSwitch1.ActiveText = "";
            this.uiTurnSwitch1.BackInnerSize = 50;
            this.uiTurnSwitch1.BackSize = 30;
            this.uiTurnSwitch1.FillColor = System.Drawing.Color.LightGray;
            this.uiTurnSwitch1.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTurnSwitch1.InActiveText = "";
            this.uiTurnSwitch1.Location = new System.Drawing.Point(837, 164);
            this.uiTurnSwitch1.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTurnSwitch1.Name = "uiTurnSwitch1";
            this.uiTurnSwitch1.Size = new System.Drawing.Size(55, 55);
            this.uiTurnSwitch1.TabIndex = 48;
            this.uiTurnSwitch1.Text = "uiTurnSwitch1";
            this.uiTurnSwitch1.Click += new System.EventHandler(this.uiTurnSwitch1_Click);
            // 
            // uiTurnSwitch2
            // 
            this.uiTurnSwitch2.ActiveText = "";
            this.uiTurnSwitch2.BackInnerSize = 50;
            this.uiTurnSwitch2.BackSize = 30;
            this.uiTurnSwitch2.FillColor = System.Drawing.Color.LightGray;
            this.uiTurnSwitch2.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTurnSwitch2.InActiveText = "";
            this.uiTurnSwitch2.Location = new System.Drawing.Point(898, 164);
            this.uiTurnSwitch2.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTurnSwitch2.Name = "uiTurnSwitch2";
            this.uiTurnSwitch2.Size = new System.Drawing.Size(55, 55);
            this.uiTurnSwitch2.TabIndex = 49;
            this.uiTurnSwitch2.Text = "uiTurnSwitch2";
            this.uiTurnSwitch2.Click += new System.EventHandler(this.uiTurnSwitch2_Click);
            // 
            // uiTurnSwitch3
            // 
            this.uiTurnSwitch3.ActiveText = "";
            this.uiTurnSwitch3.BackInnerSize = 50;
            this.uiTurnSwitch3.BackSize = 30;
            this.uiTurnSwitch3.FillColor = System.Drawing.Color.LightGray;
            this.uiTurnSwitch3.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTurnSwitch3.InActiveText = "";
            this.uiTurnSwitch3.Location = new System.Drawing.Point(959, 164);
            this.uiTurnSwitch3.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTurnSwitch3.Name = "uiTurnSwitch3";
            this.uiTurnSwitch3.Size = new System.Drawing.Size(55, 55);
            this.uiTurnSwitch3.TabIndex = 50;
            this.uiTurnSwitch3.Text = "uiTurnSwitch3";
            this.uiTurnSwitch3.Click += new System.EventHandler(this.uiTurnSwitch3_Click);
            // 
            // uiTurnSwitch4
            // 
            this.uiTurnSwitch4.ActiveText = "";
            this.uiTurnSwitch4.BackInnerSize = 50;
            this.uiTurnSwitch4.BackSize = 30;
            this.uiTurnSwitch4.FillColor = System.Drawing.Color.LightGray;
            this.uiTurnSwitch4.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.uiTurnSwitch4.InActiveText = "";
            this.uiTurnSwitch4.Location = new System.Drawing.Point(1020, 164);
            this.uiTurnSwitch4.MinimumSize = new System.Drawing.Size(1, 1);
            this.uiTurnSwitch4.Name = "uiTurnSwitch4";
            this.uiTurnSwitch4.Size = new System.Drawing.Size(55, 55);
            this.uiTurnSwitch4.TabIndex = 51;
            this.uiTurnSwitch4.Text = "uiTurnSwitch4";
            this.uiTurnSwitch4.Click += new System.EventHandler(this.uiTurnSwitch4_Click);
            // 
            // label50
            // 
            this.label50.Location = new System.Drawing.Point(838, 141);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(54, 23);
            this.label50.TabIndex = 6;
            this.label50.Text = "开关四";
            this.label50.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label51
            // 
            this.label51.Location = new System.Drawing.Point(898, 141);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(54, 23);
            this.label51.TabIndex = 52;
            this.label51.Text = "开关五";
            this.label51.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label52
            // 
            this.label52.Location = new System.Drawing.Point(960, 140);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(54, 23);
            this.label52.TabIndex = 53;
            this.label52.Text = "开关六";
            this.label52.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label53
            // 
            this.label53.Location = new System.Drawing.Point(1020, 140);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(54, 23);
            this.label53.TabIndex = 54;
            this.label53.Text = "开关七";
            this.label53.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabs5
            // 
            this.tabs5.Controls.Add(this.tabPage5);
            this.tabs5.Cursor = System.Windows.Forms.Cursors.Default;
            this.tabs5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.tabs5.Location = new System.Drawing.Point(838, 225);
            this.tabs5.Name = "tabs5";
            this.tabs5.Pages.Add(this.tabPage5);
            this.tabs5.Size = new System.Drawing.Size(232, 329);
            styleCard15.Border = 0;
            this.tabs5.Style = styleCard15;
            this.tabs5.TabIndex = 1;
            this.tabs5.Text = "tabs5";
            this.tabs5.Type = AntdUI.TabType.Card;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.White;
            this.tabPage5.Controls.Add(this.logListBox);
            this.tabPage5.Location = new System.Drawing.Point(3, 27);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(226, 299);
            this.tabPage5.TabIndex = 0;
            this.tabPage5.Text = "|  运行日志 ";
            // 
            // logListBox
            // 
            this.logListBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.logListBox.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logListBox.FormattingEnabled = true;
            this.logListBox.ItemHeight = 17;
            this.logListBox.Location = new System.Drawing.Point(4, 4);
            this.logListBox.Name = "logListBox";
            this.logListBox.Size = new System.Drawing.Size(219, 289);
            this.logListBox.TabIndex = 0;
            // 
            // SystemOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1083, 566);
            this.Controls.Add(this.tabs5);
            this.Controls.Add(this.label53);
            this.Controls.Add(this.label52);
            this.Controls.Add(this.label51);
            this.Controls.Add(this.label50);
            this.Controls.Add(this.uiTurnSwitch4);
            this.Controls.Add(this.uiTurnSwitch3);
            this.Controls.Add(this.uiTurnSwitch2);
            this.Controls.Add(this.uiPipe10);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.uiPipe6);
            this.Controls.Add(this.uiPipe3);
            this.Controls.Add(this.pictureBox10);
            this.Controls.Add(this.uiPipe5);
            this.Controls.Add(this.uiPipe7);
            this.Controls.Add(this.uiTurnSwitch1);
            this.Controls.Add(this.lbCurrentTraffic1);
            this.Controls.Add(this.label49);
            this.Controls.Add(this.lbInputPressure1);
            this.Controls.Add(this.label47);
            this.Controls.Add(this.lbValveOpening1);
            this.Controls.Add(this.label45);
            this.Controls.Add(this.lbOutputPressure2);
            this.Controls.Add(this.label43);
            this.Controls.Add(this.lbOutputPressure1);
            this.Controls.Add(this.label41);
            this.Controls.Add(this.pictureBox15);
            this.Controls.Add(this.pictureBox14);
            this.Controls.Add(this.pictureBox13);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.lbCurrentTraffic2);
            this.Controls.Add(this.label39);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.lbValveOpening3);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.uiPipe4);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.lbValveOpening2);
            this.Controls.Add(this.label34);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.uiPipe2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.uiPipe1);
            this.Controls.Add(this.tabs4);
            this.Controls.Add(this.tabs3);
            this.Controls.Add(this.tabs2);
            this.Controls.Add(this.tabs1);
            this.Controls.Add(this.uiPipe13);
            this.Controls.Add(this.uiPipe14);
            this.Controls.Add(this.uiPipe12);
            this.Controls.Add(this.uiPipe11);
            this.Controls.Add(this.uiPipe9);
            this.Controls.Add(this.uiPipe8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SystemOverview";
            this.Text = "SystemOverview";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.tabs1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabs2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabs3.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabs4.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox13)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox14)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox15)).EndInit();
            this.tabs5.ResumeLayout(false);
            this.tabPage5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private AntdUI.Tabs tabs1;
        private AntdUI.TabPage tabPage1;
        private AntdUI.Label label1;
        private AntdUI.Label labelRunNum;
        private AntdUI.Label labelErrNum;
        private AntdUI.Label labelStopNum;
        private AntdUI.Label label4;
        private AntdUI.Label label3;
        private AntdUI.Tabs tabs2;
        private AntdUI.TabPage tabPage2;
        private AntdUI.Label label7;
        private Sunny.UI.UIRoundProcess rpMainPipePressure;
        private AntdUI.Label label9;
        private AntdUI.Label label8;
        private AntdUI.Label label11;
        private AntdUI.Label label10;
        private AntdUI.Label label21;
        private AntdUI.Label label16;
        private AntdUI.Label label20;
        private AntdUI.Label label15;
        private AntdUI.Label label19;
        private AntdUI.Label label14;
        private AntdUI.Label label18;
        private AntdUI.Label label13;
        private AntdUI.Label label23;
        private AntdUI.Label label22;
        private Sunny.UI.UIRoundProcess rpMainPipeLeakage;
        private AntdUI.Label label17;
        private Sunny.UI.UIRoundProcess rpMainPipeTraffic;
        private AntdUI.Label label12;
        private AntdUI.Tabs tabs3;
        private AntdUI.TabPage tabPage3;
        private AntdUI.Switch switch3;
        private AntdUI.Switch switch2;
        private AntdUI.Switch switch1;
        private AntdUI.Tabs tabs4;
        private AntdUI.TabPage tabPage4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private AntdUI.Label label26;
        private AntdUI.Label label25;
        private AntdUI.Label label24;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart2;
        private Sunny.UI.UIRoundProcess uiRoundProcess4;
        private AntdUI.Label label29;
        private AntdUI.Label label30;
        private AntdUI.Label label27;
        private AntdUI.Label label28;
        private AntdUI.Label label33;
        private AntdUI.Label label32;
        private AntdUI.Label label31;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private Sunny.UI.UIPipe uiPipe1;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private Sunny.UI.UIPipe uiPipe2;
        private System.Windows.Forms.PictureBox pictureBox6;
        private AntdUI.Label label34;
        private AntdUI.Label lbValveOpening2;
        private System.Windows.Forms.PictureBox pictureBox7;
        private Sunny.UI.UIPipe uiPipe3;
        private Sunny.UI.UIPipe uiPipe4;
        private AntdUI.Label lbValveOpening3;
        private AntdUI.Label label37;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private AntdUI.Label lbCurrentTraffic2;
        private AntdUI.Label label39;
        private Sunny.UI.UIPipe uiPipe5;
        private Sunny.UI.UIPipe uiPipe6;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private Sunny.UI.UIPipe uiPipe7;
        private Sunny.UI.UIPipe uiPipe8;
        private System.Windows.Forms.PictureBox pictureBox12;
        private Sunny.UI.UIPipe uiPipe9;
        private System.Windows.Forms.PictureBox pictureBox13;
        private Sunny.UI.UIPipe uiPipe10;
        private Sunny.UI.UIPipe uiPipe11;
        private Sunny.UI.UIPipe uiPipe12;
        private System.Windows.Forms.PictureBox pictureBox14;
        private System.Windows.Forms.PictureBox pictureBox15;
        private AntdUI.Label lbOutputPressure1;
        private AntdUI.Label label41;
        private AntdUI.Label lbOutputPressure2;
        private AntdUI.Label label43;
        private Sunny.UI.UIPipe uiPipe13;
        private Sunny.UI.UIPipe uiPipe14;
        private AntdUI.Label lbValveOpening1;
        private AntdUI.Label label45;
        private AntdUI.Label lbInputPressure1;
        private AntdUI.Label label47;
        private AntdUI.Label lbCurrentTraffic1;
        private AntdUI.Label label49;
        private Sunny.UI.UITurnSwitch uiTurnSwitch1;
        private Sunny.UI.UITurnSwitch uiTurnSwitch2;
        private Sunny.UI.UITurnSwitch uiTurnSwitch3;
        private Sunny.UI.UITurnSwitch uiTurnSwitch4;
        private AntdUI.Label label50;
        private AntdUI.Label label51;
        private AntdUI.Label label52;
        private AntdUI.Label label53;
        private AntdUI.Tabs tabs5;
        private AntdUI.TabPage tabPage5;
        private System.Windows.Forms.ListBox logListBox;
    }
}