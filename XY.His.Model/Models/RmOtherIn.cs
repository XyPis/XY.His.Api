using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RmOtherIn
    {
        public RmOtherIn()
        {
            this.RmOtherInDtls = new List<RmOtherInDtl>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int RoomId { get; set; }
        public string Reason { get; set; }
        public System.DateTime OperTime { get; set; }
        public int Operid { get; set; }
        public bool IsSign { get; set; }
        public Nullable<System.DateTime> SignTime { get; set; }
        public Nullable<int> SignOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsRoom BsRoom { get; set; }
        public virtual ICollection<RmOtherInDtl> RmOtherInDtls { get; set; }
    }
}
