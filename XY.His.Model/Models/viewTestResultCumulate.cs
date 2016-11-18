using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class viewTestResultCumulate
    {
        public string ShortName { get; set; }
        public Nullable<short> LsGroup { get; set; }
        public Nullable<int> LabId { get; set; }
        public System.DateTime OperTime { get; set; }
        public string Result { get; set; }
        public string Unit { get; set; }
        public int TestId { get; set; }
        public int PatId { get; set; }
    }
}
