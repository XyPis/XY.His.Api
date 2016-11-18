using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CKMachineResult_A
    {
        public System.DateTime OperDate { get; set; }
        public int ID { get; set; }
        public int LabID { get; set; }
        public string SampleNum { get; set; }
        public System.DateTime TestDate { get; set; }
        public int MachineID { get; set; }
        public int TestTypeID { get; set; }
    }
}
