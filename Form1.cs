using LibreHardwareMonitor.Hardware;
using LibreHardwareMonitor.Hardware.Cpu;
using System.Threading;
using System.Windows.Forms.DataVisualization.Charting;
using LOHM = LibreHardwareMonitor.Hardware;

namespace HeatChecker
{
    public partial class Form1 : Form
    {
        private LOHM.Computer _computer;
        private System.Windows.Forms.Timer _timer;
        //private Chart chart1;

        private static string SfxDir = Application.StartupPath + @"SFX\";
        private static string SfxBruh = SfxDir + "bruh.wav";
        private static string SfxVine = SfxDir + "vine.wav";
        private static string SfxExit = SfxDir + "exit.wav";
        private static string SfxPull = SfxDir + "pull.wav";

        private static string SfxAlarmS = SfxDir + @"alarms\alarm - slow.wav";
        private static string SfxAlarmM = SfxDir + @"alarms\alarm - medium.wav";
        private static string SfxAlarmF = SfxDir + @"alarms\alarm - fast.wav";
        private static string SfxAlarmC = SfxDir + @"alarms\alarm - critical.wav";

        System.Media.SoundPlayer sound1 = new System.Media.SoundPlayer(SfxAlarmC);
        System.Media.SoundPlayer sound2 = new System.Media.SoundPlayer(SfxAlarmS);
        System.Media.SoundPlayer sound3 = new System.Media.SoundPlayer(SfxAlarmF);

        System.Media.SoundPlayer lowBatterySound = new System.Media.SoundPlayer(SfxPull);

        private int M_GLOBAL_INT = 0;
        private int M_INCRES_INT = 0;

        bool isPlayingBatterySound = false;
        int batterySoundCounter = 0;

        bool PlaySounds = true;

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
            PlaySfx(SfxVine);

            var _cancellationTokenSource = new CancellationTokenSource();
            Task.Run(() => MonitorBatteryStatus(_cancellationTokenSource.Token));
        }

        private void PlaySfx(string SfxPath)
        {
            if (PlaySounds)
                new System.Media.SoundPlayer(SfxPath).Play();
        }

        private void InitializeHardwareMonitor()
        {
            // Create a new instance of the Computer class from LibreHardwareMonitorLib
            _computer = new LOHM.Computer()
            {
                IsCpuEnabled = true,
                IsMemoryEnabled = true,
                IsControllerEnabled = true,
                IsMotherboardEnabled = true,
                IsBatteryEnabled = true,
                IsGpuEnabled = true,
                IsNetworkEnabled = true,
                IsStorageEnabled = true,
                IsPsuEnabled = true,
            };

            // Start hardware monitoring
            _computer.Open();
        }

