using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuCheck
    {
        public HuCheck()
        {
            this.HuCheckSums = new List<HuCheckSum>();
            this.HuCheckDtls = new List<HuCheckDtl>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public decimal CheckAmount { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsHouse BsHouse { get; set; }
        public virtual ICollection<HuCheckSum> HuCheckSums { get; set; }
        public virtual ICollection<HuCheckDtl> HuCheckDtls { get; set; }
    }
}
