using System;
using System.Collections.Generic;

namespace XY.His.Domain.Gbl
{
    public partial class GblSystemFunction : EntityBase
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }     
    }
}
