using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuVoucher
    {
        public HuVoucher()
        {
            this.HuVoucherDtls = new List<HuVoucherDtl>();
        }

        public int ID { get; set; }
        public string VoucherNo { get; set; }
        public Nullable<int> HouseId { get; set; }
        public Nullable<int> CompId { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ICollection<HuVoucherDtl> HuVoucherDtls { get; set; }
    }
}
