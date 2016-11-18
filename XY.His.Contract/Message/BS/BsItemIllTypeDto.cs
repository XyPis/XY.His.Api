using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.BS
{
    [Serializable]
    public partial class BsItemIllTypeDto : DtoBase
    {
        public int ItemId { get; set; }
        public int IllTypeId { get; set; }
        public string YbCode { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
