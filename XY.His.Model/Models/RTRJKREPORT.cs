using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RTRJKREPORT
    {
        public int id { get; set; }
        public int operid { get; set; }
        public System.DateTime opertime { get; set; }
        public Nullable<System.DateTime> cancelopertime { get; set; }
        public Nullable<int> iscancel { get; set; }
        public Nullable<System.DateTime> begintime { get; set; }
        public Nullable<System.DateTime> endtime { get; set; }
        public Nullable<int> hospitalid { get; set; }
        public string LsOutIn { get; set; }
        public Nullable<int> bills { get; set; }
        public Nullable<int> billcancel { get; set; }
        public Nullable<decimal> AmountSum { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> AmountCancel { get; set; }
        public Nullable<decimal> Insurance { get; set; }
        public Nullable<decimal> AmountPay { get; set; }
        public Nullable<decimal> AmountYF { get; set; }
        public bool IsSign { get; set; }
        public Nullable<System.DateTime> SignTime { get; set; }
        public Nullable<int> SignOperId { get; set; }
        public string Memo { get; set; }
    }
}
