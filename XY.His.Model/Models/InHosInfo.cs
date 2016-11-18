using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InHosInfo
    {
        public InHosInfo()
        {
            this.BsPatientYBIlls = new List<BsPatientYBIll>();
            this.CkBldApplies = new List<CkBldApply>();
            this.CkBldDonates = new List<CkBldDonate>();
            this.CkBldFrees = new List<CkBldFree>();
            this.CkBldReactions = new List<CkBldReaction>();
            this.CkBldReimbs = new List<CkBldReimb>();
            this.CkLabs = new List<CkLab>();
            this.InAdviceGroups = new List<InAdviceGroup>();
            this.InAdviceLongs = new List<InAdviceLong>();
            this.INADVICENURSEs = new List<INADVICENURSE>();
            this.InAdviceTemps = new List<InAdviceTemp>();
            this.InArrearAmounts = new List<InArrearAmount>();
            this.InBodyHeats = new List<InBodyHeat>();
            this.InCallBacks = new List<InCallBack>();
            this.InChangeBeds = new List<InChangeBed>();
            this.InChinRicipes = new List<InChinRicipe>();
            this.InDayAdds = new List<InDayAdd>();
            this.InDaySums = new List<InDaySum>();
            this.InDeposits = new List<InDeposit>();
            this.InDrugReqdtls = new List<InDrugReqdtl>();
            this.InEMRs = new List<InEMR>();
            this.InEmrRtfs = new List<InEmrRtf>();
            this.InEmrXmls = new List<InEmrXml>();
            this.InExecutes = new List<InExecute>();
            this.InHosBeds = new List<InHosBed>();
            this.InHosMzIlls = new List<InHosMzIll>();
            this.InHosMzIlls1 = new List<InHosMzIll>();
            this.InHosInfo1 = new List<InHosInfo>();
            this.InHosOps = new List<InHosOp>();
            this.InLogInHospitals = new List<InLogInHospital>();
            this.InLogOutHospitals = new List<InLogOutHospital>();
            this.InLogOutLocations = new List<InLogOutLocation>();
            this.InLogStatusIns = new List<InLogStatusIn>();
            this.InNotAttaches = new List<InNotAttach>();
            this.InOutLocations = new List<InOutLocation>();
            this.InPatFeesLists = new List<InPatFeesList>();
            this.InRecFirstPages = new List<InRecFirstPage>();
            this.InRecFirstPages1 = new List<InRecFirstPage>();
            this.NfInfects = new List<NfInfect>();
            this.NrPlans = new List<NrPlan>();
            this.NrPregnancies = new List<NrPregnancy>();
            this.NrRecords = new List<NrRecord>();
            this.OpsApplies = new List<OpsApply>();
            this.OuInCars = new List<OuInCar>();
            this.OuTransferHosps = new List<OuTransferHosp>();
            this.PsApplyReports = new List<PsApplyReport>();
            this.PsDiagMeetings = new List<PsDiagMeeting>();
            this.PsDrugActions = new List<PsDrugAction>();
            this.RdNewBirths = new List<RdNewBirth>();
            this.YbPatSeqs = new List<YbPatSeq>();
            this.InInvoiceDtlDumps = new List<InInvoiceDtlDump>();
            this.InInvoiceDtlTemps = new List<InInvoiceDtlTemp>();
            this.InPays = new List<InPay>();
            this.InInvoices = new List<InInvoice>();
            this.InInvoiceDtls = new List<InInvoiceDtl>();
        }

        public int ID { get; set; }
        public string HospNo { get; set; }
        public int PatID { get; set; }
        public string InPatNo { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public int NTime { get; set; }
        public System.DateTime InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public short LsMarriage { get; set; }
        public string BloodGroup { get; set; }
        public string XNo { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string Residence { get; set; }
        public string City { get; set; }
        public string Province { get; set; }
        public bool IsOversea { get; set; }
        public Nullable<System.DateTime> PassTime { get; set; }
        public string IdCardNo { get; set; }
        public string Company { get; set; }
        public string Occupation { get; set; }
        public Nullable<int> WorktypeId { get; set; }
        public int PatTypeId { get; set; }
        public Nullable<int> CertificateId { get; set; }
        public short LsInType { get; set; }
        public short LsInWay { get; set; }
        public short LsInIllness { get; set; }
        public Nullable<int> DocMz { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public int LocIn { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> BedId { get; set; }
        public bool IsYbMt { get; set; }
        public string YbRegNo { get; set; }
        public Nullable<decimal> ArrearAmount { get; set; }
        public bool IsBaby { get; set; }
        public Nullable<short> AgeDay { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public string PhoneHome { get; set; }
        public string AddressHome { get; set; }
        public string PostCodeHome { get; set; }
        public string AreaCodeHome { get; set; }
        public string PhoneWork { get; set; }
        public string AddressWork { get; set; }
        public string PostCodeWork { get; set; }
        public string AreaCodeWork { get; set; }
        public string LinkmanName { get; set; }
        public Nullable<int> RelationId { get; set; }
        public string LinkmanPhone { get; set; }
        public string LinkmanAddress { get; set; }
        public string LinkmanPost { get; set; }
        public string LinkmanArea { get; set; }
        public short LsInStatus { get; set; }
        public Nullable<System.DateTime> LeaveTime { get; set; }
        public string Status { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public bool IsEndChg { get; set; }
        public Nullable<int> EndChgOperID { get; set; }
        public Nullable<System.DateTime> EndchgoperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Memo { get; set; }
        public Nullable<int> MotherHospId { get; set; }
        public Nullable<int> FromHospitalId { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> LocOut { get; set; }
        public string TipsNurse { get; set; }
        public string TipsBalance { get; set; }
        public string TipsOther { get; set; }
        public string OtherRoles { get; set; }
        public Nullable<bool> IsIllegal { get; set; }
        public Nullable<decimal> UnLines { get; set; }
        public Nullable<decimal> Scale { get; set; }
        public string FromHospital { get; set; }
        public Nullable<int> NUMBER1 { get; set; }
        public Nullable<int> NUMBER2 { get; set; }
        public Nullable<int> NUMBER3 { get; set; }
        public Nullable<int> NUMBER4 { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
        public string YBBZCode { get; set; }
        public virtual BsBed BsBed { get; set; }
        public virtual BsCertificate BsCertificate { get; set; }
        public virtual BsCountry BsCountry { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsDoctor BsDoctor1 { get; set; }
        public virtual BsFromHospital BsFromHospital { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsLocation BsLocation1 { get; set; }
        public virtual BsLocation BsLocation2 { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual ICollection<BsPatientYBIll> BsPatientYBIlls { get; set; }
        public virtual BsPatType BsPatType { get; set; }
        public virtual BsRelation BsRelation { get; set; }
        public virtual BsWorkType BsWorkType { get; set; }
        public virtual ICollection<CkBldApply> CkBldApplies { get; set; }
        public virtual ICollection<CkBldDonate> CkBldDonates { get; set; }
        public virtual ICollection<CkBldFree> CkBldFrees { get; set; }
        public virtual ICollection<CkBldReaction> CkBldReactions { get; set; }
        public virtual ICollection<CkBldReimb> CkBldReimbs { get; set; }
        public virtual ICollection<CkLab> CkLabs { get; set; }
        public virtual ICollection<InAdviceGroup> InAdviceGroups { get; set; }
        public virtual ICollection<InAdviceLong> InAdviceLongs { get; set; }
        public virtual ICollection<INADVICENURSE> INADVICENURSEs { get; set; }
        public virtual ICollection<InAdviceTemp> InAdviceTemps { get; set; }
        public virtual ICollection<InArrearAmount> InArrearAmounts { get; set; }
        public virtual ICollection<InBodyHeat> InBodyHeats { get; set; }
        public virtual ICollection<InCallBack> InCallBacks { get; set; }
        public virtual ICollection<InChangeBed> InChangeBeds { get; set; }
        public virtual ICollection<InChinRicipe> InChinRicipes { get; set; }
        public virtual ICollection<InDayAdd> InDayAdds { get; set; }
        public virtual ICollection<InDaySum> InDaySums { get; set; }
        public virtual ICollection<InDeposit> InDeposits { get; set; }
        public virtual ICollection<InDrugReqdtl> InDrugReqdtls { get; set; }
        public virtual ICollection<InEMR> InEMRs { get; set; }
        public virtual ICollection<InEmrRtf> InEmrRtfs { get; set; }
        public virtual ICollection<InEmrXml> InEmrXmls { get; set; }
        public virtual ICollection<InExecute> InExecutes { get; set; }
        public virtual ICollection<InHosBed> InHosBeds { get; set; }
        public virtual ICollection<InHosMzIll> InHosMzIlls { get; set; }
        public virtual ICollection<InHosMzIll> InHosMzIlls1 { get; set; }
        public virtual ICollection<InHosInfo> InHosInfo1 { get; set; }
        public virtual InHosInfo InHosInfo2 { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
        public virtual ICollection<InHosOp> InHosOps { get; set; }
        public virtual ICollection<InLogInHospital> InLogInHospitals { get; set; }
        public virtual ICollection<InLogOutHospital> InLogOutHospitals { get; set; }
        public virtual ICollection<InLogOutLocation> InLogOutLocations { get; set; }
        public virtual ICollection<InLogStatusIn> InLogStatusIns { get; set; }
        public virtual ICollection<InNotAttach> InNotAttaches { get; set; }
        public virtual ICollection<InOutLocation> InOutLocations { get; set; }
        public virtual ICollection<InPatFeesList> InPatFeesLists { get; set; }
        public virtual ICollection<InRecFirstPage> InRecFirstPages { get; set; }
        public virtual ICollection<InRecFirstPage> InRecFirstPages1 { get; set; }
        public virtual ICollection<NfInfect> NfInfects { get; set; }
        public virtual ICollection<NrPlan> NrPlans { get; set; }
        public virtual ICollection<NrPregnancy> NrPregnancies { get; set; }
        public virtual ICollection<NrRecord> NrRecords { get; set; }
        public virtual ICollection<OpsApply> OpsApplies { get; set; }
        public virtual ICollection<OuInCar> OuInCars { get; set; }
        public virtual ICollection<OuTransferHosp> OuTransferHosps { get; set; }
        public virtual ICollection<PsApplyReport> PsApplyReports { get; set; }
        public virtual ICollection<PsDiagMeeting> PsDiagMeetings { get; set; }
        public virtual ICollection<PsDrugAction> PsDrugActions { get; set; }
        public virtual ICollection<RdNewBirth> RdNewBirths { get; set; }
        public virtual ICollection<YbPatSeq> YbPatSeqs { get; set; }
        public virtual ICollection<InInvoiceDtlDump> InInvoiceDtlDumps { get; set; }
        public virtual ICollection<InInvoiceDtlTemp> InInvoiceDtlTemps { get; set; }
        public virtual ICollection<InPay> InPays { get; set; }
        public virtual ICollection<InInvoice> InInvoices { get; set; }
        public virtual ICollection<InInvoiceDtl> InInvoiceDtls { get; set; }
    }
}
