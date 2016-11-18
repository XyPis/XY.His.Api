using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsItemUsage
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public int UsageId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUsage BsUsage { get; set; }
    }
}
