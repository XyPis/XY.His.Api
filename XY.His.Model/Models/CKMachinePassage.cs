using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CKMachinePassage
    {
        public int ID { get; set; }
        public int MachineID { get; set; }
        public int TestID { get; set; }
        public string PassAgeNum { get; set; }
        public decimal Modulus { get; set; }
        public bool IsQc { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual CKMachine CKMachine { get; set; }
    }
}
