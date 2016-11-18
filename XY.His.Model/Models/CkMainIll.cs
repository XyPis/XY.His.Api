using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkMainIll
    {
        public int ID { get; set; }
        public int CheckId { get; set; }
        public int ListNum { get; set; }
        public Nullable<int> IcdId { get; set; }
        public string IllDesc { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsIllness BsIllness { get; set; }
        public virtual CkMain CkMain { get; set; }
    }
}
