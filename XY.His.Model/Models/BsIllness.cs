using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsIllness
    {
        public BsIllness()
        {
            this.BsEducationIlls = new List<BsEducationIll>();
            this.InHosMzIlls = new List<InHosMzIll>();
            this.BsItemYbTips = new List<BsItemYbTip>();
            this.BsPatIlls = new List<BsPatIll>();
            this.BsYbCodeSpecs = new List<BsYbCodeSpec>();
            this.CkMainIlls = new List<CkMainIll>();
            this.DgIllCompares = new List<DgIllCompare>();
            this.DgIllCompares1 = new List<DgIllCompare>();
            this.DgIllCures = new List<DgIllCure>();
            this.DgIllEmrs = new List<DgIllEmr>();
            this.DgIllGroups = new List<DgIllGroup>();
            this.DgIllSymptoms = new List<DgIllSymptom>();
            this.DgIllXdRps = new List<DgIllXdRp>();
            this.ElPatFormIlls = new List<ElPatFormIll>();
            this.OuClincDiags = new List<OuClincDiag>();
            this.NfInfectIlls = new List<NfInfectIll>();
            this.NrPlans = new List<NrPlan>();
            this.BsIllness1 = new List<BsIllness>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public string OtherCode { get; set; }
        public string Name { get; set; }
        public string OtherDesc { get; set; }
        public string GroupMain { get; set; }
        public string GroupSub { get; set; }
        public string GroupSSub { get; set; }
        public Nullable<int> BelongIcd { get; set; }
        public bool IsSum { get; set; }
        public Nullable<decimal> FeeHigh { get; set; }
        public Nullable<short> DayHigh { get; set; }
        public int OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<bool> IsInfectious { get; set; }
        public virtual ICollection<BsEducationIll> BsEducationIlls { get; set; }
        public virtual ICollection<InHosMzIll> InHosMzIlls { get; set; }
        public virtual BsIllness0 BsIllness0 { get; set; }
        public virtual ICollection<BsItemYbTip> BsItemYbTips { get; set; }
        public virtual ICollection<BsPatIll> BsPatIlls { get; set; }
        public virtual ICollection<BsYbCodeSpec> BsYbCodeSpecs { get; set; }
        public virtual ICollection<CkMainIll> CkMainIlls { get; set; }
        public virtual ICollection<DgIllCompare> DgIllCompares { get; set; }
        public virtual ICollection<DgIllCompare> DgIllCompares1 { get; set; }
        public virtual ICollection<DgIllCure> DgIllCures { get; set; }
        public virtual ICollection<DgIllEmr> DgIllEmrs { get; set; }
        public virtual ICollection<DgIllGroup> DgIllGroups { get; set; }
        public virtual ICollection<DgIllSymptom> DgIllSymptoms { get; set; }
        public virtual ICollection<DgIllXdRp> DgIllXdRps { get; set; }
        public virtual ICollection<ElPatFormIll> ElPatFormIlls { get; set; }
        public virtual ICollection<OuClincDiag> OuClincDiags { get; set; }
        public virtual ICollection<NfInfectIll> NfInfectIlls { get; set; }
        public virtual ICollection<NrPlan> NrPlans { get; set; }
        public virtual ICollection<BsIllness> BsIllness1 { get; set; }
        public virtual BsIllness BsIllness2 { get; set; }
    }
}
