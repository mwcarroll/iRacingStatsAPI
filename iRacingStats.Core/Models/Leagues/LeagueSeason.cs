using System.Text.Json.Serialization;

namespace iRacingStats.Core.Models.Leagues
{
    public class LeagueSeason
    {
        [JsonPropertyName("1")]
        public int LeagueSeasonId { get; set; } 

        [JsonPropertyName("2")]
        public string LeaguePointsSystemName { get; set; } = string.Empty;

        [JsonPropertyName("3")]
        public int Hidden { get; set; } 

        [JsonPropertyName("5")]
        public int LeaguePointsSystemId { get; set; }

        [JsonPropertyName("6")]
        public int Actice { get; set; }

        [JsonPropertyName("7")]
        public int UseLmt { get; set; }

        [JsonPropertyName("8")]
        public string LeagueSeasonName { get; set; } = string.Empty;

        [JsonPropertyName("9")]
        public int NumDrops { get; set; }

        //[JsonPropertyName("10")]
        //public LeagueRace NextRace { get; set; } = new LeagueRace();

        [JsonPropertyName("11")]
        public int LeagueId { get; set; } 

        [JsonPropertyName("12")]
        public int RN { get; set; }

        //[JsonPropertyName("13")]
        //public LeagueRace PreviousRace { get; set; } = new LeagueRace();

        [JsonPropertyName("14")]
        public string LeaguePointSystemDesc { get; set; } = string.Empty;

        [JsonPropertyName("15")]
        public string NoDropsOnOrAfterRaceNum { get; set; } = string.Empty;
    }
}
