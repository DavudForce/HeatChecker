using LibreHardwareMonitor.Hardware;
using LibreHardwareMonitor.Hardware.Cpu;
using System.Diagnostics;
using System.IO.Pipes;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using LOHM = LibreHardwareMonitor.Hardware;

namespace HeatChecker
{
    public partial class Form1 : Form
    {
        [DllImport("PowrProf.dll", CharSet = CharSet.Auto, ExactSpelling = true)]
        public static extern bool SetSuspendState(bool hiberate, bool forceCritical, bool disableWakeEvent);

        SettingsModel settingsM = new SettingsModel();

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
            CheckIfAlreadyRunning();
            InitializeComponent();
            InitializeChart();
            InitializeTimer();
            InitializeHardwareMonitor();
            InitializeCustomProgressBar();
            InitializeSystemTray();
        }

        private bool CheckIfAlreadyRunning()
        {
            int indexer = 0;
            var processes = Process.GetProcessesByName("HeatChecker");

            if (processes.Length > 1)
            {
                var promp = MessageBox.Show("An instance of this application already running.\n\n" +
                    "Do you want to kill other process and start a new one?", "Already running", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                
                if (promp == DialogResult.Yes)
                {
                    this.WindowState = FormWindowState.Normal;
                    this.BringToFront();
                    this.Activate();
                    this.Focus();

                    foreach (var process in processes)
                    {
                        if(indexer != processes.Length - 1)// means if it's the last turn (so we won't kill the main app's process)
                            process.Kill();
                        indexer++;
                    }
                }

                else foreach (var process in processes)
                    {
                        process.Kill(); // kill all processes. including this one.
                    }

            }
            return false;
        }

        private void InitializeSystemTray()
        {
            if (settingsM.MinimizeToSystemtray)
            {
                // Set up the NotifyIcon
                string appPth = Application.StartupPath;
                notifyIcon.Icon = new System.Drawing.Icon($"{appPth}/Resources/sysnoc.sys");
                notifyIcon.Text = $"HeatChecker ({Application.ProductVersion})";
                notifyIcon.Visible = true;

                // Handle NotifyIcon events
                notifyIcon.DoubleClick += NotifyIcon_DoubleClick;

                // Add a ContextMenuStrip
                ContextMenuStrip contextMenu = new ContextMenuStrip();
                contextMenu.Items.Add("Restore", null, Restore_Click);
                contextMenu.Items.Add("Exit", null, Exit_Click);
                notifyIcon.ContextMenuStrip = contextMenu;
            }
        }

        #region System Tray stuff

        private void NotifyIcon_DoubleClick(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            ShowForm();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            notifyIcon.Visible = false;
            Application.Exit();
        }

        private void ShowForm()
        {
            this.Show();
            this.WindowState = FormWindowState.Normal;
            this.BringToFront();
        }

        protected override void OnResize(EventArgs e)
        {
            if (settingsM.MinimizeToSystemtray)
            {
                base.OnResize(e);
                if (this.WindowState == FormWindowState.Minimized)
                {
                    this.Hide();
                }
            }
        }

        #endregion

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadSettings();
            PlaySfx(SfxVine);
        }

        private void PlaySfx(string SfxPath)
        {
            if (PlaySounds && settingsM.PlaySounds)
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
            chart1.ChartAreas[0].AxisX.IsStartedFromZero = true;
            chart1.ChartAreas[0].AxisX.IsMarginVisible = false;   // Remove extra margins for smooth scrolling

            chart1.Series["CpuTemp"].ChartType = SeriesChartType.Line;
            chart1.Series["CpuLoad"].ChartType = SeriesChartType.Spline;

            chart1.ChartAreas[0].AxisX.Title = "Time";
            chart1.ChartAreas[0].AxisY.Title = "Value";
        }

