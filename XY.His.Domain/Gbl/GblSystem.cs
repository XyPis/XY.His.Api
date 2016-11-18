using System;
using System.Collections.Generic;

namespace XY.His.Domain.Gbl
{
    public partial class GblSystem : EntityBase
    {
        public int ID { get; set; }
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
