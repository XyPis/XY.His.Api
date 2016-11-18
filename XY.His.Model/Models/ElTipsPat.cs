using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class ElTipsPat
    {
        public int ID { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<int> TipId { get; set; }
        public string Tips { get; set; }
        public Nullable<int> PatFormId { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<short> ActiveDays { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsHospital BsHospital { get; set; }
        public virtual ElTip ElTip { get; set; }
    }
}
