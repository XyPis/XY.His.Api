using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RmLose
    {
        public RmLose()
        {
            this.RmLoseDtls = new List<RmLoseDtl>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int RoomId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int Operid { get; set; }
        public bool IsSign { get; set; }
        public Nullable<System.DateTime> SignDate { get; set; }
        public Nullable<int> SignOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsRoom BsRoom { get; set; }
        public virtual ICollection<RmLoseDtl> RmLoseDtls { get; set; }
    }
}
