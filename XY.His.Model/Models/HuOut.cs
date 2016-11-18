using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class HuOut
    {
        public HuOut()
        {
            this.HuOutDtls = new List<HuOutDtl>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public int RoomId { get; set; }
        public Nullable<int> ApplyId { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public string OutMemo { get; set; }
        public bool YFSign { get; set; }
        public Nullable<int> YFOperId { get; set; }
        public Nullable<System.DateTime> YFOperTime { get; set; }
        public bool IsSign { get; set; }
        public Nullable<System.DateTime> SignTime { get; set; }
        public Nullable<int> SignOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> ApperId { get; set; }
        public Nullable<int> OutWayId { get; set; }
        public virtual BsHouse BsHouse { get; set; }
        public virtual BsRoom BsRoom { get; set; }
        public virtual RmAppDrug RmAppDrug { get; set; }
        public virtual ICollection<HuOutDtl> HuOutDtls { get; set; }
    }
}
