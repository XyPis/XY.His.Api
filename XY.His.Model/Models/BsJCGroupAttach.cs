using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsJCGroupAttach
    {
        public int ID { get; set; }
        public int GroupId { get; set; }
        public int ItemId { get; set; }
        public decimal Totality { get; set; }
        public Nullable<int> LocationId { get; set; }
        public short LsUseArea { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsJCGroup BsJCGroup { get; set; }
        public virtual BsLocation BsLocation { get; set; }
    }
}
