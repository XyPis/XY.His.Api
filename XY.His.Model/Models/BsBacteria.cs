using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsBacteria
    {
        public BsBacteria()
        {
            this.BsBacteriaDrugs = new List<BsBacteriaDrug>();
            this.CkLabMics = new List<CkLabMic>();
            this.NfInfectTestBacterias = new List<NfInfectTestBacteria>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int TypeId { get; set; }
        public Nullable<int> GramsId { get; set; }
        public int ShuId { get; set; }
        public int StandTypeId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsBacteriaGram BsBacteriaGram { get; set; }
        public virtual BsBacteriaShu BsBacteriaShu { get; set; }
        public virtual BsBacteriaStandType BsBacteriaStandType { get; set; }
        public virtual BsBacteriaType BsBacteriaType { get; set; }
        public virtual ICollection<BsBacteriaDrug> BsBacteriaDrugs { get; set; }
        public virtual ICollection<CkLabMic> CkLabMics { get; set; }
        public virtual ICollection<NfInfectTestBacteria> NfInfectTestBacterias { get; set; }
    }
}
