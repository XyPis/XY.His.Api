using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class ElTip
    {
        public ElTip()
        {
            this.ElTipsPats = new List<ElTipsPat>();
        }

        public int ID { get; set; }
        public Nullable<int> PatMenuId { get; set; }
        public string WhereFormat { get; set; }
        public string Arg1 { get; set; }
        public string Arg2 { get; set; }
        public string Arg3 { get; set; }
        public string Arg4 { get; set; }
        public string Arg5 { get; set; }
        public string Tips { get; set; }
        public Nullable<bool> IsFollow { get; set; }
        public Nullable<short> ActiveDays { get; set; }
        public string RoleIds { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual GblPatientMenu GblPatientMenu { get; set; }
        public virtual ICollection<ElTipsPat> ElTipsPats { get; set; }
    }
}
