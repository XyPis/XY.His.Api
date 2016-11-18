using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RmAdjust
    {
        public RmAdjust()
        {
            this.RmAdjustDtls = new List<RmAdjustDtl>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public System.DateTime AdjustDate { get; set; }
        public string DispUnit { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ICollection<RmAdjustDtl> RmAdjustDtls { get; set; }
    }
}
