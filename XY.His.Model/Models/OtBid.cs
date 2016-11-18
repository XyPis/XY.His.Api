using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OtBid
    {
        public OtBid()
        {
            this.OtBidDtls = new List<OtBidDtl>();
        }

        public int ID { get; set; }
        public string RecNo { get; set; }
        public Nullable<System.DateTime> BitTime { get; set; }
        public Nullable<System.DateTime> NotifyDate { get; set; }
        public string DispUnit { get; set; }
        public string Memo { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<short> LsStatus { get; set; }
        public Nullable<System.DateTime> SignTime { get; set; }
        public Nullable<int> SignOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<bool> IsSign { get; set; }
        public virtual ICollection<OtBidDtl> OtBidDtls { get; set; }
    }
}
