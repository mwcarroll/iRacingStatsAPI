using System;
using System.Collections;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace iRacingStats.Core.Models
{
    public class iRacingModelData<T>
    {
        public object m { get; set; }
        public List<T> d { get; set; }
    }

    public class iRacingModelRowData<T>
    {
        public object m { get; set; }
        public RowData<T> d { get; set; }
    }

    public class RowData<T>
    {
        [JsonPropertyName("2")]
        public int RowCount { get; set; }
        [JsonPropertyName("r")]
        public List<T> Rows { get; set; }
    }
    public class RowDataActual<T>
    {
        [JsonPropertyName("rowcount")]
        public int RowCount { get; set; }
        [JsonPropertyName("rows")]
        public List<T> Rows { get; set; }
    }
}
