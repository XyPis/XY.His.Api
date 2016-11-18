using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RmCheck
    {
        public RmCheck()
        {
            this.RmCheckSums = new List<RmCheckSum>();
            this.RmCheckGroupDtls = new List<RmCheckGroupDtl>();
            this.RmCheckDtls = new List<RmCheckDtl>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int RoomId { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public decimal CheckAmount { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsRoom BsRoom { get; set; }
        public virtual ICollection<RmCheckSum> RmCheckSums { get; set; }
        public virtual ICollection<RmCheckGroupDtl> RmCheckGroupDtls { get; set; }
        public virtual ICollection<RmCheckDtl> RmCheckDtls { get; set; }
    }
}
