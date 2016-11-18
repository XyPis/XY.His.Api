using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CKMachine
    {
        public CKMachine()
        {
            this.CkItemRanges = new List<CkItemRange>();
            this.CKMachinePassages = new List<CKMachinePassage>();
            this.CKMachineResults = new List<CKMachineResult>();
            this.CKMachineSamples = new List<CKMachineSample>();
            this.CkQcControls = new List<CkQcControl>();
            this.CkQcLots = new List<CkQcLot>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int TestTypeID { get; set; }
        public Nullable<int> TypeNum { get; set; }
        public string MachineNum { get; set; }
        public string FirstSampleNum { get; set; }
        public string LastSampleNum { get; set; }
        public Nullable<System.DateTime> SampleBeginDate { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public Nullable<short> IconIndex { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ICollection<CkItemRange> CkItemRanges { get; set; }
        public virtual ICollection<CKMachinePassage> CKMachinePassages { get; set; }
        public virtual ICollection<CKMachineResult> CKMachineResults { get; set; }
        public virtual ICollection<CKMachineSample> CKMachineSamples { get; set; }
        public virtual ICollection<CkQcControl> CkQcControls { get; set; }
        public virtual ICollection<CkQcLot> CkQcLots { get; set; }
    }
}
