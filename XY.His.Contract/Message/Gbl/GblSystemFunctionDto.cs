using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.Gbl
{    
    [Serializable]
    public partial class GblSystemFunctionDto : DtoBase
    {
        public string Code { get; set; }
        public string Name { get; set; }
        public int OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }     
    }
}
