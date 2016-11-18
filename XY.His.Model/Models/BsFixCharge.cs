using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsFixCharge
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public Nullable<int> PatTypeId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public decimal Totality { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsPatType BsPatType { get; set; }
    }
}
