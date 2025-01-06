namespace HeatChecker
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            label1 = new Label();
            label2 = new Label();
            txtCpuLoad = new Label();
            txtCpuTemp = new Label();
            label5 = new Label();
            label6 = new Label();
            trackBar1 = new TrackBar();
            trackBar2 = new TrackBar();
            label3 = new Label();
            txtFanSpeed = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            label12 = new Label();
            groupBox1 = new GroupBox();
            groupBox2 = new GroupBox();
            label14 = new Label();
            label13 = new Label();
            label4 = new Label();
            label15 = new Label();
            lblBatteryStatus = new Label();
            tempProgressBar = new CustomProgressBar();
            notifyIcon = new NotifyIcon(components);
            contextMenuStrip = new ContextMenuStrip(components);
            updateSpeedToolStripMenuItem = new ToolStripMenuItem();
            fastestToolStripMenuItem = new ToolStripMenuItem();
            secToolStripMenuItem = new ToolStripMenuItem();
            secToolStripMenuItem1 = new ToolStripMenuItem();
            secToolStripMenuItem2 = new ToolStripMenuItem();
            secToolStripMenuItem3 = new ToolStripMenuItem();
            secToolStripMenuItem4 = new ToolStripMenuItem();
            secToolStripMenuItem5 = new ToolStripMenuItem();
            secToolStripMenuItem6 = new ToolStripMenuItem();
            updateNowToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator1 = new ToolStripSeparator();
            alwaysOnTopToolStripMenuItem = new ToolStripMenuItem();
            showOnTaskbarToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator3 = new ToolStripSeparator();
            exitToolStripMenuItem = new ToolStripMenuItem();
            restartToolStripMenuItem = new ToolStripMenuItem();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStripMenuItem1 = new ToolStripMenuItem();
            applicationToolStripMenuItem = new ToolStripMenuItem();
            button1 = new Button();
            menuStrip1 = new MenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            settingsToolStripMenuItem = new ToolStripMenuItem();
            batteryCheckTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            contextMenuStrip.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // chart1
            // 
            chart1.BackColor = SystemColors.Control;
            chartArea1.AxisX.MaximumAutoSize = 20F;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine;
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 30);
            chart1.Name = "chart1";
            series1.BorderWidth = 2;
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "CPU Load";
            series1.MarkerBorderWidth = 2;
            series1.Name = "CpuLoad";
            series2.BorderWidth = 2;
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Legend = "Legend1";
            series2.LegendText = "CPU Temperature";
            series2.Name = "CpuTemp";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Size = new Size(800, 155);
            chart1.TabIndex = 1;
            chart1.Text = "THE CHART!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(52, 191);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "CPU Load:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(12, 206);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 2;
            label2.Text = "CPU Temperature:";
            // 
            // txtCpuLoad
            // 
            txtCpuLoad.AutoSize = true;
            txtCpuLoad.Enabled = false;
            txtCpuLoad.Location = new Point(114, 191);
            txtCpuLoad.Name = "txtCpuLoad";
            txtCpuLoad.Size = new Size(28, 15);
            txtCpuLoad.TabIndex = 2;
            txtCpuLoad.Text = "00.0";
            txtCpuLoad.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // txtCpuTemp
            // 
            txtCpuTemp.AutoSize = true;
            txtCpuTemp.Enabled = false;
            txtCpuTemp.Location = new Point(114, 206);
            txtCpuTemp.Name = "txtCpuTemp";
            txtCpuTemp.Size = new Size(28, 15);
            txtCpuTemp.TabIndex = 2;
            txtCpuTemp.Text = "00.0";
            txtCpuTemp.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(138, 206);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 2;
            label5.Text = "℃";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Enabled = false;
            label6.Location = new Point(138, 191);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 2;
            label6.Text = "%";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(114, 37);
            trackBar1.Maximum = 20;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(203, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Value = 2;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(13, 37);
            trackBar2.Maximum = 50;
            trackBar2.Minimum = -70;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(752, 45);
            trackBar2.TabIndex = 3;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Enabled = false;
            label3.Location = new Point(232, 191);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Fan Speed:";
            // 
            // txtFanSpeed
            // 
            txtFanSpeed.AutoSize = true;
            txtFanSpeed.Enabled = false;
            txtFanSpeed.Location = new Point(302, 191);
            txtFanSpeed.Name = "txtFanSpeed";
            txtFanSpeed.Size = new Size(28, 15);
            txtFanSpeed.TabIndex = 2;
            txtFanSpeed.Text = "00.0";
            txtFanSpeed.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Location = new Point(332, 191);
            label7.Name = "label7";
            label7.Size = new Size(32, 15);
            label7.TabIndex = 2;
            label7.Text = "RPM";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.ForeColor = Color.Gray;
            label8.Location = new Point(13, 19);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 2;
            label8.Text = "-70";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.ForeColor = Color.Gray;
            label9.Location = new Point(746, 19);
            label9.Name = "label9";
            label9.Size = new Size(19, 15);
            label9.TabIndex = 2;
            label9.Text = "50";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.ForeColor = Color.Gray;
            label10.Location = new Point(442, 19);
            label10.Name = "label10";
            label10.Size = new Size(13, 15);
            label10.TabIndex = 2;
            label10.Text = "0";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.ForeColor = Color.Gray;
            label11.Location = new Point(600, 19);
            label11.Name = "label11";
            label11.Size = new Size(19, 15);
            label11.TabIndex = 2;
            label11.Text = "25";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.ForeColor = Color.Gray;
            label12.Location = new Point(290, 19);
            label12.Name = "label12";
            label12.Size = new Size(24, 15);
            label12.TabIndex = 2;
            label12.Text = "-25";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(label8);
            groupBox1.Controls.Add(label9);
            groupBox1.Controls.Add(label12);
            groupBox1.Controls.Add(label10);
            groupBox1.Controls.Add(label11);
            groupBox1.Controls.Add(trackBar2);
            groupBox1.Location = new Point(10, 278);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 86);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Temprature Detecting Range";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(trackBar1);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label4);
            groupBox2.Enabled = false;
            groupBox2.Location = new Point(452, 191);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(334, 84);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Settings";
            groupBox2.Visible = false;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(276, 19);
            label14.Name = "label14";
            label14.Size = new Size(46, 15);
            label14.TabIndex = 2;
            label14.Text = "slowest";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(114, 19);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 2;
            label13.Text = "fastest";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 37);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 2;
            label4.Text = "Update interval:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Enabled = false;
            label15.Location = new Point(213, 206);
            label15.Name = "label15";
            label15.Size = new Size(82, 15);
            label15.TabIndex = 2;
            label15.Text = "Battery Status:";
            // 
            // lblBatteryStatus
            // 
            lblBatteryStatus.AutoSize = true;
            lblBatteryStatus.Enabled = false;
            lblBatteryStatus.Location = new Point(302, 206);
            lblBatteryStatus.Name = "lblBatteryStatus";
            lblBatteryStatus.Size = new Size(56, 15);
            lblBatteryStatus.TabIndex = 2;
            lblBatteryStatus.Text = "Charging";
            lblBatteryStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tempProgressBar
            // 
            tempProgressBar.BackColor = Color.DimGray;
            tempProgressBar.ForeColor = Color.Gainsboro;
            tempProgressBar.Location = new Point(370, 191);
            tempProgressBar.Name = "tempProgressBar";
            tempProgressBar.Size = new Size(10, 23);
            tempProgressBar.Style = ProgressBarStyle.Continuous;
            tempProgressBar.TabIndex = 0;
            tempProgressBar.Value = 100;
            tempProgressBar.Visible = false;
            // 
            // notifyIcon
            // 
            notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            notifyIcon.BalloonTipText = "BaloonTip Text";
            notifyIcon.BalloonTipTitle = "BaloonTip Title";
            notifyIcon.Icon = (Icon)resources.GetObject("notifyIcon.Icon");
            notifyIcon.Text = "HeatChecker";
            notifyIcon.Visible = true;
            // 
            // contextMenuStrip
            // 
            contextMenuStrip.Items.AddRange(new ToolStripItem[] { updateSpeedToolStripMenuItem, updateNowToolStripMenuItem, toolStripSeparator1, alwaysOnTopToolStripMenuItem, showOnTaskbarToolStripMenuItem, toolStripSeparator3, exitToolStripMenuItem, restartToolStripMenuItem, toolStripSeparator2, toolStripMenuItem1 });
            contextMenuStrip.Name = "contextMenuStrip";
            contextMenuStrip.OwnerItem = applicationToolStripMenuItem;
            contextMenuStrip.RenderMode = ToolStripRenderMode.Professional;
            contextMenuStrip.Size = new Size(203, 176);
            contextMenuStrip.Text = "Restore";
            // 
            // updateSpeedToolStripMenuItem
            // 
            updateSpeedToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fastestToolStripMenuItem, secToolStripMenuItem, secToolStripMenuItem1, secToolStripMenuItem2, secToolStripMenuItem3, secToolStripMenuItem4, secToolStripMenuItem5, secToolStripMenuItem6 });
            updateSpeedToolStripMenuItem.Enabled = false;
            updateSpeedToolStripMenuItem.Name = "updateSpeedToolStripMenuItem";
            updateSpeedToolStripMenuItem.Size = new Size(202, 22);
            updateSpeedToolStripMenuItem.Text = "Update speed";
            // 
            // fastestToolStripMenuItem
            // 
            fastestToolStripMenuItem.Name = "fastestToolStripMenuItem";
            fastestToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.Shift | Keys.F1;
            fastestToolStripMenuItem.Size = new Size(184, 22);
            fastestToolStripMenuItem.Text = "Fastest";
            // 
            // secToolStripMenuItem
            // 
            secToolStripMenuItem.Name = "secToolStripMenuItem";
            secToolStripMenuItem.Size = new Size(184, 22);
            secToolStripMenuItem.Text = "200 millisecond";
            // 
            // secToolStripMenuItem1
            // 
            secToolStripMenuItem1.Name = "secToolStripMenuItem1";
            secToolStripMenuItem1.Size = new Size(184, 22);
            secToolStripMenuItem1.Text = "500 millisecond";
            secToolStripMenuItem1.Click += secToolStripMenuItem1_Click;
            // 
            // secToolStripMenuItem2
            // 
            secToolStripMenuItem2.Name = "secToolStripMenuItem2";
            secToolStripMenuItem2.ShortcutKeys = Keys.Alt | Keys.Shift | Keys.F2;
            secToolStripMenuItem2.Size = new Size(184, 22);
            secToolStripMenuItem2.Text = "1 sec";
            // 
            // secToolStripMenuItem3
            // 
            secToolStripMenuItem3.Name = "secToolStripMenuItem3";
            secToolStripMenuItem3.Size = new Size(184, 22);
            secToolStripMenuItem3.Text = "2 sec";
            // 
            // secToolStripMenuItem4
            // 
            secToolStripMenuItem4.Name = "secToolStripMenuItem4";
            secToolStripMenuItem4.Size = new Size(184, 22);
            secToolStripMenuItem4.Text = "5 sec";
            // 
            // secToolStripMenuItem5
            // 
            secToolStripMenuItem5.Name = "secToolStripMenuItem5";
            secToolStripMenuItem5.Size = new Size(184, 22);
            secToolStripMenuItem5.Text = "7 sec";
            // 
            // secToolStripMenuItem6
            // 
            secToolStripMenuItem6.Name = "secToolStripMenuItem6";
            secToolStripMenuItem6.ShortcutKeys = Keys.Alt | Keys.Shift | Keys.F3;
            secToolStripMenuItem6.Size = new Size(184, 22);
            secToolStripMenuItem6.Text = "10 sec";
            // 
            // updateNowToolStripMenuItem
            // 
            updateNowToolStripMenuItem.Name = "updateNowToolStripMenuItem";
            updateNowToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.U;
            updateNowToolStripMenuItem.Size = new Size(202, 22);
            updateNowToolStripMenuItem.Text = "Update now";
            updateNowToolStripMenuItem.Click += updateNowToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(199, 6);
            // 
            // alwaysOnTopToolStripMenuItem
            // 
            alwaysOnTopToolStripMenuItem.CheckOnClick = true;
            alwaysOnTopToolStripMenuItem.Name = "alwaysOnTopToolStripMenuItem";
            alwaysOnTopToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.T;
            alwaysOnTopToolStripMenuItem.Size = new Size(202, 22);
            alwaysOnTopToolStripMenuItem.Text = "Always on top";
            alwaysOnTopToolStripMenuItem.Click += alwaysOnTopToolStripMenuItem_Click;
            // 
            // showOnTaskbarToolStripMenuItem
            // 
            showOnTaskbarToolStripMenuItem.CheckOnClick = true;
            showOnTaskbarToolStripMenuItem.Name = "showOnTaskbarToolStripMenuItem";
            showOnTaskbarToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.B;
            showOnTaskbarToolStripMenuItem.Size = new Size(202, 22);
            showOnTaskbarToolStripMenuItem.Text = "Show on taskbar";
            showOnTaskbarToolStripMenuItem.Click += showOnTaskbarToolStripMenuItem_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(199, 6);
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.ShortcutKeys = Keys.Alt | Keys.F4;
            exitToolStripMenuItem.Size = new Size(202, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // restartToolStripMenuItem
            // 
            restartToolStripMenuItem.Name = "restartToolStripMenuItem";
            restartToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.R;
            restartToolStripMenuItem.Size = new Size(202, 22);
            restartToolStripMenuItem.Text = "Restart";
            restartToolStripMenuItem.Click += restartToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(199, 6);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(202, 22);
            toolStripMenuItem1.Text = "About us";
            // 
            // applicationToolStripMenuItem
            // 
            applicationToolStripMenuItem.DropDown = contextMenuStrip;
            applicationToolStripMenuItem.Name = "applicationToolStripMenuItem";
            applicationToolStripMenuItem.Size = new Size(80, 20);
            applicationToolStripMenuItem.Text = "Application";
            // 
            // button1
            // 
            button1.Location = new Point(23, 238);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Settings";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { applicationToolStripMenuItem, editToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 7;
            menuStrip1.Text = "menuStrip1";
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { settingsToolStripMenuItem });
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(39, 20);
            editToolStripMenuItem.Text = "Edit";
            // 
            // settingsToolStripMenuItem
            // 
            settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            settingsToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            settingsToolStripMenuItem.Size = new Size(156, 22);
            settingsToolStripMenuItem.Text = "Settings";
            settingsToolStripMenuItem.Click += settingsToolStripMenuItem_Click;
            // 
            // batteryCheckTimer
            // 
            batteryCheckTimer.Enabled = true;
            batteryCheckTimer.Interval = 1;
            batteryCheckTimer.Tick += batteryCheckTimer_Tick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 368);
            Controls.Add(menuStrip1);
            Controls.Add(button1);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txtCpuTemp);
            Controls.Add(label6);
            Controls.Add(lblBatteryStatus);
            Controls.Add(txtFanSpeed);
            Controls.Add(txtCpuLoad);
            Controls.Add(label7);
            Controls.Add(label15);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(chart1);
            Controls.Add(tempProgressBar);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MainMenuStrip = menuStrip1;
            MaximizeBox = false;
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "HC - 404";
            Load += Form1_Load;
            KeyDown += Form1_KeyDown;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            contextMenuStrip.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private Label label1;
        private Label label2;
        private Label txtCpuLoad;
        private Label txtCpuTemp;
        private Label label5;
        private Label label6;
        private TrackBar trackBar1;
        private TrackBar trackBar2;
        private Label label3;
        private Label txtFanSpeed;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private Label label11;
        private Label label12;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private Label label14;
        private Label label13;
        private Label label4;
        private Label label15;
        private Label lblBatteryStatus;
        private CustomProgressBar tempProgressBar;
        private NotifyIcon notifyIcon;
        private ContextMenuStrip contextMenuStrip;
        private Button button1;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem applicationToolStripMenuItem;
        private ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.Timer batteryCheckTimer;
        private ToolStripMenuItem alwaysOnTopToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private ToolStripMenuItem restartToolStripMenuItem;
        private ToolStripMenuItem updateSpeedToolStripMenuItem;
        private ToolStripMenuItem fastestToolStripMenuItem;
        private ToolStripMenuItem secToolStripMenuItem;
        private ToolStripMenuItem secToolStripMenuItem1;
        private ToolStripMenuItem secToolStripMenuItem2;
        private ToolStripMenuItem secToolStripMenuItem3;
        private ToolStripMenuItem secToolStripMenuItem4;
        private ToolStripMenuItem secToolStripMenuItem5;
        private ToolStripMenuItem secToolStripMenuItem6;
        private ToolStripMenuItem updateNowToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem showOnTaskbarToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator3;
    }
}
