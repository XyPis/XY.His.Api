using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InEmrScore
    {
        public int ID { get; set; }
        public Nullable<int> EMRQCITEMID { get; set; }
        public Nullable<int> HOSPID { get; set; }
        public string EMRITEMSCORE { get; set; }
        public string EMRSCORE { get; set; }
        public Nullable<bool> ISSCORE { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string PARTSCORE { get; set; }
    }
}
