using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsParaDeptsRec
    {
        public int ID { get; set; }
        public string YearMonth { get; set; }
        public Nullable<int> LocId { get; set; }
        public Nullable<short> LsAppPara { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsLocation BsLocation { get; set; }
    }
}
