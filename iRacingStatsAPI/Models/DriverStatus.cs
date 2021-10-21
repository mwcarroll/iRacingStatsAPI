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
        public int LL { get; set; }
        public int HP { get; set; }
        public int HT { get; set; }
        public string C1 { get; set; }
        public string C2 { get; set; }
        public string C3 { get; set; }
        public int FT { get; set; }
    }

    public class SearchRacer
    {
        public Broadcast Broadcast { get; set; }
        public bool DriverChanges { get; set; }
        public long LastLogin { get; set; }
        public int MaxUsers { get; set; }
        public int TrackId { get; set; }
        public string SessionStatus { get; set; }
        public int SessionTypeId { get; set; }
        public PrivateSession PrivateSession { get; set; }
        public int SeriesId { get; set; }
        public bool RegOpen { get; set; }
        public int CatId { get; set; }
        public int EventTypeId { get; set; }
        public int SpotterAccess { get; set; }
        public long LastSeen { get; set; }
        public int SeasonId { get; set; }
        public Helmet Helmet { get; set; }
        public int PrivateSessionId { get; set; }
        public int CustId { get; set; }
        public string Name { get; set; }
        public bool TrustedAsSpotter { get; set; }
        public int StartTime { get; set; }
        public int UserRole { get; set; }
        public string SubSessionStatus { get; set; }
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
