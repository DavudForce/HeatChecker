using LibreHardwareMonitor.Hardware;
using System.Windows.Forms.DataVisualization.Charting;
using LOHM = LibreHardwareMonitor.Hardware;

namespace HeatChecker
{
    public partial class Form1 : Form
    {
        private LOHM.Computer _computer;
        private System.Windows.Forms.Timer _timer;
        private CustomProgressBar tempProgressBar;
        private Chart chart1;

        public Form1()
        {
            InitializeComponent();
            InitializeChart();
            InitializeTimer();
            InitializeHardwareMonitor();
            InitializeCustomProgressBar();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void InitializeHardwareMonitor()
        {
            // Create a new instance of the Computer class from LibreHardwareMonitorLib
            _computer = new LOHM.Computer()
            {
                IsCpuEnabled = true,
                IsMemoryEnabled = true,
                IsControllerEnabled = true
            };

            // Start hardware monitoring
            _computer.Open();
        }

        private void InitializeChart()
        {
            // Create and configure the Chart
            chart1 = new Chart
            {
                Dock = DockStyle.Top,
                Height = 300
            };
            this.Controls.Add(chart1);

            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Add series for Temperature, CPU Load, and Fan Speed
            chart1.Series.Add("Temperature");
            chart1.Series.Add("CPU Load");
            chart1.Series.Add("Fan Speed");

            chart1.Series["Temperature"].ChartType = SeriesChartType.Line;
            chart1.Series["CPU Load"].ChartType = SeriesChartType.Line;
            chart1.Series["Fan Speed"].ChartType = SeriesChartType.Line;

            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.ChartAreas[0].AxisY.Title = "Value";
        }

        private void InitializeTimer()
        {
            // Timer to update the data every second
            _timer = new System.Windows.Forms.Timer
            {
                Interval = 1000 // 1 second
            };
            _timer.Tick += Timer_Tick;
            _timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            foreach (var hardwareItem in _computer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.Cpu)
                {
                    hardwareItem.Update();

                    // Monitor temperature
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature)
                        {
                            float temp = sensor.Value.GetValueOrDefault();
                            tempProgressBar.Value = (int)temp; // Update progress bar
                            chart1.Series["Temperature"].Points.AddY(temp); // Update chart
                            if (chart1.Series["Temperature"].Points.Count > 100)
                                chart1.Series["Temperature"].Points.RemoveAt(0);
                        }
                    }

                    // Monitor CPU load
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load)
                        {
                            chart1.Series["CPU Load"].Points.AddY(sensor.Value.GetValueOrDefault());
                            if (chart1.Series["CPU Load"].Points.Count > 100)
                                chart1.Series["CPU Load"].Points.RemoveAt(0);
                        }
                    }

                    // Monitor fan speed
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Fan)
                        {
                            chart1.Series["Fan Speed"].Points.AddY(sensor.Value.GetValueOrDefault());
                            if (chart1.Series["Fan Speed"].Points.Count > 100)
                                chart1.Series["Fan Speed"].Points.RemoveAt(0);
                        }
                    }
                }
            }
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            _computer.Close();
            base.OnFormClosed(e);
        }

        private void InitializeCustomProgressBar()
        {
            tempProgressBar = new CustomProgressBar
            {
                Maximum = 100, // Set maximum temperature (Celsius)
                Location = new System.Drawing.Point(10, 350),
                Size = new System.Drawing.Size(300, 30)
            };
            this.Controls.Add(tempProgressBar);
        }
    }
}

public class CustomProgressBar : Control
{
    private int _value;

    public int Value
    {
        get { return _value; }
        set
        {
            if (value >= 0 && value <= Maximum)
            {
                _value = value;
                Invalidate();
            }
        }
    }

    public int Maximum { get; set; }

    protected override void OnPaint(PaintEventArgs e)
    {
        base.OnPaint(e);

        // Draw background
        e.Graphics.FillRectangle(new SolidBrush(System.Drawing.Color.DarkGray), this.ClientRectangle);

        // Draw foreground (progress)
        float percentage = (float)_value / Maximum;
        e.Graphics.FillRectangle(new SolidBrush(System.Drawing.Color.DeepSkyBlue), 0, 0, this.Width * percentage, this.Height);
    }
}
