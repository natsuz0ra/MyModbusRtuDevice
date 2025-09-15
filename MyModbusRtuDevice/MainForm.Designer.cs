using MyModbusRtuDevice.Forms;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace MyModbusRtuDevice
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnConnect = new AntdUI.Button();
            this.btnAdmin = new AntdUI.Button();
            this.btnClose = new AntdUI.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.connectStatusLabel = new AntdUI.Label();
            this.buttonSystemConfig = new AntdUI.Button();
            this.buttonStatusAlarm = new AntdUI.Button();
            this.buttonDataTrack = new AntdUI.Button();
            this.buttonSystemOverview = new AntdUI.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.connectStatusLabel2 = new AntdUI.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.statusPanel = new System.Windows.Forms.Panel();
            this.viewPanel = new System.Windows.Forms.Panel();
            this.timeUpdater = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(5, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "上位机监控系统";
            // 
            // panelTop
            // 
            this.panelTop.Controls.Add(this.panel2);
            this.panelTop.Controls.Add(this.label1);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1083, 40);
            this.panelTop.TabIndex = 1;
            this.panelTop.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseDown);
            this.panelTop.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseMove);
            this.panelTop.MouseUp += new System.Windows.Forms.MouseEventHandler(this.panelTop_MouseUp);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnConnect);
            this.panel2.Controls.Add(this.btnAdmin);
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(810, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(273, 40);
            this.panel2.TabIndex = 2;
            // 
            // btnConnect
            // 
            this.btnConnect.BackColor = System.Drawing.Color.Transparent;
            this.btnConnect.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnConnect.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnConnect.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(175)))), ((int)(((byte)(80)))));
            this.btnConnect.Ghost = true;
            this.btnConnect.IconRatio = 1.5F;
            this.btnConnect.IconSize = new System.Drawing.Size(20, 20);
            this.btnConnect.IconSvg = "ApiOutlined";
            this.btnConnect.Location = new System.Drawing.Point(0, 0);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Radius = 15;
            this.btnConnect.Shape = AntdUI.TShape.Round;
            this.btnConnect.Size = new System.Drawing.Size(91, 40);
            this.btnConnect.TabIndex = 5;
            this.btnConnect.Text = "连接";
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // btnAdmin
            // 
            this.btnAdmin.BackColor = System.Drawing.Color.Transparent;
            this.btnAdmin.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnAdmin.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnAdmin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.btnAdmin.Ghost = true;
            this.btnAdmin.IconRatio = 1.5F;
            this.btnAdmin.IconSize = new System.Drawing.Size(20, 20);
            this.btnAdmin.IconSvg = "UserOutlined";
            this.btnAdmin.Location = new System.Drawing.Point(91, 0);
            this.btnAdmin.Name = "btnAdmin";
            this.btnAdmin.Radius = 15;
            this.btnAdmin.Shape = AntdUI.TShape.Round;
            this.btnAdmin.Size = new System.Drawing.Size(91, 40);
            this.btnAdmin.TabIndex = 4;
            this.btnAdmin.Text = "Admin";
            // 
            // btnClose
            // 
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(244)))), ((int)(((byte)(67)))), ((int)(((byte)(54)))));
            this.btnClose.Ghost = true;
            this.btnClose.IconRatio = 1.5F;
            this.btnClose.IconSize = new System.Drawing.Size(20, 20);
            this.btnClose.IconSvg = "PoweroffOutlined";
            this.btnClose.Location = new System.Drawing.Point(182, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Radius = 15;
            this.btnClose.Shape = AntdUI.TShape.Round;
            this.btnClose.Size = new System.Drawing.Size(91, 40);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "关闭";
            this.btnClose.Click += new System.EventHandler(this.close_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.connectStatusLabel);
            this.panel3.Controls.Add(this.buttonSystemConfig);
            this.panel3.Controls.Add(this.buttonStatusAlarm);
            this.panel3.Controls.Add(this.buttonDataTrack);
            this.panel3.Controls.Add(this.buttonSystemOverview);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1083, 40);
            this.panel3.TabIndex = 2;
            // 
            // connectStatusLabel
            // 
            this.connectStatusLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.connectStatusLabel.ForeColor = System.Drawing.Color.Blue;
            this.connectStatusLabel.Location = new System.Drawing.Point(906, 6);
            this.connectStatusLabel.Name = "connectStatusLabel";
            this.connectStatusLabel.Size = new System.Drawing.Size(165, 28);
            this.connectStatusLabel.TabIndex = 9;
            this.connectStatusLabel.Text = "等待通信连接...";
            this.connectStatusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonSystemConfig
            // 
            this.buttonSystemConfig.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSystemConfig.ForeColor = System.Drawing.Color.DimGray;
            this.buttonSystemConfig.Location = new System.Drawing.Point(282, 0);
            this.buttonSystemConfig.Name = "buttonSystemConfig";
            this.buttonSystemConfig.Size = new System.Drawing.Size(85, 40);
            this.buttonSystemConfig.TabIndex = 8;
            this.buttonSystemConfig.Text = "系统配置";
            this.buttonSystemConfig.Click += new System.EventHandler(this.SelectButtonEvent);
            // 
            // buttonStatusAlarm
            // 
            this.buttonStatusAlarm.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.buttonStatusAlarm.ForeColor = System.Drawing.Color.DimGray;
            this.buttonStatusAlarm.Location = new System.Drawing.Point(191, 0);
            this.buttonStatusAlarm.Name = "buttonStatusAlarm";
            this.buttonStatusAlarm.Size = new System.Drawing.Size(85, 40);
            this.buttonStatusAlarm.TabIndex = 7;
            this.buttonStatusAlarm.Text = "状态预警";
            this.buttonStatusAlarm.Click += new System.EventHandler(this.SelectButtonEvent);
            // 
            // buttonDataTrack
            // 
            this.buttonDataTrack.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.buttonDataTrack.ForeColor = System.Drawing.Color.DimGray;
            this.buttonDataTrack.Location = new System.Drawing.Point(100, 0);
            this.buttonDataTrack.Name = "buttonDataTrack";
            this.buttonDataTrack.Size = new System.Drawing.Size(85, 40);
            this.buttonDataTrack.TabIndex = 6;
            this.buttonDataTrack.Text = "数据跟踪";
            this.buttonDataTrack.Click += new System.EventHandler(this.SelectButtonEvent);
            // 
            // buttonSystemOverview
            // 
            this.buttonSystemOverview.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold);
            this.buttonSystemOverview.ForeColor = System.Drawing.Color.DimGray;
            this.buttonSystemOverview.Location = new System.Drawing.Point(9, 0);
            this.buttonSystemOverview.Name = "buttonSystemOverview";
            this.buttonSystemOverview.Size = new System.Drawing.Size(85, 40);
            this.buttonSystemOverview.TabIndex = 5;
            this.buttonSystemOverview.Text = "系统概况";
            this.buttonSystemOverview.Click += new System.EventHandler(this.SelectButtonEvent);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.panel4.Controls.Add(this.connectStatusLabel2);
            this.panel4.Controls.Add(this.timeLabel);
            this.panel4.Controls.Add(this.statusPanel);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 646);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1083, 25);
            this.panel4.TabIndex = 3;
            // 
            // connectStatusLabel2
            // 
            this.connectStatusLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.connectStatusLabel2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.connectStatusLabel2.Location = new System.Drawing.Point(22, 2);
            this.connectStatusLabel2.Name = "connectStatusLabel2";
            this.connectStatusLabel2.Size = new System.Drawing.Size(927, 21);
            this.connectStatusLabel2.TabIndex = 3;
            this.connectStatusLabel2.Text = "未连接";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.timeLabel.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.timeLabel.Location = new System.Drawing.Point(955, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Padding = new System.Windows.Forms.Padding(0, 4, 2, 0);
            this.timeLabel.Size = new System.Drawing.Size(128, 21);
            this.timeLabel.TabIndex = 2;
            this.timeLabel.Text = "2025-08-03 21:23:22";
            // 
            // statusPanel
            // 
            this.statusPanel.BackColor = System.Drawing.Color.Yellow;
            this.statusPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.statusPanel.Location = new System.Drawing.Point(6, 8);
            this.statusPanel.Name = "statusPanel";
            this.statusPanel.Size = new System.Drawing.Size(10, 10);
            this.statusPanel.TabIndex = 1;
            // 
            // viewPanel
            // 
            this.viewPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewPanel.Location = new System.Drawing.Point(0, 80);
            this.viewPanel.Name = "viewPanel";
            this.viewPanel.Size = new System.Drawing.Size(1083, 566);
            this.viewPanel.TabIndex = 4;
            // 
            // timeUpdater
            // 
            this.timeUpdater.Enabled = true;
            this.timeUpdater.Interval = 1000;
            this.timeUpdater.Tick += new System.EventHandler(this.timeUpdater_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(244)))), ((int)(((byte)(248)))));
            this.ClientSize = new System.Drawing.Size(1083, 671);
            this.Controls.Add(this.viewPanel);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panelTop);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panelTop;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;

        private Panel panel4;
        private Panel statusPanel;
        private Label timeLabel;
        private Panel viewPanel;
        private Timer timeUpdater;
        private AntdUI.Button buttonDataTrack;
        private AntdUI.Button buttonSystemOverview;
        private AntdUI.Button buttonSystemConfig;
        private AntdUI.Button buttonStatusAlarm;
        private AntdUI.Button btnClose;
        private AntdUI.Button btnAdmin;
        private AntdUI.Button btnConnect;
        private AntdUI.Label connectStatusLabel;
        private AntdUI.Label connectStatusLabel2;
    }
}