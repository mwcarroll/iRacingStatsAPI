using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace iRacingStats.Core.Models.Leagues
{
    public class League
    {
        [JsonPropertyName("1")]
        public string LeagueName { get; set; } = string.Empty;

        [JsonPropertyName("3")]
        public long Created { get; set; }

        [JsonPropertyName("4")]
        public string About { get; set; } = string.Empty;

        [JsonPropertyName("5")]
        public int Pattern { get; set; }

        [JsonPropertyName("6")]
        public int Admin { get; set; }

        [JsonPropertyName("7")]
        public int PendingApplciation { get; set; }

        [JsonPropertyName("8")]
        public int LicenceLevel { get; set; }

        [JsonPropertyName("9")]
        public string Url { get; set; } = string.Empty;

        [JsonPropertyName("10")]
        public string Color3 { get; set; } = string.Empty;

        [JsonPropertyName("11")]
        public int Relevance { get; set; }

        [JsonPropertyName("12")]
        public string Color1 { get; set; } = string.Empty;

        [JsonPropertyName("13")]
        public string Color2 { get; set; } = string.Empty;

        [JsonPropertyName("14")]
        public int LeagueId { get; set; }

        [JsonPropertyName("15")]
        public string SortingName { get; set; } = string.Empty;

        [JsonPropertyName("16")]
        public int Recruiting { get; set; }

        [JsonPropertyName("17")]
        public string DisplayName { get; set; } = string.Empty;

        [JsonPropertyName("18")]
        public int PendingInvitation { get; set; }

        [JsonPropertyName("19")]
        public int Member { get; set; }

        [JsonPropertyName("20")]
        public int CustId { get; set; } 

        [JsonPropertyName("21")]
        public int RN { get; set; }

        [JsonPropertyName("22")]
        public int RosterCount { get; set; }

    }
}
