using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuStock
    {
        public HuStock()
        {
            this.HuVoucherDtls = new List<HuVoucherDtl>();
            this.HuStockDtls = new List<HuStockDtl>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public int CompId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsSign { get; set; }
        public Nullable<System.DateTime> SignTime { get; set; }
        public Nullable<int> SignOperId { get; set; }
        public bool IsBack { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Memo { get; set; }
        public Nullable<int> BuyId { get; set; }
        public Nullable<int> BuyWayId { get; set; }
        public Nullable<int> Applicant { get; set; }
        public Nullable<int> Application { get; set; }
        public virtual BsCompany BsCompany { get; set; }
        public virtual BsHouse BsHouse { get; set; }
        public virtual ICollection<HuVoucherDtl> HuVoucherDtls { get; set; }
        public virtual ICollection<HuStockDtl> HuStockDtls { get; set; }
    }
}
