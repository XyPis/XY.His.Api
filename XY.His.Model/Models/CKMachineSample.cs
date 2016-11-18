using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CKMachineSample
    {
        public int ID { get; set; }
        public int LabID { get; set; }
        public string SampleNum { get; set; }
        public System.DateTime MatchDate { get; set; }
        public bool SendStatus { get; set; }
        public Nullable<int> MachineID { get; set; }
        public int UserID { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual CkLab CkLab { get; set; }
        public virtual CKMachine CKMachine { get; set; }
    }
}
