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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            tempProgressBar = new CustomProgressBar();
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
            chckPlaySfx = new CheckBox();
            label14 = new Label();
            label13 = new Label();
            label4 = new Label();
            label15 = new Label();
            lblBatteryStatus = new Label();
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // tempProgressBar
            // 
            tempProgressBar.BackColor = Color.DimGray;
            tempProgressBar.ForeColor = Color.Gainsboro;
            tempProgressBar.Location = new Point(0, 136);
            tempProgressBar.Name = "tempProgressBar";
            tempProgressBar.Size = new Size(800, 23);
            tempProgressBar.Style = ProgressBarStyle.Continuous;
            tempProgressBar.TabIndex = 0;
            tempProgressBar.Value = 100;
            // 
            // chart1
            // 
            chartArea1.AxisX.MaximumAutoSize = 20F;
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            legend1.TitleSeparator = System.Windows.Forms.DataVisualization.Charting.LegendSeparatorStyle.ThickLine;
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 1);
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
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.LegendText = "Fan Speed";
            series3.Name = "FanSpeed";
            chart1.Series.Add(series1);
            chart1.Series.Add(series2);
            chart1.Series.Add(series3);
            chart1.Size = new Size(800, 129);
            chart1.TabIndex = 1;
            chart1.Text = "THE CHART!";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Enabled = false;
            label1.Location = new Point(52, 162);
            label1.Name = "label1";
            label1.Size = new Size(62, 15);
            label1.TabIndex = 2;
            label1.Text = "CPU Load:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(12, 177);
            label2.Name = "label2";
            label2.Size = new Size(102, 15);
            label2.TabIndex = 2;
            label2.Text = "CPU Temperature:";
            // 
            // txtCpuLoad
            // 
            txtCpuLoad.AutoSize = true;
            txtCpuLoad.Enabled = false;
            txtCpuLoad.Location = new Point(114, 162);
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
            txtCpuTemp.Location = new Point(114, 177);
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
            label5.Location = new Point(138, 177);
            label5.Name = "label5";
            label5.Size = new Size(19, 15);
            label5.TabIndex = 2;
            label5.Text = "℃";
            label5.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            label6.Enabled = false;
            label6.Location = new Point(138, 162);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 2;
            label6.Text = "%";
            label6.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(562, 33);
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
            label3.Location = new Point(232, 162);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 2;
            label3.Text = "Fan Speed:";
            // 
            // txtFanSpeed
            // 
            txtFanSpeed.AutoSize = true;
            txtFanSpeed.Enabled = false;
            txtFanSpeed.Location = new Point(302, 162);
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
            label7.Location = new Point(332, 162);
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
            groupBox1.Location = new Point(10, 285);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(776, 86);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Temprature Detecting Range";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(chckPlaySfx);
            groupBox2.Controls.Add(trackBar1);
            groupBox2.Controls.Add(label14);
            groupBox2.Controls.Add(label13);
            groupBox2.Controls.Add(label4);
            groupBox2.Location = new Point(10, 195);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(776, 84);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Basic Settings";
            // 
            // chckPlaySfx
            // 
            chckPlaySfx.AutoSize = true;
            chckPlaySfx.Location = new Point(13, 22);
            chckPlaySfx.Name = "chckPlaySfx";
            chckPlaySfx.Size = new Size(70, 19);
            chckPlaySfx.TabIndex = 4;
            chckPlaySfx.Text = "Play SFX";
            chckPlaySfx.UseVisualStyleBackColor = true;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.ForeColor = Color.Gray;
            label14.Location = new Point(724, 15);
            label14.Name = "label14";
            label14.Size = new Size(46, 15);
            label14.TabIndex = 2;
            label14.Text = "slowest";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.ForeColor = Color.Gray;
            label13.Location = new Point(562, 15);
            label13.Name = "label13";
            label13.Size = new Size(41, 15);
            label13.TabIndex = 2;
            label13.Text = "fastest";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(454, 33);
            label4.Name = "label4";
            label4.Size = new Size(90, 15);
            label4.TabIndex = 2;
            label4.Text = "Update interval:";
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Enabled = false;
            label15.Location = new Point(213, 177);
            label15.Name = "label15";
            label15.Size = new Size(82, 15);
            label15.TabIndex = 2;
            label15.Text = "Battery Status:";
            // 
            // lblBatteryStatus
            // 
            lblBatteryStatus.AutoSize = true;
            lblBatteryStatus.Enabled = false;
            lblBatteryStatus.Location = new Point(302, 177);
            lblBatteryStatus.Name = "lblBatteryStatus";
            lblBatteryStatus.Size = new Size(56, 15);
            lblBatteryStatus.TabIndex = 2;
            lblBatteryStatus.Text = "Charging";
            lblBatteryStatus.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
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
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CustomProgressBar tempProgressBar;
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
        private CheckBox chckPlaySfx;
        private Label label14;
        private Label label13;
        private Label label4;
        private Label label15;
        private Label lblBatteryStatus;
    }
}
