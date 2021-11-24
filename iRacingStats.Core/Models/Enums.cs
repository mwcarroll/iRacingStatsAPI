using System.ComponentModel;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;

namespace iRacingStats.Core.Models
{
    public class Enums
    {
        [JsonConverter(typeof(JsonStringEnumMemberConverter))]
        public enum RaceCategory
        {
            [EnumMember(Value = "oval")]
            [Description("Oval")]
            OVAL,
            [EnumMember(Value = "road")]
            [Description("Road")]
            ROAD,
            [EnumMember(Value = "dirt+oval")]
            [Description("Dirt Oval")]
            DIRT_OVAL,
            [EnumMember(Value = "dirt+road")]
            [Description("Dirt Road")]
            DIRT_ROAD
        }
    }
}
