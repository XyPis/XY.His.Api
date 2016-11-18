using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RmCheckGroupDtl
    {
        public int ID { get; set; }
        public int CheckId { get; set; }
        public int GroupId { get; set; }
        public int InBatchId { get; set; }
        public int ItemId { get; set; }
        public decimal CheckNum { get; set; }
        public Nullable<int> OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsRoomGroup BsRoomGroup { get; set; }
        public virtual RmCheck RmCheck { get; set; }
        public virtual Rmstore Rmstore { get; set; }
    }
}
