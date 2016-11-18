using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsDoctor
    {
        public BsDoctor()
        {
            this.BsCareGroups = new List<BsCareGroup>();
            this.InHosInfoes = new List<InHosInfo>();
            this.InHosInfoes1 = new List<InHosInfo>();
            this.BsDoctor1 = new List<BsDoctor>();
            this.CkBldReactions = new List<CkBldReaction>();
            this.CkLabs = new List<CkLab>();
            this.CkMains = new List<CkMain>();
            this.InExecutes = new List<InExecute>();
            this.InHosOps = new List<InHosOp>();
            this.InHosOps1 = new List<InHosOp>();
            this.InInvoiceDtlDumps = new List<InInvoiceDtlDump>();
            this.InInvoiceDtlTemps = new List<InInvoiceDtlTemp>();
            this.InRecFirstPages = new List<InRecFirstPage>();
            this.InRecFirstPages1 = new List<InRecFirstPage>();
            this.InRecFirstPages2 = new List<InRecFirstPage>();
            this.OuInvoiceDtls = new List<OuInvoiceDtl>();
            this.OuLeadRegs = new List<OuLeadReg>();
            this.OuRecipes = new List<OuRecipe>();
            this.OuHosInfoes = new List<OuHosInfo>();
            this.NfInfects = new List<NfInfect>();
            this.OpsApplies = new List<OpsApply>();
            this.OuDiagCalls = new List<OuDiagCall>();
            this.OuDocRegTypes = new List<OuDocRegType>();
            this.OuInCars = new List<OuInCar>();
            this.OuRecipeDtls = new List<OuRecipeDtl>();
            this.PsApplyReports = new List<PsApplyReport>();
            this.PsDiagDoctors = new List<PsDiagDoctor>();
            this.PsDiagMeetings = new List<PsDiagMeeting>();
            this.PsDrugActions = new List<PsDrugAction>();
            this.RdCurePlans = new List<RdCurePlan>();
            this.RdFollows = new List<RdFollow>();
            this.TmpMyPats = new List<TmpMyPat>();
            this.TrDoctorEmrs = new List<TrDoctorEmr>();
            this.InAdviceLongs = new List<InAdviceLong>();
            this.InAdviceLongs1 = new List<InAdviceLong>();
            this.InAdviceTemps = new List<InAdviceTemp>();
            this.InChangeBeds = new List<InChangeBed>();
            this.InChinRicipes = new List<InChinRicipe>();
            this.InInvoiceDtls = new List<InInvoiceDtl>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public Nullable<int> LevelId { get; set; }
        public Nullable<int> DocLevId { get; set; }
        public string Introduce { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> RegTypeId { get; set; }
        public string PicturePath { get; set; }
        public short LsStatus { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<int> UserId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public Nullable<int> SupDoctorId { get; set; }
        public Nullable<int> DiagRoomID { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public virtual ICollection<BsCareGroup> BsCareGroups { get; set; }
        public virtual BsDocLevel BsDocLevel { get; set; }
        public virtual ICollection<InHosInfo> InHosInfoes { get; set; }
        public virtual ICollection<InHosInfo> InHosInfoes1 { get; set; }
        public virtual ICollection<BsDoctor> BsDoctor1 { get; set; }
        public virtual BsDoctor BsDoctor2 { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual ICollection<CkBldReaction> CkBldReactions { get; set; }
        public virtual ICollection<CkLab> CkLabs { get; set; }
        public virtual ICollection<CkMain> CkMains { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsRegType BsRegType { get; set; }
        public virtual BsEduLevel BsEduLevel { get; set; }
        public virtual ICollection<InExecute> InExecutes { get; set; }
        public virtual ICollection<InHosOp> InHosOps { get; set; }
        public virtual ICollection<InHosOp> InHosOps1 { get; set; }
        public virtual ICollection<InInvoiceDtlDump> InInvoiceDtlDumps { get; set; }
        public virtual ICollection<InInvoiceDtlTemp> InInvoiceDtlTemps { get; set; }
        public virtual ICollection<InRecFirstPage> InRecFirstPages { get; set; }
        public virtual ICollection<InRecFirstPage> InRecFirstPages1 { get; set; }
        public virtual ICollection<InRecFirstPage> InRecFirstPages2 { get; set; }
        public virtual ICollection<OuInvoiceDtl> OuInvoiceDtls { get; set; }
        public virtual ICollection<OuLeadReg> OuLeadRegs { get; set; }
        public virtual ICollection<OuRecipe> OuRecipes { get; set; }
        public virtual ICollection<OuHosInfo> OuHosInfoes { get; set; }
        public virtual ICollection<NfInfect> NfInfects { get; set; }
        public virtual ICollection<OpsApply> OpsApplies { get; set; }
        public virtual ICollection<OuDiagCall> OuDiagCalls { get; set; }
        public virtual ICollection<OuDocRegType> OuDocRegTypes { get; set; }
        public virtual ICollection<OuInCar> OuInCars { get; set; }
        public virtual ICollection<OuRecipeDtl> OuRecipeDtls { get; set; }
        public virtual ICollection<PsApplyReport> PsApplyReports { get; set; }
        public virtual ICollection<PsDiagDoctor> PsDiagDoctors { get; set; }
        public virtual ICollection<PsDiagMeeting> PsDiagMeetings { get; set; }
        public virtual ICollection<PsDrugAction> PsDrugActions { get; set; }
        public virtual ICollection<RdCurePlan> RdCurePlans { get; set; }
        public virtual ICollection<RdFollow> RdFollows { get; set; }
        public virtual ICollection<TmpMyPat> TmpMyPats { get; set; }
        public virtual ICollection<TrDoctorEmr> TrDoctorEmrs { get; set; }
        public virtual ICollection<InAdviceLong> InAdviceLongs { get; set; }
        public virtual ICollection<InAdviceLong> InAdviceLongs1 { get; set; }
        public virtual ICollection<InAdviceTemp> InAdviceTemps { get; set; }
        public virtual ICollection<InChangeBed> InChangeBeds { get; set; }
        public virtual ICollection<InChinRicipe> InChinRicipes { get; set; }
        public virtual ICollection<InInvoiceDtl> InInvoiceDtls { get; set; }
    }
}
