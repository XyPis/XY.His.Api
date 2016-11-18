using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsOP
    {
        public BsOP()
        {
            this.InHosOps = new List<InHosOp>();
            this.NfInfects = new List<NfInfect>();
            this.OpsApplies = new List<OpsApply>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<short> LsClass { get; set; }
        public Nullable<short> LsASA { get; set; }
        public Nullable<bool> IsEmergency { get; set; }
        public Nullable<int> AnaesId { get; set; }
        public Nullable<int> Minutes { get; set; }
        public Nullable<bool> IsImplant { get; set; }
        public Nullable<bool> IsImglass { get; set; }
        public Nullable<bool> IsOPSDrug { get; set; }
        public Nullable<decimal> DangerPoint { get; set; }
        public virtual BsAnae BsAnae { get; set; }
        public virtual ICollection<InHosOp> InHosOps { get; set; }
        public virtual ICollection<NfInfect> NfInfects { get; set; }
        public virtual ICollection<OpsApply> OpsApplies { get; set; }
    }
}