        private void InitializeChart()
        {
            /* Create and configure the Chart
            chart1 = new Chart
            {
                Dock = DockStyle.Top,
                Height = 300
            };
            this.Controls.Add(chart1);
            

            ChartArea chartArea = new ChartArea();
            chart1.ChartAreas.Add(chartArea);

            // Add series for Temperature, CPU Load, and Fan Speed
            chart1.Series.Add("CpuTemp");
            chart1.Series.Add("CpuLoad");
            chart1.Series.Add("FanSpeed");
            */
            chart1.ChartAreas[0].AxisX.IsStartedFromZero = true;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;   // Remove extra margins for smooth scrolling

            chart1.Series["CpuTemp"].ChartType = SeriesChartType.Line;
            chart1.Series["CpuLoad"].ChartType = SeriesChartType.Spline;
            chart1.Series["FanSpeed"].ChartType = SeriesChartType.Spline;

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
            float cpuTempUI = 0;
            foreach (var hardwareItem in _computer.Hardware)
            {
                if (hardwareItem.HardwareType == HardwareType.Cpu)
                {
                    // Monitor temperature
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Temperature && sensor.Name == "Core Average")
                        {
                            if (M_GLOBAL_INT == 1)
                            {
                                chart1.Series["CpuTemp"].Points.AddXY(0, 100);

                            }
                            float temp = sensor.Value.GetValueOrDefault() + M_INCRES_INT;
                            cpuTempUI = sensor.Value.GetValueOrDefault();
                            if (temp < 0)
                                tempProgressBar.Value = 0;
                            else if (temp > 100)
                                tempProgressBar.Value = 100;
                            else
                                tempProgressBar.Value = (int)temp; // Update progress bar

                            chart1.Series["CpuTemp"].Points.AddXY(M_GLOBAL_INT, temp); // Update chart
                            if (chart1.Series["CpuTemp"].Points.Count > 100)
                            {
                                chart1.Series["CpuTemp"].Points.Clear();
                                M_GLOBAL_INT = 0;
                            }

                            txtCpuTemp.Text = cpuTempUI.ToString();

                            ScrollChartLeft("CpuTemp");

                            var category = CategoryBasedOnHeat(temp);
                            if (M_GLOBAL_INT != 0)// M_GLOBAL_INT is only zero at the first time the program starts and first data extracted!
                            {
                                HandleCpuTemprature(category);
                                continue;
                            }
                            txtCpuTemp.Enabled = false;
                        }
                    }

                    // Monitor CPU load
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Load && sensor.Name == "CPU Total")
                        {
                            chart1.Series["CpuLoad"].Points.AddXY(M_GLOBAL_INT, sensor.Value.GetValueOrDefault() > 100 ? 100 : sensor.Value);
                            if (chart1.Series["CpuLoad"].Points.Count > 100)
                            {
                                chart1.Series["CpuLoad"].Points.Clear();
                                M_GLOBAL_INT = 0;
                            }
                            txtCpuLoad.Text = sensor.Value.ToString();
                            ScrollChartLeft("CpuLoad");
                        }
                    }
                    /*
                    // Monitor fan speed
                    foreach (var sensor in hardwareItem.Sensors)
                    {
                        if (sensor.SensorType == SensorType.Fan)
                        {
                            chart1.Series["FanSpeed"].Points.AddXY(M_GLOBAL_INT, sensor.Value.GetValueOrDefault());
                            if (chart1.Series["FanSpeed"].Points.Count > 100)
                                chart1.Series["FanSpeed"].Points.RemoveAt(0);
                        }
                    }
                    */
                    hardwareItem.Update();
                    M_GLOBAL_INT++;
                }
            }



        }

        private async Task MonitorBatteryStatus(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                PowerStatus pwr = System.Windows.Forms.SystemInformation.PowerStatus;

                bool isCharging = pwr.PowerLineStatus == PowerLineStatus.Online ? true : false;

                var chargeStatus = pwr.BatteryChargeStatus;

                string chrgl = chargeStatus.ToString().ToLower();

                if (!isCharging || (chrgl.Contains("low") && !isCharging))
                {
                    HandleLowBattery();
                }
            }
        }

        private void HandleLowBattery()
        {
                lowBatterySound.PlaySync();
        }

        private void ScrollChartLeft(string seriesName)
        {
            var series = chart1.Series[seriesName];
            // Ensure X-axis range scrolls dynamically
            const int visiblePoints = 35; // Adjust this to your desired range
            if (series.Points.Count > visiblePoints)
            {
                // Keep updating the X-axis range
                chart1.ChartAreas[0].AxisX.Minimum = series.Points.Count - visiblePoints;
                chart1.ChartAreas[0].AxisX.Maximum = series.Points.Count;
            }
            else
            {
                // Set initial range for fewer points
                chart1.ChartAreas[0].AxisX.Minimum = 0;
                chart1.ChartAreas[0].AxisX.Maximum = visiblePoints;
            }
        }

        private void HandleCpuTemprature(HeatCategory category)
        {
            txtCpuTemp.Enabled = true;

            switch (category)
            {
                case HeatCategory.none:
                    txtCpuTemp.Text = "??.?";
                    txtCpuTemp.Enabled = false;
                    StopSounds();
                    break;
                case HeatCategory.Freezing:
                    txtCpuTemp.ForeColor = Color.DeepSkyBlue;
                    sound1.Play();
                    break;
                case HeatCategory.Normal:
                    StopSounds();
                    txtCpuTemp.Enabled = false;
                    break;
                case HeatCategory.Warm:
                    txtCpuTemp.Enabled = false;
                    StopSounds();
                    break;
                case HeatCategory.Hot:
                    txtCpuTemp.ForeColor = Color.Red;
                    sound2.Play();
                    break;
                case HeatCategory.Critical:
                    txtCpuTemp.ForeColor = Color.DarkRed;
                    sound3.Play();
                    break;
                default:
                    txtCpuTemp.Enabled = false;
                    StopSounds();
                    break;
            }
        }

        private void StopSounds()
        {
            sound1.Stop();
            sound2.Stop();
            sound3.Stop();
        }

        private HeatCategory CategoryBasedOnHeat(float? heat)
        {
            if (heat <= 0.0f)
                return HeatCategory.Freezing;
            if (heat <= 60)
                return HeatCategory.Normal;
            if (heat <= 80)
                return HeatCategory.Warm;
            if (heat <= 90)
                return HeatCategory.Hot;
            if (heat > 90)
                return HeatCategory.Critical;
            return HeatCategory.none;
        }

        protected override void OnFormClosed(FormClosedEventArgs e)
        {
            PlaySfx(SfxExit);
            _computer.Close();
            base.OnFormClosed(e);
        }

        private void InitializeCustomProgressBar()
        {
            /*
            tempProgressBar = new CustomProgressBar
            {
                Maximum = 100, // Set maximum temperature (Celsius)
                //Location = new System.Drawing.Point(10, 350),
                //Size = new System.Drawing.Size(300, 30)
            };
            this.Controls.Add(tempProgressBar);
            */
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            M_INCRES_INT = trackBar2.Value;
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            _timer.Interval = trackBar1.Value * 500 + 1;
        }
    }
}

enum HeatCategory
{
    none,
    Freezing,
    Normal,
    Warm,
    Hot,
    Critical
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
