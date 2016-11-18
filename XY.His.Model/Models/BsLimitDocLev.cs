using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsLimitDocLev
    {
        public int ID { get; set; }
        public int LimitGroupId { get; set; }
        public Nullable<int> DocLevId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int OrderBy { get; set; }
        public Nullable<int> TypeGFXEId { get; set; }
        public decimal LimitFeeMz { get; set; }
        public decimal LimitFeeZy { get; set; }
        public string LsLimitType { get; set; }
        public bool IsActive { get; set; }
        public virtual BsDocLevel BsDocLevel { get; set; }
        public virtual BsGfxe BsGfxe { get; set; }
        public virtual BsLimitGroup BsLimitGroup { get; set; }
    }
}
