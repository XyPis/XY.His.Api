using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.Gbl
{
    [Serializable]
    public partial class GblSystemDto : DtoBase
    {
        public string Name { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
