using System;
using System.Collections;
using System.Collections.Generic;

namespace iRacingStatsAPI.Models
{
    public class iRacingModelData<T>
    {
        public object m { get; set; }
        public List<T> d { get; set; }
    }
}
