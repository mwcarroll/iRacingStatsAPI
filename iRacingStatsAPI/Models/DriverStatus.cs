using System.Collections.Generic;

namespace iRacingStatsAPI.Models
{
    public class Broadcast
    {
    }

    public class PrivateSession
    {
    }

    public class Helmet
    {
        public string c3 { get; set; }
        public int ll { get; set; }
        public int hp { get; set; }
        public int ht { get; set; }
        public string c1 { get; set; }
        public int ft { get; set; }
        public string c2 { get; set; }
    }

    public class SearchRacer
    {
        public Broadcast broadcast { get; set; }
        public bool driverChanges { get; set; }
        public long lastLogin { get; set; }
        public int maxUsers { get; set; }
        public int trackId { get; set; }
        public string sessionStatus { get; set; }
        public int sessionTypeId { get; set; }
        public PrivateSession privateSession { get; set; }
        public int seriesId { get; set; }
        public bool regOpen { get; set; }
        public int catId { get; set; }
        public int eventTypeId { get; set; }
        public int spotterAccess { get; set; }
        public long lastSeen { get; set; }
        public int seasonId { get; set; }
        public Helmet helmet { get; set; }
        public int privateSessionId { get; set; }
        public int custid { get; set; }
        public string name { get; set; }
        public bool trustedAsSpotter { get; set; }
        public int startTime { get; set; }
        public int userRole { get; set; }
        public string subSessionStatus { get; set; }
    }

    public class DriverStatus
    {
        public bool blacklisted { get; set; }
        public int search { get; set; }
        public bool studied { get; set; }
        public List<object> fsRacers { get; set; }
        public bool friends { get; set; }
        public List<SearchRacer> searchRacers { get; set; }
    }


}
