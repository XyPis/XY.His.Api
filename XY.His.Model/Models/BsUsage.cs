using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsUsage
    {
        public BsUsage()
        {
            this.BsDrugFormUsages = new List<BsDrugFormUsage>();
            this.BsItems = new List<BsItem>();
            this.BsItemLocations = new List<BsItemLocation>();
            this.BsItemUsages = new List<BsItemUsage>();
            this.DhInAdviceLongs = new List<DhInAdviceLong>();
            this.DhInAdviceTemps = new List<DhInAdviceTemp>();
            this.InAdviceGroups = new List<InAdviceGroup>();
            this.INADVICENURSEs = new List<INADVICENURSE>();
            this.InChinRicipes = new List<InChinRicipe>();
            this.InExecutes = new List<InExecute>();
            this.OuExecuteDtls = new List<OuExecuteDtl>();
            this.OuExecutes = new List<OuExecute>();
            this.OuRecipeDtls = new List<OuRecipeDtl>();
            this.BsXdRpDtls = new List<BsXdRpDtl>();
            this.NfInfectDrugs = new List<NfInfectDrug>();
            this.OuRecipeChins = new List<OuRecipeChin>();
            this.BsUsageItems = new List<BsUsageItem>();
            this.InAdviceLongs = new List<InAdviceLong>();
            this.InAdviceTemps = new List<InAdviceTemp>();
            this.InDrugReqdtls = new List<InDrugReqdtl>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PrintName { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short LsUseArea { get; set; }
        public short LsPrnFormType { get; set; }
        public bool IsPrintLabel { get; set; }
        public bool IsPrintReject { get; set; }
        public bool IsPrintDrug { get; set; }
        public bool IsPrintAst { get; set; }
        public bool IsPrintCure { get; set; }
        public bool IsPrintNurse { get; set; }
        public bool IsPrintExternal { get; set; }
        public bool IsPrintPush { get; set; }
        public bool IsPrintRejSkin { get; set; }
        public bool IsPrintDietetic { get; set; }
        public bool IsPrintBlood { get; set; }
        public bool IsMzDrop { get; set; }
        public bool IsMzReject { get; set; }
        public bool IsMzCure { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<bool> IsPrintAtomization { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public Nullable<int> LsInOutType { get; set; }
        public Nullable<bool> IsDrugTwoDay { get; set; }
        public virtual ICollection<BsDrugFormUsage> BsDrugFormUsages { get; set; }
        public virtual ICollection<BsItem> BsItems { get; set; }
        public virtual ICollection<BsItemLocation> BsItemLocations { get; set; }
        public virtual ICollection<BsItemUsage> BsItemUsages { get; set; }
        public virtual ICollection<DhInAdviceLong> DhInAdviceLongs { get; set; }
        public virtual ICollection<DhInAdviceTemp> DhInAdviceTemps { get; set; }
        public virtual ICollection<InAdviceGroup> InAdviceGroups { get; set; }
        public virtual ICollection<INADVICENURSE> INADVICENURSEs { get; set; }
        public virtual ICollection<InChinRicipe> InChinRicipes { get; set; }
        public virtual ICollection<InExecute> InExecutes { get; set; }
        public virtual ICollection<OuExecuteDtl> OuExecuteDtls { get; set; }
        public virtual ICollection<OuExecute> OuExecutes { get; set; }
        public virtual ICollection<OuRecipeDtl> OuRecipeDtls { get; set; }
        public virtual ICollection<BsXdRpDtl> BsXdRpDtls { get; set; }
        public virtual ICollection<NfInfectDrug> NfInfectDrugs { get; set; }
        public virtual ICollection<OuRecipeChin> OuRecipeChins { get; set; }
        public virtual ICollection<BsUsageItem> BsUsageItems { get; set; }
        public virtual ICollection<InAdviceLong> InAdviceLongs { get; set; }
        public virtual ICollection<InAdviceTemp> InAdviceTemps { get; set; }
        public virtual ICollection<InDrugReqdtl> InDrugReqdtls { get; set; }
    }
}
