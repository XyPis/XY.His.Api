using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class NrPregnancy
    {
        public NrPregnancy()
        {
            this.NrPregnancyDtls = new List<NrPregnancyDtl>();
        }

        public int ID { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public System.DateTime ExpectDate { get; set; }
        public short PregnantWeek { get; set; }
        public Nullable<short> PregnancyTime { get; set; }
        public Nullable<short> DeliveryTimes { get; set; }
        public Nullable<System.DateTime> UterusShrink { get; set; }
        public Nullable<System.DateTime> UterusOpen { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual ICollection<NrPregnancyDtl> NrPregnancyDtls { get; set; }
    }
}
