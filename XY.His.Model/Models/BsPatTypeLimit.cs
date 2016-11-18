using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsPatTypeLimit
    {
        public int ID { get; set; }
        public int PatTypeId { get; set; }
        public int DocLevId { get; set; }
        public Nullable<int> LimitGroupId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsDocLevel BsDocLevel { get; set; }
        public virtual BsLimitGroup BsLimitGroup { get; set; }
        public virtual BsPatType BsPatType { get; set; }
    }
}
