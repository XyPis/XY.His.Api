using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.BS
{
    [Serializable]
    public partial class BsDrugFormDto : DtoBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsReject { get; set; }
        public bool IsSave { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
