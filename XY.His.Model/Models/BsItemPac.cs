using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsItemPac
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public Nullable<short> XType { get; set; }
        public string Equipment { get; set; }
        public string CheckBody { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsItem BsItem { get; set; }
    }
}
