using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HeatChecker
{
    public partial class Settings : Form
    {
        public SettingsModel ReturnedSettings { get; private set; }
        public Settings(SettingsModel CurrentSettings)
        {
            InitializeComponent();

            LoadSettings(CurrentSettings);
        }

        private void LoadSettings(SettingsModel settingsModel)
        {
            chckBtrySleepPc.Checked = settingsModel.SleepWhnChrgLow;
            chckPlySounds.Checked = settingsModel.PlaySounds;
            chckSystemtray.Checked = settingsModel.MinimizeToSystemtray;
            chckAutoStart.Checked = settingsModel.AutoStartup;
            trackbrUpdateInterval.Value = settingsModel.UpdateInterval;
            trckbarBatteryCheckInterval.Value = settingsModel.BatteryCheckInterval;

            var foo = settingsModel.WarmWhen;
            switch (foo)
            {
                case StngChrageStatus.ChargeLow:
                    rdbtnBtryChrgLow.Checked = true;
                    break;
                case StngChrageStatus.NotCharging:
                    rdbtnBtryNotCHarging.Checked = true;
                    break;
                case StngChrageStatus.Disabled:
                    rdbtnBatteryChargeDisabled.Checked = true;
                    break;
                default:
                    break;
            }
        }

        private void rdbtnBatteryChargeDisabled_CheckedChanged(object sender, EventArgs e)
        {
            chckBtrySleepPc.Checked = false;
            chckBtrySleepPc.Enabled = !chckBtrySleepPc.Enabled;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            ReturnedSettings = new SettingsModel
            {
                SleepWhnChrgLow = chckBtrySleepPc.Checked,
                WarmWhen = GetStngChrageStatus(),
                PlaySounds = chckPlySounds.Checked,
                MinimizeToSystemtray = chckSystemtray.Checked,
                AutoStartup = chckAutoStart.Checked,
                UpdateInterval = trackbrUpdateInterval.Value,
                BatteryCheckInterval = trckbarBatteryCheckInterval.Value
            };
        }

        private StngChrageStatus GetStngChrageStatus()
        {
            if (rdbtnBatteryChargeDisabled.Checked)
                return StngChrageStatus.Disabled;
            if (rdbtnBtryChrgLow.Checked)
                return StngChrageStatus.ChargeLow;
            if (rdbtnBtryNotCHarging.Checked)
                return StngChrageStatus.NotCharging;
            return StngChrageStatus.Disabled;
        }

        private void Settings_Load(object sender, EventArgs e)
        {

        }

        private void chckBtrySleepPc_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Settings_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) this.Close();
        }
    }
}
