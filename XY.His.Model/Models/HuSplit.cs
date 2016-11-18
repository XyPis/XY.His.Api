using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuSplit
    {
        public HuSplit()
        {
            this.HuSplitIns = new List<HuSplitIn>();
            this.HuSplitOuts = new List<HuSplitOut>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsHouse BsHouse { get; set; }
        public virtual ICollection<HuSplitIn> HuSplitIns { get; set; }
        public virtual ICollection<HuSplitOut> HuSplitOuts { get; set; }
    }
}
