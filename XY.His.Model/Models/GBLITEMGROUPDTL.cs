using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GBLITEMGROUPDTL
    {
        public int ID { get; set; }
        public int GROUPID { get; set; }
        public int ITEMID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual GBLITEMGROUP GBLITEMGROUP { get; set; }
    }
}
