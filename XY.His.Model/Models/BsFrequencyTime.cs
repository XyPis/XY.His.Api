using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsFrequencyTime
    {
        public int ID { get; set; }
        public int FrequencyId { get; set; }
        public string ExecTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsFrequency BsFrequency { get; set; }
    }
}
