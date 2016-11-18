using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsItemYbTip
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public Nullable<int> PatTypeId { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public Nullable<int> IcdId { get; set; }
        public string IllDesc { get; set; }
        public string Tips { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsIllness BsIllness { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsPatType BsPatType { get; set; }
        public virtual BsTallyGroup BsTallyGroup { get; set; }
    }
}
