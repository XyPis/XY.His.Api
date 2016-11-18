using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DgDayGroup
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<short> Days { get; set; }
    }
}
