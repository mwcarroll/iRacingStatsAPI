using System.Collections.Generic;
using System.ComponentModel;
using System.Text.Json.Serialization;

namespace iRacingStatsAPI.Models
{
    public class OpenPractice
    {
        [JsonPropertyName("1")]
        public int WeatherTempUnits { get; set; }
        [JsonPropertyName("2")]
        public int WeatherWindDirection { get; set; }
        [JsonPropertyName("3")]
        public int WeatherTempValue { get; set; }
        [JsonPropertyName("4")]
        public int MinTeamDrivers { get; set; }
        [JsonPropertyName("5")]
        public int SessionId { get; set; }
        [JsonPropertyName("6")]
        public string Pits { get; set; }
        [JsonPropertyName("7")]
        public int DriverChangeParam1 { get; set; }
        [JsonPropertyName("8")]
        public int DriverChangeParam2 { get; set; }
        [JsonPropertyName("9")]
        public string DriversRegistered { get; set; }
        [JsonPropertyName("10")]
        public string AllowEntry { get; set; }
        [JsonPropertyName("11")]
        public string SeriesName { get; set; }
        [JsonPropertyName("12")]
        public object RubberLevelPractice { get; set; }
        [JsonPropertyName("13")]
        public int WeatherFogDensity { get; set; }
        [JsonPropertyName("14")]
        public string RubberLevelWarmup { get; set; }
        [JsonPropertyName("15")]
        public string RubberLevelRace { get; set; }
        [JsonPropertyName("16")]
        public string RacePanelImg { get; set; }
        [JsonPropertyName("17")]
        public int SeriesId { get; set; }
        [JsonPropertyName("18")]
        public int TimeOfDay { get; set; }
        [JsonPropertyName("19")]
        public string SimulatedStartTime { get; set; }
        [JsonPropertyName("20")]
        public int TotalGroups { get; set; }
        [JsonPropertyName("21")]
        public int SeasonId { get; set; }
        [JsonPropertyName("22")]
        public string GripCompoundPractice { get; set; }
        [JsonPropertyName("23")]
        public string GripCompoundWarmup { get; set; }
        [JsonPropertyName("24")]
        public int TrackId { get; set; }
        [JsonPropertyName("25")]
        public string CarsLeft { get; set; }
        [JsonPropertyName("26")]
        public string GripCompoundRace { get; set; }
        [JsonPropertyName("27")]
        public int WeatherType { get; set; }
        [JsonPropertyName("28")]
        public string FarmId { get; set; }
        [JsonPropertyName("29")]
        public int WeatherSkies { get; set; }
        [JsonPropertyName("30")]
        public int CatId { get; set; }
        [JsonPropertyName("31")]
        public int DriverChangeRule { get; set; }
        [JsonPropertyName("32")]
        public int WeatehrVarOngoing { get; set; }
        [JsonPropertyName("33")]
        public int GroupCount { get; set; }
        [JsonPropertyName("34")]
        public int SubsessionId { get; set; }
        [JsonPropertyName("35")]
        public int EarthRotationSpeedup { get; set; }
        [JsonPropertyName("36")]
        public int LeaveMarbles { get; set; }
        [JsonPropertyName("37")]
        public string TrackName { get; set; }
        [JsonPropertyName("38")]
        public int PitsInUse { get; set; }
        [JsonPropertyName("39")]
        public string GripCompoundQualify { get; set; }
        [JsonPropertyName("40")]
        public int TotalCount { get; set; }
        [JsonPropertyName("41")]
        public string TrackConfigName { get; set; }
        [JsonPropertyName("42")]
        public int WeatherRh { get; set; }
        [JsonPropertyName("43")]
        public string RubberLevelQualify { get; set; }
        [JsonPropertyName("44")]
        public int WeatherVarInitial { get; set; }
        [JsonPropertyName("45")]
        public string SeriesAbbrv { get; set; }
        [JsonPropertyName("46")]
        public string DriversConnected { get; set; }
        [JsonPropertyName("47")]
        public int MaxTeamDrivers { get; set; }
        [JsonPropertyName("48")]
        public int WeatherWindSpeedValue { get; set; }
        [JsonPropertyName("49")]
        public string RegisteredCount { get; set; }
        [JsonPropertyName("50")]
        public string Time { get; set; }
        [JsonPropertyName("51")]
        public int DriverChanges { get; set; }
        [JsonPropertyName("52")]
        public int PitsTotal { get; set; }
        [JsonPropertyName("53")]
        public int WeatherWindSpeedUnits { get; set; }
    }
}
