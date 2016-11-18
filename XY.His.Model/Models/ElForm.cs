using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class ElForm
    {
        public int ID { get; set; }
        public int PatMenuId { get; set; }
        public Nullable<int> ElId { get; set; }
        public string X { get; set; }
        public string Y { get; set; }
        public string Title { get; set; }
        public Nullable<bool> ReadOnly { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
