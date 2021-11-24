using System;
using System.Collections;
using System.Collections.Generic;

namespace iRacingStats.Core.Models
{
    public class iRacingModelData<T>
    {
        public object m { get; set; }
        public List<T> d { get; set; }
    }
}
