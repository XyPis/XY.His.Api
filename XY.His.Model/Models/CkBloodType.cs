using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkBloodType
    {
        public CkBloodType()
        {
            this.CkBldApplies = new List<CkBldApply>();
            this.CkBldDonates = new List<CkBldDonate>();
            this.CkBldReimbs = new List<CkBldReimb>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal PriceIn { get; set; }
        public decimal PriceOut { get; set; }
        public short LimitDays { get; set; }
        public int UnitId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<decimal> UnderLineKc { get; set; }
        public virtual ICollection<CkBldApply> CkBldApplies { get; set; }
        public virtual ICollection<CkBldDonate> CkBldDonates { get; set; }
        public virtual ICollection<CkBldReimb> CkBldReimbs { get; set; }
    }
}
