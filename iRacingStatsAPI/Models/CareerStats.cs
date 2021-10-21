namespace iRacingStatsAPI.Models
{
    public class CareerStats
    {
        public int Wins { get; set; }
        public int TotalClubPoints { get; set; }
        public double WinPerc { get; set; }
        public int Poles { get; set; }
        public int AvgStart { get; set; }
        public int AvgFinish { get; set; }
        public double Top5Perc { get; set; }
        public int TotalLaps { get; set; }
        public double AvgIncPerRace { get; set; }
        public int AvgPtsPerRace { get; set; }
        public int LapsLed { get; set; }
        public int Top5 { get; set; }
        public double LapsLedPerc { get; set; }
        public Enums.RaceCategory Category { get; set; }
        public int Starts { get; set; }
    }
}
