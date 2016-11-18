using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InDrugReq
    {
        public InDrugReq()
        {
            this.InDrugReqdtls = new List<InDrugReqdtl>();
        }

        public int ID { get; set; }
        public string RequestNo { get; set; }
        public int LocationId { get; set; }
        public int OperID { get; set; }
        public System.DateTime OperTime { get; set; }
        public int RoomId { get; set; }
        public short LsSendStatus { get; set; }
        public bool IsPrint { get; set; }
        public Nullable<int> ConfirmOperID { get; set; }
        public Nullable<System.DateTime> ConfirmDate { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsRoom BsRoom { get; set; }
        public virtual ICollection<InDrugReqdtl> InDrugReqdtls { get; set; }
    }
}