        private void InitializeTimer()
        {
            // Timer to update the data every second
            _timer = new System.Windows.Forms.Timer
            {
                Interval = settingsM.UpdateInterval >= 0 ? 1000 : settingsM.UpdateInterval // 1 second
            };
            _timer.Tick += Timer_Tick;
            _timer.Start();

            batteryCheckTimer.Interval = settingsM.BatteryCheckInterval >= 0 ? 1000 : settingsM.UpdateInterval;

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
                            if (chart1.Series["CpuLoad"].Points.Count >= 100)
                            {
                                chart1.Series["CpuLoad"].Points.Clear();
                                M_GLOBAL_INT = 0;
                            }
                            txtCpuLoad.Text = sensor.Value.ToString();
                            ScrollChartLeft("CpuLoad");
                        }
                    }
                    hardwareItem.Update();
                    M_GLOBAL_INT++;
                }
            }
        }

        private readonly object soundLock = new(); // Ensures thread safety for sound playback.

        private bool IsSoundPlaying()
        {
            lock (soundLock)
            {
                if (isPlayingBatterySound) return true;
                isPlayingBatterySound = true;
                return false;
            }
        }

        private void SetSoundPlaying(bool state)
        {
            lock (soundLock)
            {
                isPlayingBatterySound = state;
            }
        }

        private async Task AnimateLabelAsync(Label label)
        {
            Color originalBackColor = label.BackColor;
            Color originalForeColor = label.ForeColor;

            for (int i = 0; i < 4; i++) // Blink 4 times
            {
                label.BackColor = Color.Red;
                label.ForeColor = Color.White;
                await Task.Delay(1000); // Wait asynchronously

                label.BackColor = originalBackColor;
                label.ForeColor = Color.Red;
                await Task.Delay(1000); // Wait asynchronously
            }

            label.BackColor = originalBackColor; // Restore original colors
            label.ForeColor = originalForeColor;
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
                    if (settingsM.PlaySounds) sound1.Play();
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
                    if (settingsM.PlaySounds) sound2.Play();
                    break;
                case HeatCategory.Critical:
                    txtCpuTemp.ForeColor = Color.DarkRed;
                    if (settingsM.PlaySounds) sound3.Play();
                    break;
                default:
                    txtCpuTemp.Enabled = false;
                    StopSounds();
                    break;
            }
        }

        private void ApplySettings()
        {
            _timer.Interval = settingsM.UpdateInterval * 500 + 1;
            batteryCheckTimer.Interval = settingsM.BatteryCheckInterval * 500 + 1;

            if (settingsM.WarmWhen == StngChrageStatus.Disabled) lblBatteryStatus.ForeColor = Color.BlueViolet; else lblBatteryStatus.Enabled = false;
            if (settingsM.MinimizeToSystemtray) InitializeSystemTray();
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
            if (settingsM.PlaySounds) PlaySfx(SfxExit);
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

        private void button1_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(settingsM); // the form!
            settings.ShowDialog();
            settingsM = settings.ReturnedSettings;
            ApplySettings();
            SaveSettings();
        }

        private void LoadSettings()
        {
            settingsM = DataManager.ReadSettings(Application.StartupPath + @"\data\meta.data", true);
            ApplySettings();
        }

        private void SaveSettings()
        {
            DataManager.WriteSettings(Application.StartupPath + @"\data\meta.data", settingsM, true);
        }

        private void batteryCheckTimer_Tick(object sender, EventArgs e)
        {
            if (settingsM.WarmWhen != StngChrageStatus.Disabled)
            {
                PowerStatus pwr = System.Windows.Forms.SystemInformation.PowerStatus;

                bool isCharging = pwr.PowerLineStatus == PowerLineStatus.Online ? true : false;

                var chargeStatus = pwr.BatteryChargeStatus;

                string chrgl = chargeStatus.ToString().ToLower();

                if (!isCharging || (chrgl.Contains("low") && !isCharging))
                {
                    if (settingsM.SleepWhnChrgLow) { SleepPc(); return; }
                    lblBatteryStatus.Text = "Not Charging";
                    HandleLowBattery();
                }

                lblBatteryStatus.Text = "Charging";
            }
        }
        private void SleepPc()
        {
            SetSuspendState(false, true, true);
        }

        private async void HandleLowBattery()
        {
            if (settingsM.PlaySounds && !IsSoundPlaying())
            {
                await Task.Run(() =>
                {
                    try
                    {
                        lowBatterySound.PlaySync(); // Play the sound.
                    }
                    catch (Exception ex)
                    {
                        // Handle or log the exception.
                        Console.WriteLine($"Error playing low battery sound: {ex.Message}");
                    }
                    finally
                    {
                        SetSoundPlaying(false); // Reset the flag.
                    }
                });
            }

            await AnimateLabelAsync(lblBatteryStatus);
        }

        #region ToolStrip items
        private void secToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void updateNowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Timer_Tick(this, e);
            batteryCheckTimer_Tick(this, e);
        }

        private void alwaysOnTopToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.TopMost = !this.TopMost;
        }

        private void restartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Restart();
            Environment.Exit(0);
        }


        #endregion

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings(settingsM); // the form!
            settings.ShowDialog();
            settingsM = settings.ReturnedSettings;
            ApplySettings();
            SaveSettings();
        }

        private void showOnTaskbarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.ShowInTaskbar = !this.ShowInTaskbar;
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                this.WindowState = FormWindowState.Minimized;

            // prevent child controls from handling this event as well
            e.SuppressKeyPress = true;

            return;
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
