using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuVoucherDtl
    {
        public int ID { get; set; }
        public Nullable<int> VoucherId { get; set; }
        public int BillId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> HasPay { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual HuStock HuStock { get; set; }
        public virtual HuVoucher HuVoucher { get; set; }
    }
}
