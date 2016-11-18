using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DgIllXdRp
    {
        public int ID { get; set; }
        public Nullable<int> IllId { get; set; }
        public int XdRpId { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsIllness BsIllness { get; set; }
        public virtual BsXdRp BsXdRp { get; set; }
    }
}
