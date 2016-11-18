using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RmSplit
    {
        public RmSplit()
        {
            this.RmSplitIns = new List<RmSplitIn>();
            this.RmSplitOuts = new List<RmSplitOut>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int RoomId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsRoom BsRoom { get; set; }
        public virtual ICollection<RmSplitIn> RmSplitIns { get; set; }
        public virtual ICollection<RmSplitOut> RmSplitOuts { get; set; }
    }
}
