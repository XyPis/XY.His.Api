using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsItemAttach
    {
        public int ID { get; set; }
        public int ItemId1 { get; set; }
        public int ItemId2 { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public Nullable<short> LsUseArea { get; set; }
        public Nullable<int> LocationId { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsItem BsItem1 { get; set; }
        public virtual BsLocation BsLocation { get; set; }
    }
}
