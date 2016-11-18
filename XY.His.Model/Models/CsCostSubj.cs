using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsCostSubj
    {
        public CsCostSubj()
        {
            this.CsBigConsumes = new List<CsBigConsume>();
            this.CsCostClassRelas = new List<CsCostClassRela>();
            this.CsCostDetails = new List<CsCostDetail>();
            this.CsDeptCosts = new List<CsDeptCost>();
            this.CsDeptCostParas = new List<CsDeptCostPara>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string SuppItemCode { get; set; }
        public Nullable<short> LsTreatMed { get; set; }
        public Nullable<bool> IsLastLevel { get; set; }
        public Nullable<int> CostSubjGrade { get; set; }
        public string PyCode { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<bool> IsFix { get; set; }
        public Nullable<short> LsType { get; set; }
        public Nullable<int> ClassId { get; set; }
        public string WbCode { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public Nullable<bool> IsDerect { get; set; }
        public Nullable<short> LsAppPara { get; set; }
        public string ToLocIds { get; set; }
        public virtual ICollection<CsBigConsume> CsBigConsumes { get; set; }
        public virtual CsCostClass CsCostClass { get; set; }
        public virtual ICollection<CsCostClassRela> CsCostClassRelas { get; set; }
        public virtual ICollection<CsCostDetail> CsCostDetails { get; set; }
        public virtual ICollection<CsDeptCost> CsDeptCosts { get; set; }
        public virtual ICollection<CsDeptCostPara> CsDeptCostParas { get; set; }
    }
}
