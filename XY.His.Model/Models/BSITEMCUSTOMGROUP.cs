using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BSITEMCUSTOMGROUP
    {
        public BSITEMCUSTOMGROUP()
        {
            this.BSITEMCUSTOMs = new List<BSITEMCUSTOM>();
        }

        public int ID { get; set; }
        public string NAME { get; set; }
        public int ORDERBY { get; set; }
        public int ISACTIVE { get; set; }
        public int LSOUTORIN { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int ICONINDEX { get; set; }
        public virtual ICollection<BSITEMCUSTOM> BSITEMCUSTOMs { get; set; }
    }
}
