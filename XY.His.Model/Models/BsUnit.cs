using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsUnit
    {
        public BsUnit()
        {
            this.BsItems = new List<BsItem>();
            this.BsItems1 = new List<BsItem>();
            this.BsItems2 = new List<BsItem>();
            this.BsItemDrugs = new List<BsItemDrug>();
            this.BsItemLocations = new List<BsItemLocation>();
            this.BsItemUnits = new List<BsItemUnit>();
            this.BsXdRpDtls = new List<BsXdRpDtl>();
            this.DhInAdviceLongs = new List<DhInAdviceLong>();
            this.DhInAdviceLongs1 = new List<DhInAdviceLong>();
            this.DhInAdviceTemps = new List<DhInAdviceTemp>();
            this.DhInAdviceTemps1 = new List<DhInAdviceTemp>();
            this.DhStores = new List<DhStore>();
            this.DhStores1 = new List<DhStore>();
            this.Equipments = new List<Equipment>();
            this.INADVICENURSEs = new List<INADVICENURSE>();
            this.INADVICENURSEs1 = new List<INADVICENURSE>();
            this.InDrugReqdtlSkinBacks = new List<InDrugReqdtlSkinBack>();
            this.InExecutes = new List<InExecute>();
            this.InExecutes1 = new List<InExecute>();
            this.InInvoiceDtlDumps = new List<InInvoiceDtlDump>();
            this.InInvoiceDtlTemps = new List<InInvoiceDtlTemp>();
            this.HuBackDtls = new List<HuBackDtl>();
            this.HuLoseDtls = new List<HuLoseDtl>();
            this.HuOtherInDtls = new List<HuOtherInDtl>();
            this.HuOtherOutDtls = new List<HuOtherOutDtl>();
            this.HuOutDtls = new List<HuOutDtl>();
            this.HuPkDtls = new List<HuPkDtl>();
            this.HuPydtls = new List<HuPydtl>();
            this.HuSplitIns = new List<HuSplitIn>();
            this.HuSplitOuts = new List<HuSplitOut>();
            this.HuStoreLogs = new List<HuStoreLog>();
            this.HuCheckDtls = new List<HuCheckDtl>();
            this.HuStockDtls = new List<HuStockDtl>();
            this.HuStockReqdtls = new List<HuStockReqdtl>();
            this.HuStores = new List<HuStore>();
            this.RmAppDrugDtls = new List<RmAppDrugDtl>();
            this.RmApplbackDtls = new List<RmApplbackDtl>();
            this.RmBackDetails = new List<RmBackDetail>();
            this.RmKsBackDtls = new List<RmKsBackDtl>();
            this.RmKOutDtls = new List<RmKOutDtl>();
            this.RmLoseDtls = new List<RmLoseDtl>();
            this.RmMoveDtls = new List<RmMoveDtl>();
            this.RmOutOthDtls = new List<RmOutOthDtl>();
            this.RmOutDtls = new List<RmOutDtl>();
            this.RmPkDtls = new List<RmPkDtl>();
            this.RmPyDtls = new List<RmPyDtl>();
            this.RmSplitIns = new List<RmSplitIn>();
            this.RmSplitOuts = new List<RmSplitOut>();
            this.RmStoreLogs = new List<RmStoreLog>();
            this.RmCheckDtls = new List<RmCheckDtl>();
            this.Rmstores = new List<Rmstore>();
            this.RmZyBackDtls = new List<RmZyBackDtl>();
            this.RmZyOutDtls = new List<RmZyOutDtl>();
            this.OuInvoiceDtls = new List<OuInvoiceDtl>();
            this.OuExecuteDtls = new List<OuExecuteDtl>();
            this.OuRecipeDtls = new List<OuRecipeDtl>();
            this.OuRecipeDtls1 = new List<OuRecipeDtl>();
            this.BsXdRpDtls1 = new List<BsXdRpDtl>();
            this.NfInfectDrugs = new List<NfInfectDrug>();
            this.OuRecipeBacks = new List<OuRecipeBack>();
            this.RmOtherInDtls = new List<RmOtherInDtl>();
            this.InAdviceLongs = new List<InAdviceLong>();
            this.InAdviceLongs1 = new List<InAdviceLong>();
            this.InAdviceTemps = new List<InAdviceTemp>();
            this.InAdviceTemps1 = new List<InAdviceTemp>();
            this.InChinRicipeDtls = new List<InChinRicipeDtl>();
            this.InDayAdds = new List<InDayAdd>();
            this.InDayCharges = new List<InDayCharge>();
            this.InInvoiceDtls = new List<InInvoiceDtl>();
            this.InDrugReqBacks = new List<InDrugReqBack>();
            this.InDrugReqdtls = new List<InDrugReqdtl>();
            this.InDrugReqdtls1 = new List<InDrugReqdtl>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PrintName { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<BsItem> BsItems { get; set; }
        public virtual ICollection<BsItem> BsItems1 { get; set; }
        public virtual ICollection<BsItem> BsItems2 { get; set; }
        public virtual ICollection<BsItemDrug> BsItemDrugs { get; set; }
        public virtual ICollection<BsItemLocation> BsItemLocations { get; set; }
        public virtual ICollection<BsItemUnit> BsItemUnits { get; set; }
        public virtual ICollection<BsXdRpDtl> BsXdRpDtls { get; set; }
        public virtual ICollection<DhInAdviceLong> DhInAdviceLongs { get; set; }
        public virtual ICollection<DhInAdviceLong> DhInAdviceLongs1 { get; set; }
        public virtual ICollection<DhInAdviceTemp> DhInAdviceTemps { get; set; }
        public virtual ICollection<DhInAdviceTemp> DhInAdviceTemps1 { get; set; }
        public virtual ICollection<DhStore> DhStores { get; set; }
        public virtual ICollection<DhStore> DhStores1 { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
        public virtual ICollection<INADVICENURSE> INADVICENURSEs { get; set; }
        public virtual ICollection<INADVICENURSE> INADVICENURSEs1 { get; set; }
        public virtual ICollection<InDrugReqdtlSkinBack> InDrugReqdtlSkinBacks { get; set; }
        public virtual ICollection<InExecute> InExecutes { get; set; }
        public virtual ICollection<InExecute> InExecutes1 { get; set; }
        public virtual ICollection<InInvoiceDtlDump> InInvoiceDtlDumps { get; set; }
        public virtual ICollection<InInvoiceDtlTemp> InInvoiceDtlTemps { get; set; }
        public virtual ICollection<HuBackDtl> HuBackDtls { get; set; }
        public virtual ICollection<HuLoseDtl> HuLoseDtls { get; set; }
        public virtual ICollection<HuOtherInDtl> HuOtherInDtls { get; set; }
        public virtual ICollection<HuOtherOutDtl> HuOtherOutDtls { get; set; }
        public virtual ICollection<HuOutDtl> HuOutDtls { get; set; }
        public virtual ICollection<HuPkDtl> HuPkDtls { get; set; }
        public virtual ICollection<HuPydtl> HuPydtls { get; set; }
        public virtual ICollection<HuSplitIn> HuSplitIns { get; set; }
        public virtual ICollection<HuSplitOut> HuSplitOuts { get; set; }
        public virtual ICollection<HuStoreLog> HuStoreLogs { get; set; }
        public virtual ICollection<HuCheckDtl> HuCheckDtls { get; set; }
        public virtual ICollection<HuStockDtl> HuStockDtls { get; set; }
        public virtual ICollection<HuStockReqdtl> HuStockReqdtls { get; set; }
        public virtual ICollection<HuStore> HuStores { get; set; }
        public virtual ICollection<RmAppDrugDtl> RmAppDrugDtls { get; set; }
        public virtual ICollection<RmApplbackDtl> RmApplbackDtls { get; set; }
        public virtual ICollection<RmBackDetail> RmBackDetails { get; set; }
        public virtual ICollection<RmKsBackDtl> RmKsBackDtls { get; set; }
        public virtual ICollection<RmKOutDtl> RmKOutDtls { get; set; }
        public virtual ICollection<RmLoseDtl> RmLoseDtls { get; set; }
        public virtual ICollection<RmMoveDtl> RmMoveDtls { get; set; }
        public virtual ICollection<RmOutOthDtl> RmOutOthDtls { get; set; }
        public virtual ICollection<RmOutDtl> RmOutDtls { get; set; }
        public virtual ICollection<RmPkDtl> RmPkDtls { get; set; }
        public virtual ICollection<RmPyDtl> RmPyDtls { get; set; }
        public virtual ICollection<RmSplitIn> RmSplitIns { get; set; }
        public virtual ICollection<RmSplitOut> RmSplitOuts { get; set; }
        public virtual ICollection<RmStoreLog> RmStoreLogs { get; set; }
        public virtual ICollection<RmCheckDtl> RmCheckDtls { get; set; }
        public virtual ICollection<Rmstore> Rmstores { get; set; }
        public virtual ICollection<RmZyBackDtl> RmZyBackDtls { get; set; }
        public virtual ICollection<RmZyOutDtl> RmZyOutDtls { get; set; }
        public virtual ICollection<OuInvoiceDtl> OuInvoiceDtls { get; set; }
        public virtual ICollection<OuExecuteDtl> OuExecuteDtls { get; set; }
        public virtual ICollection<OuRecipeDtl> OuRecipeDtls { get; set; }
        public virtual ICollection<OuRecipeDtl> OuRecipeDtls1 { get; set; }
        public virtual ICollection<BsXdRpDtl> BsXdRpDtls1 { get; set; }
        public virtual ICollection<NfInfectDrug> NfInfectDrugs { get; set; }
        public virtual ICollection<OuRecipeBack> OuRecipeBacks { get; set; }
        public virtual ICollection<RmOtherInDtl> RmOtherInDtls { get; set; }
        public virtual ICollection<InAdviceLong> InAdviceLongs { get; set; }
        public virtual ICollection<InAdviceLong> InAdviceLongs1 { get; set; }
        public virtual ICollection<InAdviceTemp> InAdviceTemps { get; set; }
        public virtual ICollection<InAdviceTemp> InAdviceTemps1 { get; set; }
        public virtual ICollection<InChinRicipeDtl> InChinRicipeDtls { get; set; }
        public virtual ICollection<InDayAdd> InDayAdds { get; set; }
        public virtual ICollection<InDayCharge> InDayCharges { get; set; }
        public virtual ICollection<InInvoiceDtl> InInvoiceDtls { get; set; }
        public virtual ICollection<InDrugReqBack> InDrugReqBacks { get; set; }
        public virtual ICollection<InDrugReqdtl> InDrugReqdtls { get; set; }
        public virtual ICollection<InDrugReqdtl> InDrugReqdtls1 { get; set; }
    }
}
