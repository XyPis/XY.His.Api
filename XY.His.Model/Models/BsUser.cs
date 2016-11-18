using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsUser
    {
        public BsUser()
        {
            this.BsCareGroups = new List<BsCareGroup>();
            this.BsDoctors = new List<BsDoctor>();
            this.BsItemPersons = new List<BsItemPerson>();
            this.BsPatIlls = new List<BsPatIll>();
            this.BsUserEmrTemplates = new List<BsUserEmrTemplate>();
            this.BsUserHouses = new List<BsUserHouse>();
            this.BsUserLocations = new List<BsUserLocation>();
            this.BsUserMenus = new List<BsUserMenu>();
            this.BsUserModules = new List<BsUserModule>();
            this.BsUserPoints = new List<BsUserPoint>();
            this.BsUserPointDtls = new List<BsUserPointDtl>();
            this.BsUserRoles = new List<BsUserRole>();
            this.BsUserRooms = new List<BsUserRoom>();
            this.BsUserWindows = new List<BsUserWindow>();
            this.BsUserWords = new List<BsUserWord>();
            this.BsXdGroupDtls = new List<BsXdGroupDtl>();
            this.BsXdRps = new List<BsXdRp>();
            this.CkCompGroupPsApplies = new List<CkCompGroupPsApply>();
            this.CkLabs = new List<CkLab>();
            this.CkLabs1 = new List<CkLab>();
            this.CkLabDtls = new List<CkLabDtl>();
            this.CKMachineSamples = new List<CKMachineSample>();
            this.CkMains = new List<CkMain>();
            this.CkQcResults = new List<CkQcResult>();
            this.CkReports = new List<CkReport>();
            this.CkLabResults = new List<CkLabResult>();
            this.CsDeptIncomes = new List<CsDeptIncome>();
            this.CsOuWorkLogs = new List<CsOuWorkLog>();
            this.ElEhrs = new List<ElEhr>();
            this.ElEhrs1 = new List<ElEhr>();
            this.ElPatForms = new List<ElPatForm>();
            this.EqChecks = new List<EqCheck>();
            this.EqRepairs = new List<EqRepair>();
            this.EqTransfers = new List<EqTransfer>();
            this.Equipments = new List<Equipment>();
            this.FtMains = new List<FtMain>();
            this.GblCurrentUsers = new List<GblCurrentUser>();
            this.GblEmails = new List<GblEmail>();
            this.GblEmailUsers = new List<GblEmailUser>();
            this.GblInvRegs = new List<GblInvReg>();
            this.GblPhoneMsgs = new List<GblPhoneMsg>();
            this.InAdviceLongs = new List<InAdviceLong>();
            this.InAdviceLongs1 = new List<InAdviceLong>();
            this.InAdviceLongs2 = new List<InAdviceLong>();
            this.InAdviceLongs3 = new List<InAdviceLong>();
            this.InAdviceTemps = new List<InAdviceTemp>();
            this.InAdviceTemps1 = new List<InAdviceTemp>();
            this.InAdviceTemps2 = new List<InAdviceTemp>();
            this.InAdviceTemps3 = new List<InAdviceTemp>();
            this.InAdviceTemps4 = new List<InAdviceTemp>();
            this.InArrearAmounts = new List<InArrearAmount>();
            this.InBodyHeats = new List<InBodyHeat>();
            this.InDeposits = new List<InDeposit>();
            this.InDeposits1 = new List<InDeposit>();
            this.InEMRs = new List<InEMR>();
            this.InEMRs1 = new List<InEMR>();
            this.InExecutes = new List<InExecute>();
            this.InHosOps = new List<InHosOp>();
            this.InHosOps1 = new List<InHosOp>();
            this.InInvoices = new List<InInvoice>();
            this.InInvoices1 = new List<InInvoice>();
            this.InOpsSums = new List<InOpsSum>();
            this.InOutLocations = new List<InOutLocation>();
            this.InOutLocations1 = new List<InOutLocation>();
            this.InRecFirstPages = new List<InRecFirstPage>();
            this.InRecFirstPages1 = new List<InRecFirstPage>();
            this.InRecFirstPages2 = new List<InRecFirstPage>();
            this.InRecFirstPages3 = new List<InRecFirstPage>();
            this.NfInfects = new List<NfInfect>();
            this.OaSchedules = new List<OaSchedule>();
            this.OpsApplies = new List<OpsApply>();
            this.OpsMen = new List<OpsMan>();
            this.OtBidDtls = new List<OtBidDtl>();
            this.OuExecuteBacks = new List<OuExecuteBack>();
            this.OuInCars = new List<OuInCar>();
            this.OuInCars1 = new List<OuInCar>();
            this.OuInvoices = new List<OuInvoice>();
            this.OuLeadRegs = new List<OuLeadReg>();
            this.OuTransferHosps = new List<OuTransferHosp>();
            this.OuTransferHosps1 = new List<OuTransferHosp>();
            this.PlProjects = new List<PlProject>();
            this.PsApplyReports = new List<PsApplyReport>();
            this.PsApplyReports1 = new List<PsApplyReport>();
            this.PsApplyReports2 = new List<PsApplyReport>();
            this.PsApplyReports3 = new List<PsApplyReport>();
            this.PsApplyReports4 = new List<PsApplyReport>();
            this.PsDrugActions = new List<PsDrugAction>();
            this.PsDrugActions1 = new List<PsDrugAction>();
            this.RdContracts = new List<RdContract>();
            this.RdCurePlans = new List<RdCurePlan>();
            this.RdFollows = new List<RdFollow>();
            this.ElInoculates = new List<ElInoculate>();
            this.ElInoculates1 = new List<ElInoculate>();
            this.RdNewBirths = new List<RdNewBirth>();
            this.RmMoves = new List<RmMove>();
            this.RmMoves1 = new List<RmMove>();
            this.RmSendings = new List<RmSending>();
            this.TmpEmrs = new List<TmpEmr>();
            this.TmpItems = new List<TmpItem>();
            this.TmpWordDetails = new List<TmpWordDetail>();
            this.TrSchedulers = new List<TrScheduler>();
            this.TrSchedulers1 = new List<TrScheduler>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public bool IsActive { get; set; }
        public string Reason { get; set; }
        public short LsInputWay { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<bool> IsUserInputWB { get; set; }
        public Nullable<bool> IsUserInputPY { get; set; }
        public Nullable<bool> IsUserInputCode { get; set; }
        public Nullable<bool> IsUserInputName { get; set; }
        public Nullable<bool> IsUserInputStrokeCode { get; set; }
        public Nullable<bool> IsUserInputEngDesc { get; set; }
        public string Introduce { get; set; }
        public string PicturePath { get; set; }
        public string Address { get; set; }
        public string Mobile { get; set; }
        public Nullable<int> LevelId { get; set; }
        public Nullable<int> DocLevId { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<int> CareGroupId { get; set; }
        public Nullable<int> CareGroupId1 { get; set; }
        public string F5 { get; set; }
        public string CertIdNo { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public Nullable<bool> IsUserInputF1 { get; set; }
        public virtual ICollection<BsCareGroup> BsCareGroups { get; set; }
        public virtual BsCareGroup BsCareGroup { get; set; }
        public virtual BsDocLevel BsDocLevel { get; set; }
        public virtual ICollection<BsDoctor> BsDoctors { get; set; }
        public virtual BsEduLevel BsEduLevel { get; set; }
        public virtual BsHospital BsHospital { get; set; }
        public virtual ICollection<BsItemPerson> BsItemPersons { get; set; }
        public virtual ICollection<BsPatIll> BsPatIlls { get; set; }
        public virtual ICollection<BsUserEmrTemplate> BsUserEmrTemplates { get; set; }
        public virtual ICollection<BsUserHouse> BsUserHouses { get; set; }
        public virtual ICollection<BsUserLocation> BsUserLocations { get; set; }
        public virtual ICollection<BsUserMenu> BsUserMenus { get; set; }
        public virtual ICollection<BsUserModule> BsUserModules { get; set; }
        public virtual ICollection<BsUserPoint> BsUserPoints { get; set; }
        public virtual ICollection<BsUserPointDtl> BsUserPointDtls { get; set; }
        public virtual ICollection<BsUserRole> BsUserRoles { get; set; }
        public virtual ICollection<BsUserRoom> BsUserRooms { get; set; }
        public virtual ICollection<BsUserWindow> BsUserWindows { get; set; }
        public virtual ICollection<BsUserWord> BsUserWords { get; set; }
        public virtual ICollection<BsXdGroupDtl> BsXdGroupDtls { get; set; }
        public virtual ICollection<BsXdRp> BsXdRps { get; set; }
        public virtual ICollection<CkCompGroupPsApply> CkCompGroupPsApplies { get; set; }
        public virtual ICollection<CkLab> CkLabs { get; set; }
        public virtual ICollection<CkLab> CkLabs1 { get; set; }
        public virtual ICollection<CkLabDtl> CkLabDtls { get; set; }
        public virtual ICollection<CKMachineSample> CKMachineSamples { get; set; }
        public virtual ICollection<CkMain> CkMains { get; set; }
        public virtual ICollection<CkQcResult> CkQcResults { get; set; }
        public virtual ICollection<CkReport> CkReports { get; set; }
        public virtual ICollection<CkLabResult> CkLabResults { get; set; }
        public virtual ICollection<CsDeptIncome> CsDeptIncomes { get; set; }
        public virtual ICollection<CsOuWorkLog> CsOuWorkLogs { get; set; }
        public virtual ICollection<ElEhr> ElEhrs { get; set; }
        public virtual ICollection<ElEhr> ElEhrs1 { get; set; }
        public virtual ICollection<ElPatForm> ElPatForms { get; set; }
        public virtual ICollection<EqCheck> EqChecks { get; set; }
        public virtual ICollection<EqRepair> EqRepairs { get; set; }
        public virtual ICollection<EqTransfer> EqTransfers { get; set; }
        public virtual ICollection<Equipment> Equipments { get; set; }
        public virtual ICollection<FtMain> FtMains { get; set; }
        public virtual ICollection<GblCurrentUser> GblCurrentUsers { get; set; }
        public virtual ICollection<GblEmail> GblEmails { get; set; }
        public virtual ICollection<GblEmailUser> GblEmailUsers { get; set; }
        public virtual ICollection<GblInvReg> GblInvRegs { get; set; }
        public virtual ICollection<GblPhoneMsg> GblPhoneMsgs { get; set; }
        public virtual ICollection<InAdviceLong> InAdviceLongs { get; set; }
        public virtual ICollection<InAdviceLong> InAdviceLongs1 { get; set; }
        public virtual ICollection<InAdviceLong> InAdviceLongs2 { get; set; }
        public virtual ICollection<InAdviceLong> InAdviceLongs3 { get; set; }
        public virtual ICollection<InAdviceTemp> InAdviceTemps { get; set; }
        public virtual ICollection<InAdviceTemp> InAdviceTemps1 { get; set; }
        public virtual ICollection<InAdviceTemp> InAdviceTemps2 { get; set; }
        public virtual ICollection<InAdviceTemp> InAdviceTemps3 { get; set; }
        public virtual ICollection<InAdviceTemp> InAdviceTemps4 { get; set; }
        public virtual ICollection<InArrearAmount> InArrearAmounts { get; set; }
        public virtual ICollection<InBodyHeat> InBodyHeats { get; set; }
        public virtual ICollection<InDeposit> InDeposits { get; set; }
        public virtual ICollection<InDeposit> InDeposits1 { get; set; }
        public virtual ICollection<InEMR> InEMRs { get; set; }
        public virtual ICollection<InEMR> InEMRs1 { get; set; }
        public virtual ICollection<InExecute> InExecutes { get; set; }
        public virtual ICollection<InHosOp> InHosOps { get; set; }
        public virtual ICollection<InHosOp> InHosOps1 { get; set; }
        public virtual ICollection<InInvoice> InInvoices { get; set; }
        public virtual ICollection<InInvoice> InInvoices1 { get; set; }
        public virtual ICollection<InOpsSum> InOpsSums { get; set; }
        public virtual ICollection<InOutLocation> InOutLocations { get; set; }
        public virtual ICollection<InOutLocation> InOutLocations1 { get; set; }
        public virtual ICollection<InRecFirstPage> InRecFirstPages { get; set; }
        public virtual ICollection<InRecFirstPage> InRecFirstPages1 { get; set; }
        public virtual ICollection<InRecFirstPage> InRecFirstPages2 { get; set; }
        public virtual ICollection<InRecFirstPage> InRecFirstPages3 { get; set; }
        public virtual ICollection<NfInfect> NfInfects { get; set; }
        public virtual ICollection<OaSchedule> OaSchedules { get; set; }
        public virtual ICollection<OpsApply> OpsApplies { get; set; }
        public virtual ICollection<OpsMan> OpsMen { get; set; }
        public virtual ICollection<OtBidDtl> OtBidDtls { get; set; }
        public virtual ICollection<OuExecuteBack> OuExecuteBacks { get; set; }
        public virtual ICollection<OuInCar> OuInCars { get; set; }
        public virtual ICollection<OuInCar> OuInCars1 { get; set; }
        public virtual ICollection<OuInvoice> OuInvoices { get; set; }
        public virtual ICollection<OuLeadReg> OuLeadRegs { get; set; }
        public virtual ICollection<OuTransferHosp> OuTransferHosps { get; set; }
        public virtual ICollection<OuTransferHosp> OuTransferHosps1 { get; set; }
        public virtual ICollection<PlProject> PlProjects { get; set; }
        public virtual ICollection<PsApplyReport> PsApplyReports { get; set; }
        public virtual ICollection<PsApplyReport> PsApplyReports1 { get; set; }
        public virtual ICollection<PsApplyReport> PsApplyReports2 { get; set; }
        public virtual ICollection<PsApplyReport> PsApplyReports3 { get; set; }
        public virtual ICollection<PsApplyReport> PsApplyReports4 { get; set; }
        public virtual ICollection<PsDrugAction> PsDrugActions { get; set; }
        public virtual ICollection<PsDrugAction> PsDrugActions1 { get; set; }
        public virtual ICollection<RdContract> RdContracts { get; set; }
        public virtual ICollection<RdCurePlan> RdCurePlans { get; set; }
        public virtual ICollection<RdFollow> RdFollows { get; set; }
        public virtual ICollection<ElInoculate> ElInoculates { get; set; }
        public virtual ICollection<ElInoculate> ElInoculates1 { get; set; }
        public virtual ICollection<RdNewBirth> RdNewBirths { get; set; }
        public virtual ICollection<RmMove> RmMoves { get; set; }
        public virtual ICollection<RmMove> RmMoves1 { get; set; }
        public virtual ICollection<RmSending> RmSendings { get; set; }
        public virtual ICollection<TmpEmr> TmpEmrs { get; set; }
        public virtual ICollection<TmpItem> TmpItems { get; set; }
        public virtual ICollection<TmpWordDetail> TmpWordDetails { get; set; }
        public virtual ICollection<TrScheduler> TrSchedulers { get; set; }
        public virtual ICollection<TrScheduler> TrSchedulers1 { get; set; }
    }
}
