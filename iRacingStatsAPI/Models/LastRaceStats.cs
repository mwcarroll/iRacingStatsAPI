namespace iRacingStatsAPI.Models
{
    public class LastRaceStats
    {
        public string Date { get; set; }
        public string WinnerName { get; set; }
        public int QualifyTime { get; set; }
        public int TrackID { get; set; }
        public int LicenseLevel { get; set; }
        public int Laps { get; set; }
        public string TrackName { get; set; }
        public int SOF { get; set; }
        public int CarID { get; set; }
        public string CarColor1 { get; set; }
        public string CarColor2 { get; set; }
        public string CarColor3 { get; set; }
        public int WinnerID { get; set; }
        public string QualifyTimeFormatted { get; set; }
        public int Incidents { get; set; }
        public int ClubPoints { get; set; }
        public int SubsessionID { get; set; }
        public int ChampPoints { get; set; }
        public string WinnerHC1 { get; set; }
        public string WinnerHC3 { get; set; }
        public string WinnerHC2 { get; set; }
        public int CarClassID { get; set; }
        public int SeriesID { get; set; }
        public int WinnerHPattern { get; set; }
        public int StartPos { get; set; }
        public int CarPattern { get; set; }
        public int WinnerLL { get; set; }
        public int SeasonID { get; set; }
        public int LapsLed { get; set; }
        public object Time { get; set; }
        public int FinishPos { get; set; }
    }
}
