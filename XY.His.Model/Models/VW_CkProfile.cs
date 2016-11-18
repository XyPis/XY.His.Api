using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VW_CkProfile
    {
        public int ID { get; set; }
        public int PROFILEID { get; set; }
        public int TESTID { get; set; }
        public string PROFILENAME { get; set; }
        public string TESTNAME { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> ITEMID { get; set; }
    }
}
