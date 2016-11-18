using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsDrugFormUsage
    {
        public int ID { get; set; }
        public int FormId { get; set; }
        public int UsageId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsDrugForm BsDrugForm { get; set; }
        public virtual BsUsage BsUsage { get; set; }
    }
}
