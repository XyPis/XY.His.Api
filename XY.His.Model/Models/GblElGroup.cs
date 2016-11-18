using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblElGroup
    {
        public int ID { get; set; }
        public Nullable<short> LsType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
