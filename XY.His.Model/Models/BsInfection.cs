using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsInfection
    {
        public int id { get; set; }
        public string name { get; set; }
        public int type { get; set; }
        public string f1 { get; set; }
        public string f2 { get; set; }
        public string f3 { get; set; }
        public string f4 { get; set; }
        public Nullable<bool> isactive { get; set; }
        public Nullable<int> orderby { get; set; }
    }
}
