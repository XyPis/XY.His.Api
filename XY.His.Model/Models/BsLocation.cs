using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsLocation
    {
        public BsLocation()
        {
            this.BsBeds = new List<BsBed>();
            this.BsDiagRooms = new List<BsDiagRoom>();
            this.BsDoctors = new List<BsDoctor>();
            this.BsExecLocations = new List<BsExecLocation>();
            this.BsFixCharges = new List<BsFixCharge>();
            this.BsHsFeeties = new List<BsHsFeety>();
            this.BsItems = new List<BsItem>();
            this.BsItemAttaches = new List<BsItemAttach>();
            this.BsItemLocations = new List<BsItemLocation>();
            this.BsItemLocations1 = new List<BsItemLocation>();
            this.BsJCGroupAttaches = new List<BsJCGroupAttach>();
            this.InHosInfoes = new List<InHosInfo>();
            this.InHosInfoes1 = new List<InHosInfo>();
            this.BsLocationRoomWindows = new List<BsLocationRoomWindow>();
            this.BsLocBranches = new List<BsLocBranch>();
            this.BsLocPatTypes = new List<BsLocPatType>();
            this.BsUserEmrTemplates = new List<BsUserEmrTemplate>();
            this.BsXdGroupDtls = new List<BsXdGroupDtl>();
            this.BsXdRps = new List<BsXdRp>();
            this.CkBldDonates = new List<CkBldDonate>();
            this.CkBldFrees = new List<CkBldFree>();
            this.CkBldReactions = new List<CkBldReaction>();
            this.CkBldReimbs = new List<CkBldReimb>();
            this.CkLabs = new List<CkLab>();
            this.CkLabs1 = new List<CkLab>();
            this.CkMains = new List<CkMain>();
            this.CsBigConsumes = new List<CsBigConsume>();
            this.CsCostDetails = new List<CsCostDetail>();
            this.CsDeptCosts = new List<CsDeptCost>();
            this.CsDeptCostParas = new List<CsDeptCostPara>();
            this.CsDeptCostTraces = new List<CsDeptCostTrace>();
            this.CsDeptCostTraces1 = new List<CsDeptCostTrace>();
            this.CsDeptIncomes = new List<CsDeptIncome>();
            this.CsDeptIncomes1 = new List<CsDeptIncome>();
            this.CsIncomeDetails = new List<CsIncomeDetail>();
            this.CsLocServices = new List<CsLocService>();
            this.CsParaDeptsRecs = new List<CsParaDeptsRec>();
            this.CsServerRelations = new List<CsServerRelation>();
            this.CsServerRelations1 = new List<CsServerRelation>();
            this.EqTransfers = new List<EqTransfer>();
            this.EqTransfers1 = new List<EqTransfer>();
            this.Equipments = new List<Equipment>();
            this.Equipments1 = new List<Equipment>();
            this.GblEMRFiles = new List<GblEMRFile>();
            this.InAdviceLongs = new List<InAdviceLong>();
            this.InAdviceTemps = new List<InAdviceTemp>();
            this.InChinRicipes = new List<InChinRicipe>();
            this.InExecutes = new List<InExecute>();
            this.InExecutes1 = new List<InExecute>();
            this.InHosInfoes2 = new List<InHosInfo>();
            this.InInvoiceDtlDumps = new List<InInvoiceDtlDump>();
            this.InInvoiceDtlDumps1 = new List<InInvoiceDtlDump>();
            this.InInvoiceDtlTemps = new List<InInvoiceDtlTemp>();
            this.InInvoiceDtlTemps1 = new List<InInvoiceDtlTemp>();
            this.InLogInHospitals = new List<InLogInHospital>();
            this.InLogOutHospitals = new List<InLogOutHospital>();
            this.InLogOutLocations = new List<InLogOutLocation>();
            this.InLogStatusIns = new List<InLogStatusIn>();
            this.InOpsSums = new List<InOpsSum>();
            this.InOutLocations = new List<InOutLocation>();
            this.InOutLocations1 = new List<InOutLocation>();
            this.RmKsBacks = new List<RmKsBack>();
            this.RmKsOuts = new List<RmKsOut>();
            this.RmLoses = new List<RmLose>();
            this.OuInvoiceDtls = new List<OuInvoiceDtl>();
            this.OuLeadRegs = new List<OuLeadReg>();
            this.OuRecipes = new List<OuRecipe>();
            this.OuHosInfoes = new List<OuHosInfo>();
            this.OuHosInfoes1 = new List<OuHosInfo>();
            this.BsXdRpDtls = new List<BsXdRpDtl>();
            this.BsXdRps1 = new List<BsXdRp>();
            this.NfInfects = new List<NfInfect>();
            this.NrPlans = new List<NrPlan>();
            this.NrPregnancies = new List<NrPregnancy>();
            this.NrRecords = new List<NrRecord>();
            this.OpsApplies = new List<OpsApply>();
            this.OpsMen = new List<OpsMan>();
            this.OuDocRegTypes = new List<OuDocRegType>();
            this.OuRecipeDtls = new List<OuRecipeDtl>();
            this.PsApplyReports = new List<PsApplyReport>();
            this.PsApplyReports1 = new List<PsApplyReport>();
            this.PsDiagDoctors = new List<PsDiagDoctor>();
            this.PsDiagMeetings = new List<PsDiagMeeting>();
            this.PsDrugActions = new List<PsDrugAction>();
            this.BsUsageItems = new List<BsUsageItem>();
            this.BsMzFeeties = new List<BsMzFeety>();
            this.BsUserLocations = new List<BsUserLocation>();
            this.TmpWordDetails = new List<TmpWordDetail>();
            this.TrScheLines = new List<TrScheLine>();
            this.InAdviceLongs1 = new List<InAdviceLong>();
            this.InAdviceTemps1 = new List<InAdviceTemp>();
            this.InDayCharges = new List<InDayCharge>();
            this.InInvoiceDtls = new List<InInvoiceDtl>();
            this.InInvoiceDtls1 = new List<InInvoiceDtl>();
            this.InDrugReqs = new List<InDrugReq>();
            this.InExecutes2 = new List<InExecute>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public short LsInOut { get; set; }
        public bool IsForwomen { get; set; }
        public string PhoneCode { get; set; }
        public decimal MedicineRatio { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<int> SpecialityId { get; set; }
        public Nullable<short> BedSum { get; set; }
        public string BaSysCode { get; set; }
        public string Director { get; set; }
        public Nullable<int> DeptTypeId { get; set; }
        public Nullable<bool> IsCostApp { get; set; }
        public Nullable<short> AppLevel { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public Nullable<int> Area { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
        public Nullable<int> OuRoomId { get; set; }
        public Nullable<int> InRoomId { get; set; }
        public Nullable<bool> IsPriceSub { get; set; }
        public virtual ICollection<BsBed> BsBeds { get; set; }
        public virtual ICollection<BsDiagRoom> BsDiagRooms { get; set; }
        public virtual ICollection<BsDoctor> BsDoctors { get; set; }
        public virtual ICollection<BsExecLocation> BsExecLocations { get; set; }
        public virtual ICollection<BsFixCharge> BsFixCharges { get; set; }
        public virtual BsHospital BsHospital { get; set; }
        public virtual ICollection<BsHsFeety> BsHsFeeties { get; set; }
        public virtual ICollection<BsItem> BsItems { get; set; }
        public virtual ICollection<BsItemAttach> BsItemAttaches { get; set; }
        public virtual ICollection<BsItemLocation> BsItemLocations { get; set; }
        public virtual ICollection<BsItemLocation> BsItemLocations1 { get; set; }
        public virtual ICollection<BsJCGroupAttach> BsJCGroupAttaches { get; set; }
        public virtual ICollection<InHosInfo> InHosInfoes { get; set; }
        public virtual ICollection<InHosInfo> InHosInfoes1 { get; set; }
        public virtual BsSpeciality BsSpeciality { get; set; }
        public virtual CsAppDeptType CsAppDeptType { get; set; }
        public virtual ICollection<BsLocationRoomWindow> BsLocationRoomWindows { get; set; }
        public virtual ICollection<BsLocBranch> BsLocBranches { get; set; }
        public virtual ICollection<BsLocPatType> BsLocPatTypes { get; set; }
        public virtual ICollection<BsUserEmrTemplate> BsUserEmrTemplates { get; set; }
        public virtual ICollection<BsXdGroupDtl> BsXdGroupDtls { get; set; }
        public virtual ICollection<BsXdRp> BsXdRps { get; set; }
        public virtual ICollection<CkBldDonate> CkBldDonates { get; set; }
        public virtual ICollection<CkBldFree> CkBldFrees { get; set; }
        public virtual ICollection<CkBldReaction> CkBldReactions { get; set; }
        public virtual ICollection<CkBldReimb> CkBldReimbs { get; set; }
        public virtual ICollection<CkLab> CkLabs { get; set; }
        public virtual ICollection<CkLab> CkLabs1 { get; set; }
        public virtual ICollection<CkMain> CkMains { get; set; }
        public virtual ICollection<CsBigConsume> CsBigConsumes { get; set; }
        public virtual ICollection<CsCostDetail> CsCostDetails { get; set; }
        public virtual ICollection<CsDeptCost> CsDeptCosts { get; set; }
        public virtual ICollection<CsDeptCostPara> CsDeptCostParas { get; set; }
        public virtual ICollection<CsDeptCostTrace> CsDeptCostTraces { get; set; }
        public virtual ICollection<CsDeptCostTrace> CsDeptCostTraces1 { get; set; }
        public virtual ICollection<CsDeptIncome> CsDeptIncomes { get; set; }
        public virtual ICollection<CsDeptIncome> CsDeptIncomes1 { get; set; }
        public virtual ICollection<CsIncomeDetail> CsIncomeDetails { get; set; }
        public virtual ICollection<CsLocService> CsLocServices { get; set; }
        public virtual ICollection<CsParaDeptsRec> CsParaDeptsRecs { get; set; }
        public virtual ICollection<CsServerRelation> CsServerRelations { get; set; }
        public virtual ICollection<CsServerRelation> CsServerRelations1 { get; set; }
        public virtual ICollection<EqTransfer> EqTransfers { get; set; }
        public virtual ICollection<EqTransfer> EqTransfers1 { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
        public virtual ICollection<Equipment> Equipments1 { get; set; }
        public virtual ICollection<GblEMRFile> GblEMRFiles { get; set; }
        public virtual ICollection<InAdviceLong> InAdviceLongs { get; set; }
        public virtual ICollection<InAdviceTemp> InAdviceTemps { get; set; }
        public virtual ICollection<InChinRicipe> InChinRicipes { get; set; }
        public virtual ICollection<InExecute> InExecutes { get; set; }
        public virtual ICollection<InExecute> InExecutes1 { get; set; }
        public virtual ICollection<InHosInfo> InHosInfoes2 { get; set; }
        public virtual ICollection<InInvoiceDtlDump> InInvoiceDtlDumps { get; set; }
        public virtual ICollection<InInvoiceDtlDump> InInvoiceDtlDumps1 { get; set; }
        public virtual ICollection<InInvoiceDtlTemp> InInvoiceDtlTemps { get; set; }
        public virtual ICollection<InInvoiceDtlTemp> InInvoiceDtlTemps1 { get; set; }
        public virtual ICollection<InLogInHospital> InLogInHospitals { get; set; }
        public virtual ICollection<InLogOutHospital> InLogOutHospitals { get; set; }
        public virtual ICollection<InLogOutLocation> InLogOutLocations { get; set; }
        public virtual ICollection<InLogStatusIn> InLogStatusIns { get; set; }
        public virtual ICollection<InOpsSum> InOpsSums { get; set; }
        public virtual ICollection<InOutLocation> InOutLocations { get; set; }
        public virtual ICollection<InOutLocation> InOutLocations1 { get; set; }
        public virtual ICollection<RmKsBack> RmKsBacks { get; set; }
        public virtual ICollection<RmKsOut> RmKsOuts { get; set; }
        public virtual ICollection<RmLose> RmLoses { get; set; }
        public virtual ICollection<OuInvoiceDtl> OuInvoiceDtls { get; set; }
        public virtual ICollection<OuLeadReg> OuLeadRegs { get; set; }
        public virtual ICollection<OuRecipe> OuRecipes { get; set; }
        public virtual ICollection<OuHosInfo> OuHosInfoes { get; set; }
        public virtual ICollection<OuHosInfo> OuHosInfoes1 { get; set; }
        public virtual ICollection<BsXdRpDtl> BsXdRpDtls { get; set; }
        public virtual ICollection<BsXdRp> BsXdRps1 { get; set; }
        public virtual ICollection<NfInfect> NfInfects { get; set; }
        public virtual ICollection<NrPlan> NrPlans { get; set; }
        public virtual ICollection<NrPregnancy> NrPregnancies { get; set; }
        public virtual ICollection<NrRecord> NrRecords { get; set; }
        public virtual ICollection<OpsApply> OpsApplies { get; set; }
        public virtual ICollection<OpsMan> OpsMen { get; set; }
        public virtual ICollection<OuDocRegType> OuDocRegTypes { get; set; }
        public virtual ICollection<OuRecipeDtl> OuRecipeDtls { get; set; }
        public virtual ICollection<PsApplyReport> PsApplyReports { get; set; }
        public virtual ICollection<PsApplyReport> PsApplyReports1 { get; set; }
        public virtual ICollection<PsDiagDoctor> PsDiagDoctors { get; set; }
        public virtual ICollection<PsDiagMeeting> PsDiagMeetings { get; set; }
        public virtual ICollection<PsDrugAction> PsDrugActions { get; set; }
        public virtual ICollection<BsUsageItem> BsUsageItems { get; set; }
        public virtual ICollection<BsMzFeety> BsMzFeeties { get; set; }
        public virtual ICollection<BsUserLocation> BsUserLocations { get; set; }
        public virtual ICollection<TmpWordDetail> TmpWordDetails { get; set; }
        public virtual ICollection<TrScheLine> TrScheLines { get; set; }
        public virtual ICollection<InAdviceLong> InAdviceLongs1 { get; set; }
        public virtual ICollection<InAdviceTemp> InAdviceTemps1 { get; set; }
        public virtual ICollection<InDayCharge> InDayCharges { get; set; }
        public virtual ICollection<InInvoiceDtl> InInvoiceDtls { get; set; }
        public virtual ICollection<InInvoiceDtl> InInvoiceDtls1 { get; set; }
        public virtual ICollection<InDrugReq> InDrugReqs { get; set; }
        public virtual ICollection<InExecute> InExecutes2 { get; set; }
    }
}
