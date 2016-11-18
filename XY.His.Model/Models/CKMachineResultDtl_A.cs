using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CKMachineResultDtl_A
    {
        public System.DateTime OperDate { get; set; }
        public int ID { get; set; }
        public int ResultID { get; set; }
        public int TestID { get; set; }
        public string Result { get; set; }
        public string bench { get; set; }
    }
}
