using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkPsApply
    {
        public int ID { get; set; }
        public string ApplyId { get; set; }
        public int CheckId { get; set; }
        public int ItemId { get; set; }
        public string CheckBody { get; set; }
        public short XType { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual CkMain CkMain { get; set; }
    }
}
