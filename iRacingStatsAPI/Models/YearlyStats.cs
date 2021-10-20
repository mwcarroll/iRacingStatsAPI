namespace iRacingStatsAPI.Models
{
    public class YearlyStats
    {
        public int wins { get; set; }
        public double winPerc { get; set; }
        public string year { get; set; }
        public int poles { get; set; }
        public int clubpoints { get; set; }
        public int avgStart { get; set; }
        public int avgFinish { get; set; }
        public double top5Perc { get; set; }
        public int totalLaps { get; set; }
        public double avgIncPerRace { get; set; }
        public int avgPtsPerRace { get; set; }
        public int lapsLed { get; set; }
        public int top5 { get; set; }
        public double lapsLedPerc { get; set; }
        public Enums.RaceCategory category { get; set; }
        public int starts { get; set; }
    }
}
