using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.BS
{
    [Serializable]
    public partial class BsLimitDocLevDto : DtoBase
    {
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
    }
}
