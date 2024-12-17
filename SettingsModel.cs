namespace HeatChecker
{
    public enum StngChrageStatus
    {
        ChargeLow,
        NotCharging,
        Disabled
    }
    public class SettingsModel
    {
        #region battery
        public bool SleepWhnChrgLow { get; set; }
        public StngChrageStatus WarmWhen { get; set; }
        #endregion
        #region sounds
        public bool PlaySounds { get; set; }
        #endregion
        #region stuff
        public bool MinimizeToSystemtray { get; set; }
        public bool AutoStartup { get; set; }

        public int UpdateInterval { get; set; }
        #endregion
    }
}
