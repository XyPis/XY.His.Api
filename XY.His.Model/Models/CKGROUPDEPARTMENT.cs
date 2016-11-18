using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CKGROUPDEPARTMENT
    {
        public int ID { get; set; }
        public string CODE { get; set; }
        public string NAME { get; set; }
        public bool ISACTIVE { get; set; }
        public string WBCODE { get; set; }
        public string PYCODE { get; set; }
        public Nullable<int> OPERID { get; set; }
        public Nullable<System.DateTime> OPERTIME { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public int ICONINDEX { get; set; }
    }
}
