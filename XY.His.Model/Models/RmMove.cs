using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RmMove
    {
        public RmMove()
        {
            this.RmMoveDtls = new List<RmMoveDtl>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int RoomIdI { get; set; }
        public int RoomIdO { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int Operid { get; set; }
        public bool IsSign { get; set; }
        public Nullable<System.DateTime> SignTime { get; set; }
        public Nullable<int> SignOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<bool> IsSignRev { get; set; }
        public Nullable<System.DateTime> SignTimeRev { get; set; }
        public Nullable<int> SignOperIdRev { get; set; }
        public virtual BsRoom BsRoom { get; set; }
        public virtual BsRoom BsRoom1 { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsUser BsUser1 { get; set; }
        public virtual ICollection<RmMoveDtl> RmMoveDtls { get; set; }
    }
}
