using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OtBidDtl
    {
        public int ID { get; set; }
        public Nullable<int> BidId { get; set; }
        public string RoundNTime { get; set; }
        public int ItemId { get; set; }
        public int ExpOperId { get; set; }
        public Nullable<byte> Point { get; set; }
        public Nullable<bool> IsPass { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual OtBid OtBid { get; set; }
    }
}
