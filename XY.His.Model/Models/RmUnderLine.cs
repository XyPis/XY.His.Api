using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RmUnderLine
    {
        public int ID { get; set; }
        public int RoomId { get; set; }
        public int ItemId { get; set; }
        public decimal UnderLine { get; set; }
        public decimal UperLine { get; set; }
        public decimal Normal { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsRoom BsRoom { get; set; }
    }
}
