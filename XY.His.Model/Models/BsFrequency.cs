using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsFrequency
    {
        public BsFrequency()
        {
            this.BsItems = new List<BsItem>();
            this.DhInAdviceLongs = new List<DhInAdviceLong>();
            this.DhInAdviceTemps = new List<DhInAdviceTemp>();
            this.INADVICENURSEs = new List<INADVICENURSE>();
            this.InChinRicipes = new List<InChinRicipe>();
            this.InExecutes = new List<InExecute>();
            this.OuExecuteDtls = new List<OuExecuteDtl>();
            this.OuRecipeDtls = new List<OuRecipeDtl>();
            this.BsXdRpDtls = new List<BsXdRpDtl>();
            this.NfInfectDrugs = new List<NfInfectDrug>();
            this.OuRecipeChins = new List<OuRecipeChin>();
            this.BsFrequencyTimes = new List<BsFrequencyTime>();
            this.BsItemFrequencies = new List<BsItemFrequency>();
            this.BsItemLocations = new List<BsItemLocation>();
            this.TmpMyPats = new List<TmpMyPat>();
            this.InAdviceLongs = new List<InAdviceLong>();
            this.InAdviceTemps = new List<InAdviceTemp>();
            this.InDrugReqdtls = new List<InDrugReqdtl>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PrintName { get; set; }
        public int Days { get; set; }
        public decimal Times { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<BsItem> BsItems { get; set; }
        public virtual ICollection<DhInAdviceLong> DhInAdviceLongs { get; set; }
        public virtual ICollection<DhInAdviceTemp> DhInAdviceTemps { get; set; }
        public virtual ICollection<INADVICENURSE> INADVICENURSEs { get; set; }
        public virtual ICollection<InChinRicipe> InChinRicipes { get; set; }
        public virtual ICollection<InExecute> InExecutes { get; set; }
        public virtual ICollection<OuExecuteDtl> OuExecuteDtls { get; set; }
        public virtual ICollection<OuRecipeDtl> OuRecipeDtls { get; set; }
        public virtual ICollection<BsXdRpDtl> BsXdRpDtls { get; set; }
        public virtual ICollection<NfInfectDrug> NfInfectDrugs { get; set; }
        public virtual ICollection<OuRecipeChin> OuRecipeChins { get; set; }
        public virtual ICollection<BsFrequencyTime> BsFrequencyTimes { get; set; }
        public virtual ICollection<BsItemFrequency> BsItemFrequencies { get; set; }
        public virtual ICollection<BsItemLocation> BsItemLocations { get; set; }
        public virtual ICollection<TmpMyPat> TmpMyPats { get; set; }
        public virtual ICollection<InAdviceLong> InAdviceLongs { get; set; }
        public virtual ICollection<InAdviceTemp> InAdviceTemps { get; set; }
        public virtual ICollection<InDrugReqdtl> InDrugReqdtls { get; set; }
    }
}
