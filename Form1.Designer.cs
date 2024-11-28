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
            ((System.ComponentModel.ISupportInitialize)chart1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).BeginInit();
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
            chartArea1.Name = "ChartArea1";
            chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            chart1.Legends.Add(legend1);
            chart1.Location = new Point(0, 1);
            chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series1.Legend = "Legend1";
            series1.LegendText = "CPU Load";
            series1.Name = "CpuLoad";
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
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
            trackBar1.Location = new Point(585, 165);
            trackBar1.Maximum = 20;
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(203, 45);
            trackBar1.TabIndex = 3;
            trackBar1.Value = 2;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // trackBar2
            // 
            trackBar2.Location = new Point(12, 195);
            trackBar2.Maximum = 50;
            trackBar2.Minimum = -70;
            trackBar2.Name = "trackBar2";
            trackBar2.Size = new Size(776, 45);
            trackBar2.TabIndex = 3;
            trackBar2.Scroll += trackBar2_Scroll;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(trackBar2);
            Controls.Add(trackBar1);
            Controls.Add(label2);
            Controls.Add(label5);
            Controls.Add(txtCpuTemp);
            Controls.Add(label6);
            Controls.Add(txtCpuLoad);
            Controls.Add(label1);
            Controls.Add(chart1);
            Controls.Add(tempProgressBar);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)chart1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar2).EndInit();
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
    }
}
