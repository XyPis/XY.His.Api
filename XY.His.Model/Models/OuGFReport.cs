using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuGFReport
    {
        public int ID { get; set; }
        public int TallyGroupId { get; set; }
        public short LsreportFee { get; set; }
        public short ReportJz { get; set; }
        public short ReportBx { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsTallyGroup BsTallyGroup { get; set; }
    }
}
