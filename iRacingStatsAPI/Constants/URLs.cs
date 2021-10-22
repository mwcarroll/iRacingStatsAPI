namespace iRacingStatsAPI.Constants
{
    public class URLs
    {
        // base URLS for endpoints
        public const string MEMBER_SITE = "https://members.iracing.com/membersite/member";
        public const string MEMBER_STATS = "https://members.iracing.com/memberstats/member";

        // iRacing service URLs
        public const string LOGIN = "https://members.iracing.com/membersite/Login";
        public const string LOGOUT = "https://members.iracing.com/membersite/Logout";

        // Main endpoints
        public const string DRIVER_STATS = MEMBER_STATS + "/GetDriverStats";
        public const string SUBSESSION_RESULTS = MEMBER_SITE + "/GetSubsessionResults";
        public const string CURRENT_SESASONS = MEMBER_SITE + "/GetSeasons";
        public const string SEASON_STANDINGS = MEMBER_STATS + "/GetSeasonStandings";

        // Recent historical endpoints
        public const string LASTRACE_STATS = MEMBER_STATS + "/GetLastRacesStats";
        public const string LAST_SERIES = MEMBER_STATS + "/GetLastSeries";
        public const string RESULTS = MEMBER_STATS + "/GetResults";
        public const string WORLD_RECORDS = MEMBER_STATS + "/GetWorldRecords";

        // Upcoming session endpoints
        public const string SESSION_TIMES = MEMBER_SITE + "/GetSessionTimes";
        public const string NEXT_EVENT = MEMBER_SITE + "/GetNextEvent";
        public const string TOTALREGISTERED = MEMBER_SITE + "/GetTotalSessionJoinedCountsBySeason";
        public const string RACEGUIDE = MEMBER_SITE + "/GetRaceGuide";
        public const string ACTIVEOP_COUNT = MEMBER_SITE + "/GetActiveOpenPracticeCount";

        // Driver profile endpoints
        public const string DRIVER_STATUS = MEMBER_SITE + "/GetDriverStatus";
        public const string MEMBER_DIVISION = MEMBER_SITE + "/GetMembersDivision";
        public const string STATS_CHART = MEMBER_STATS + "/GetChartData";
        public const string CAREER_STATS = MEMBER_STATS + "/GetCareerStats";
        public const string YEARLY_STATS = MEMBER_STATS + "/GetYearlyStats";
        public const string PERSONAL_BESTS = MEMBER_STATS + "/GetPersonalBests";

        // Race specific endpoints
        public const string LAPS_SINGLE = MEMBER_SITE + "/GetLaps";
        public const string LAPS_ALL = MEMBER_SITE + "/GetLapChart";

        // Utility endpoints
        public const string MEM_SUBSESSID = MEMBER_SITE + "/GetSubsessionForMember";
        public const string CARS_DRIVEN = MEMBER_STATS + "/GetCarsDriven";
        public const string PRIVATE_RESULTS = MEMBER_STATS + "/GetPrivateSessionResults";
        public const string CAR_CLASS = MEMBER_SITE + "/GetCarClassById";
        public const string TICKER_SESSIONS = MEMBER_SITE + "/GetTickerSessions";
        public const string SEASON_FOR_SESSION = MEMBER_SITE + "/GetSeasonForSession";
        public const string ALL_SUBSESSIONS = MEMBER_SITE + "/GetAllSubsessions";
    }
}
