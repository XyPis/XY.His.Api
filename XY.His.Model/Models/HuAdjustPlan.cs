using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuAdjustPlan
    {
        public HuAdjustPlan()
        {
            this.HuAdjustPlanDtls = new List<HuAdjustPlanDtl>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public System.DateTime NotifyDate { get; set; }
        public string DispUnit { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsHouse BsHouse { get; set; }
        public virtual ICollection<HuAdjustPlanDtl> HuAdjustPlanDtls { get; set; }
    }
}
