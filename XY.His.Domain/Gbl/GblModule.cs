using System;
using System.Collections.Generic;

namespace XY.His.Domain.Gbl
{
    public partial class GblModule : EntityBase
    {
        public int ID { get; set; }
        public Nullable<int> FunctionID { get; set; }
        public Nullable<int> MenuId { get; set; }
        public int OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
