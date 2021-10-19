namespace iRacingStatsAPI.Constants
{
    public class URLs
    {
        public const string LOGIN = "https://members.iracing.com/membersite/login.jsp";
        public const string LOGIN2 = "https://members.iracing.com/membersite/Login";
        public const string HOME = "http://members.iracing.com/membersite/member/Home.do";
        public const string CHART = "http://members.iracing.com/memberstats/member/GetChartData?custId={0}&catId={1}&chartType=1";
        public const string DRIVER_COUNTS = "http://members.iracing.com/membersite/member/GetDriverCounts";
        public const string CAREER_STATS = "http://members.iracing.com/memberstats/member/GetCareerStats?custid={0}";
        public const string YEARLY_STATS = "http://members.iracing.com/memberstats/member/GetYearlyStats?custid={0}";
        public const string CARS_DRIVEN = "http://members.iracing.com/memberstats/member/GetCarsDriven?custid={0}";
        public const string PERSONAL_BEST = "http://members.iracing.com/memberstats/member/GetPersonalBests?carid={0}&custid={1}";
        public const string DRIVER_STATUS = "http://members.iracing.com/membersite/member/GetDriverStatus?{0}";
        public const string DRIVER_STATS = "http://members.iracing.com/memberstats/member/GetDriverStats";
        public const string LAST_RACE_STATS = "http://members.iracing.com/memberstats/member/GetLastRacesStats?custid={0}";
        public const string RESULTS_ARCHIVE = "http://members.iracing.com/memberstats/member/GetResults";
        public const string SEASON_STANDINGS = "http://members.iracing.com/memberstats/member/GetSeasonStandings";
        public const string SEASON_STANDINGS2 = "http://members.iracing.com/membersite/member/statsseries.jsp";
        public const string HOSTED_RESULTS = "http://members.iracing.com/memberstats/member/GetPrivateSessionResults";
        public const string SELECT_SERIES = "http://members.iracing.com/membersite/member/SelectSeries.do?&season={0}&view=undefined&nocache={1}";
        public const string SESSION_TIMES = "http://members.iracing.com/membersite/member/GetSessionTimes";
        public const string SERIES_RACE_RESULTS = "http://members.iracing.com/memberstats/member/GetSeriesRaceResults";
        public const string GET_EVENT_RESULTS = "http://members.iracing.com/membersite/member/GetEventResultsAsCSV?subsessionid={0}&simsesnum={1}&includeSummary=1";

    }
}
