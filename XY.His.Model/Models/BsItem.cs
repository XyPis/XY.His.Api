using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsItem
    {
        public BsItem()
        {
            this.AdviceAuthDtls = new List<AdviceAuthDtl>();
            this.BsAnaeItems = new List<BsAnaeItem>();
            this.BsBeds = new List<BsBed>();
            this.BsExecLocations = new List<BsExecLocation>();
            this.BsFixCharges = new List<BsFixCharge>();
            this.BsItemAttaches = new List<BsItemAttach>();
            this.BsItemAttaches1 = new List<BsItemAttach>();
            this.BsItemDrugs = new List<BsItemDrug>();
            this.BsItemEquipments = new List<BsItemEquipment>();
            this.BsItemFirstPages = new List<BsItemFirstPage>();
            this.BsItemItems = new List<BsItemItem>();
            this.BsItemItems1 = new List<BsItemItem>();
            this.BsItemNames = new List<BsItemName>();
            this.BsItemNameMultis = new List<BsItemNameMulti>();
            this.BsItemPacs = new List<BsItemPac>();
            this.BsItemPeoples = new List<BsItemPeople>();
            this.BsItemPersons = new List<BsItemPerson>();
            this.BsItemYbs = new List<BsItemYb>();
            this.BsItemYbTips = new List<BsItemYbTip>();
            this.BsOuMergeFees = new List<BsOuMergeFee>();
            this.BsOuMergeFees1 = new List<BsOuMergeFee>();
            this.BsYbCodeSpecs = new List<BsYbCodeSpec>();
            this.CkCompGroupPsApplies = new List<CkCompGroupPsApply>();
            this.CkPsApplies = new List<CkPsApply>();
            this.CsIncomeDetails = new List<CsIncomeDetail>();
            this.FtDetails = new List<FtDetail>();
            this.GBLITEMGROUPDTLs = new List<GBLITEMGROUPDTL>();
            this.HuAdjustPlanDtls = new List<HuAdjustPlanDtl>();
            this.HuPkDtls = new List<HuPkDtl>();
            this.HuStores = new List<HuStore>();
            this.InExecutes = new List<InExecute>();
            this.InInvoiceDtlDumps = new List<InInvoiceDtlDump>();
            this.InInvoiceDtlTemps = new List<InInvoiceDtlTemp>();
            this.InNotAttaches = new List<InNotAttach>();
            this.InNotAttaches1 = new List<InNotAttach>();
            this.HuAdjustDtls = new List<HuAdjustDtl>();
            this.HuBackDtls = new List<HuBackDtl>();
            this.HuLoseDtls = new List<HuLoseDtl>();
            this.HuOtherInDtls = new List<HuOtherInDtl>();
            this.HuOtherOutDtls = new List<HuOtherOutDtl>();
            this.HuOutDtls = new List<HuOutDtl>();
            this.HuPydtls = new List<HuPydtl>();
            this.HuSplitIns = new List<HuSplitIn>();
            this.HuSplitOuts = new List<HuSplitOut>();
            this.HuStoreLogs = new List<HuStoreLog>();
            this.HuCheckDtls = new List<HuCheckDtl>();
            this.HuStockDtls = new List<HuStockDtl>();
            this.HuStockReqdtls = new List<HuStockReqdtl>();
            this.BsUnitRatios = new List<BsUnitRatio>();
            this.RmAdjustDtls = new List<RmAdjustDtl>();
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
            this.RmCheckGroupDtls = new List<RmCheckGroupDtl>();
            this.RmCheckDtls = new List<RmCheckDtl>();
            this.Rmstores = new List<Rmstore>();
            this.RmUnderLines = new List<RmUnderLine>();
            this.RmZyBackDtls = new List<RmZyBackDtl>();
            this.RmZyOutDtls = new List<RmZyOutDtl>();
            this.OuInvoiceDtls = new List<OuInvoiceDtl>();
            this.OuExecuteDtls = new List<OuExecuteDtl>();
            this.BsXdRpDtls = new List<BsXdRpDtl>();
            this.OpsCharges = new List<OpsCharge>();
            this.BsOpsItems = new List<BsOpsItem>();
            this.BsOpsItems1 = new List<BsOpsItem>();
            this.OtBidDtls = new List<OtBidDtl>();
            this.OuNotAttaches = new List<OuNotAttach>();
            this.OuNotAttaches1 = new List<OuNotAttach>();
            this.OuRecipeDtls = new List<OuRecipeDtl>();
            this.PsApplyReports = new List<PsApplyReport>();
            this.PsDrugActions = new List<PsDrugAction>();
            this.BsUsageItems = new List<BsUsageItem>();
            this.BsItemFrequencies = new List<BsItemFrequency>();
            this.BsItemLocations = new List<BsItemLocation>();
            this.BsItemPatTypes = new List<BsItemPatType>();
            this.BsItemUnits = new List<BsItemUnit>();
            this.BsItemUsages = new List<BsItemUsage>();
            this.BsJCGroupAttaches = new List<BsJCGroupAttach>();
            this.BsJCGroupItems = new List<BsJCGroupItem>();
            this.ElInoculates = new List<ElInoculate>();
            this.RmOtherInDtls = new List<RmOtherInDtl>();
            this.InAdviceLongs = new List<InAdviceLong>();
            this.InAdviceTemps = new List<InAdviceTemp>();
            this.InChinRicipeDtls = new List<InChinRicipeDtl>();
            this.InDayAdds = new List<InDayAdd>();
            this.InDayCharges = new List<InDayCharge>();
            this.InInvoiceDtlBeds = new List<InInvoiceDtlBed>();
            this.InInvoiceDtls = new List<InInvoiceDtl>();
            this.InDrugReqdtls = new List<InDrugReqdtl>();
        }

        public int ID { get; set; }
        public short LsGroupType { get; set; }
        public string Code { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public string StrokeCode { get; set; }
        public string OtherCode { get; set; }
        public int GroupMainId { get; set; }
        public Nullable<int> GroupSubId { get; set; }
        public string Name { get; set; }
        public string LongDesc { get; set; }
        public string EngDesc { get; set; }
        public string Spec { get; set; }
        public int UnitInId { get; set; }
        public decimal PriceIn { get; set; }
        public int UnitDiagId { get; set; }
        public decimal PriceDiag { get; set; }
        public decimal AddPercent { get; set; }
        public short LsRpType { get; set; }
        public decimal Dosage { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public int FeeMzId { get; set; }
        public int FeeZyId { get; set; }
        public short LsGfType { get; set; }
        public Nullable<decimal> GfFixDisc { get; set; }
        public bool OptionPrice { get; set; }
        public decimal LimitTotalMz { get; set; }
        public decimal LimitTotalZy { get; set; }
        public int TypeGFXEId { get; set; }
        public bool IsSpecSum { get; set; }
        public bool IsNew { get; set; }
        public bool IsOnlyForSys { get; set; }
        public bool IsRpForbid { get; set; }
        public bool IsChildAdd { get; set; }
        public bool IsBedFee { get; set; }
        public bool IsOpsAdd { get; set; }
        public short LsfeeTurn { get; set; }
        public short LsAdviceType { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> LISCode { get; set; }
        public string CoverPicture { get; set; }
        public string MemoPicture { get; set; }
        public string Memo { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<bool> IsInoculate { get; set; }
        public Nullable<decimal> PriceHighLine { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public Nullable<int> GroupSubId2 { get; set; }
        public Nullable<System.DateTime> LastTime { get; set; }
        public Nullable<decimal> PriceSub { get; set; }
        public Nullable<int> CheckId { get; set; }
        public Nullable<int> NurseId { get; set; }
        public Nullable<int> CureId { get; set; }
        public Nullable<int> DrugID { get; set; }
        public Nullable<int> CopyId { get; set; }
        public Nullable<int> MzUnitTotal { get; set; }
        public Nullable<int> ZyUnitTotal { get; set; }
        public Nullable<bool> IsMtDrug { get; set; }
        public string PackageSpec { get; set; }
        public bool IsCitySum { get; set; }
        public virtual ICollection<AdviceAuthDtl> AdviceAuthDtls { get; set; }
        public virtual ICollection<BsAnaeItem> BsAnaeItems { get; set; }
        public virtual ICollection<BsBed> BsBeds { get; set; }
        public virtual ICollection<BsExecLocation> BsExecLocations { get; set; }
        public virtual ICollection<BsFixCharge> BsFixCharges { get; set; }
        public virtual BsFrequency BsFrequency { get; set; }
        public virtual BsGfxe BsGfxe { get; set; }
        public virtual BsGroup BsGroup { get; set; }
        public virtual BsGroupSub BsGroupSub { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsMzFeety BsMzFeety { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual BsUnit BsUnit1 { get; set; }
        public virtual BsUnit BsUnit2 { get; set; }
        public virtual BsUsage BsUsage { get; set; }
        public virtual BsZyFeety BsZyFeety { get; set; }
        public virtual ICollection<BsItemAttach> BsItemAttaches { get; set; }
        public virtual ICollection<BsItemAttach> BsItemAttaches1 { get; set; }
        public virtual ICollection<BsItemDrug> BsItemDrugs { get; set; }
        public virtual ICollection<BsItemEquipment> BsItemEquipments { get; set; }
        public virtual ICollection<BsItemFirstPage> BsItemFirstPages { get; set; }
        public virtual ICollection<BsItemItem> BsItemItems { get; set; }
        public virtual ICollection<BsItemItem> BsItemItems1 { get; set; }
        public virtual ICollection<BsItemName> BsItemNames { get; set; }
        public virtual ICollection<BsItemNameMulti> BsItemNameMultis { get; set; }
        public virtual ICollection<BsItemPac> BsItemPacs { get; set; }
        public virtual ICollection<BsItemPeople> BsItemPeoples { get; set; }
        public virtual ICollection<BsItemPerson> BsItemPersons { get; set; }
        public virtual ICollection<BsItemYb> BsItemYbs { get; set; }
        public virtual ICollection<BsItemYbTip> BsItemYbTips { get; set; }
        public virtual ICollection<BsOuMergeFee> BsOuMergeFees { get; set; }
        public virtual ICollection<BsOuMergeFee> BsOuMergeFees1 { get; set; }
        public virtual ICollection<BsYbCodeSpec> BsYbCodeSpecs { get; set; }
        public virtual ICollection<CkCompGroupPsApply> CkCompGroupPsApplies { get; set; }
        public virtual ICollection<CkPsApply> CkPsApplies { get; set; }
        public virtual ICollection<CsIncomeDetail> CsIncomeDetails { get; set; }
        public virtual ICollection<FtDetail> FtDetails { get; set; }
        public virtual ICollection<GBLITEMGROUPDTL> GBLITEMGROUPDTLs { get; set; }
        public virtual ICollection<HuAdjustPlanDtl> HuAdjustPlanDtls { get; set; }
        public virtual ICollection<HuPkDtl> HuPkDtls { get; set; }
        public virtual ICollection<HuStore> HuStores { get; set; }
        public virtual ICollection<InExecute> InExecutes { get; set; }
        public virtual ICollection<InInvoiceDtlDump> InInvoiceDtlDumps { get; set; }
        public virtual ICollection<InInvoiceDtlTemp> InInvoiceDtlTemps { get; set; }
        public virtual ICollection<InNotAttach> InNotAttaches { get; set; }
        public virtual ICollection<InNotAttach> InNotAttaches1 { get; set; }
        public virtual ICollection<HuAdjustDtl> HuAdjustDtls { get; set; }
        public virtual ICollection<HuBackDtl> HuBackDtls { get; set; }
        public virtual ICollection<HuLoseDtl> HuLoseDtls { get; set; }
        public virtual ICollection<HuOtherInDtl> HuOtherInDtls { get; set; }
        public virtual ICollection<HuOtherOutDtl> HuOtherOutDtls { get; set; }
        public virtual ICollection<HuOutDtl> HuOutDtls { get; set; }
        public virtual ICollection<HuPydtl> HuPydtls { get; set; }
        public virtual ICollection<HuSplitIn> HuSplitIns { get; set; }
        public virtual ICollection<HuSplitOut> HuSplitOuts { get; set; }
        public virtual ICollection<HuStoreLog> HuStoreLogs { get; set; }
        public virtual ICollection<HuCheckDtl> HuCheckDtls { get; set; }
        public virtual ICollection<HuStockDtl> HuStockDtls { get; set; }
        public virtual ICollection<HuStockReqdtl> HuStockReqdtls { get; set; }
        public virtual ICollection<BsUnitRatio> BsUnitRatios { get; set; }
        public virtual ICollection<RmAdjustDtl> RmAdjustDtls { get; set; }
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
        public virtual ICollection<RmCheckGroupDtl> RmCheckGroupDtls { get; set; }
        public virtual ICollection<RmCheckDtl> RmCheckDtls { get; set; }
        public virtual ICollection<Rmstore> Rmstores { get; set; }
        public virtual ICollection<RmUnderLine> RmUnderLines { get; set; }
        public virtual ICollection<RmZyBackDtl> RmZyBackDtls { get; set; }
        public virtual ICollection<RmZyOutDtl> RmZyOutDtls { get; set; }
        public virtual ICollection<OuInvoiceDtl> OuInvoiceDtls { get; set; }
        public virtual ICollection<OuExecuteDtl> OuExecuteDtls { get; set; }
        public virtual ICollection<BsXdRpDtl> BsXdRpDtls { get; set; }
        public virtual ICollection<OpsCharge> OpsCharges { get; set; }
        public virtual ICollection<BsOpsItem> BsOpsItems { get; set; }
        public virtual ICollection<BsOpsItem> BsOpsItems1 { get; set; }
        public virtual ICollection<OtBidDtl> OtBidDtls { get; set; }
        public virtual ICollection<OuNotAttach> OuNotAttaches { get; set; }
        public virtual ICollection<OuNotAttach> OuNotAttaches1 { get; set; }
        public virtual ICollection<OuRecipeDtl> OuRecipeDtls { get; set; }
        public virtual ICollection<PsApplyReport> PsApplyReports { get; set; }
        public virtual ICollection<PsDrugAction> PsDrugActions { get; set; }
        public virtual ICollection<BsUsageItem> BsUsageItems { get; set; }
        public virtual ICollection<BsItemFrequency> BsItemFrequencies { get; set; }
        public virtual ICollection<BsItemLocation> BsItemLocations { get; set; }
        public virtual ICollection<BsItemPatType> BsItemPatTypes { get; set; }
        public virtual ICollection<BsItemUnit> BsItemUnits { get; set; }
        public virtual ICollection<BsItemUsage> BsItemUsages { get; set; }
        public virtual ICollection<BsJCGroupAttach> BsJCGroupAttaches { get; set; }
        public virtual ICollection<BsJCGroupItem> BsJCGroupItems { get; set; }
        public virtual ICollection<ElInoculate> ElInoculates { get; set; }
        public virtual ICollection<RmOtherInDtl> RmOtherInDtls { get; set; }
        public virtual ICollection<InAdviceLong> InAdviceLongs { get; set; }
        public virtual ICollection<InAdviceTemp> InAdviceTemps { get; set; }
        public virtual ICollection<InChinRicipeDtl> InChinRicipeDtls { get; set; }
        public virtual ICollection<InDayAdd> InDayAdds { get; set; }
        public virtual ICollection<InDayCharge> InDayCharges { get; set; }
        public virtual ICollection<InInvoiceDtlBed> InInvoiceDtlBeds { get; set; }
        public virtual ICollection<InInvoiceDtl> InInvoiceDtls { get; set; }
        public virtual ICollection<InDrugReqdtl> InDrugReqdtls { get; set; }
    }
}
