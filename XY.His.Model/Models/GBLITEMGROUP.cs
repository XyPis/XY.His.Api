using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GBLITEMGROUP
    {
        public GBLITEMGROUP()
        {
            this.GBLITEMGROUPDTLs = new List<GBLITEMGROUPDTL>();
        }

        public int ID { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ICollection<GBLITEMGROUPDTL> GBLITEMGROUPDTLs { get; set; }
    }
}
