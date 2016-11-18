using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuHosInfo
    {
        public OuHosInfo()
        {
            this.BsPatientYBIlls = new List<BsPatientYBIll>();
            this.CkLabs = new List<CkLab>();
            this.InHosInfoes = new List<InHosInfo>();
            this.NrRecords = new List<NrRecord>();
            this.OpsApplies = new List<OpsApply>();
            this.OuClincDiags = new List<OuClincDiag>();
            this.OuClinicFirsts = new List<OuClinicFirst>();
            this.OuDiagCalls = new List<OuDiagCall>();
            this.OuExecutes = new List<OuExecute>();
            this.OuLeadRegs = new List<OuLeadReg>();
            this.OuInvoices = new List<OuInvoice>();
            this.OuRecipes = new List<OuRecipe>();
            this.OulInvoiceRegs = new List<OulInvoiceReg>();
            this.OuIllReports = new List<OuIllReport>();
            this.OuInCars = new List<OuInCar>();
            this.OuNotAttaches = new List<OuNotAttach>();
            this.OuTransferHosps = new List<OuTransferHosp>();
            this.PsApplyReports = new List<PsApplyReport>();
            this.PsDrugActions = new List<PsDrugAction>();
            this.RdBrainDeads = new List<RdBrainDead>();
            this.RdCancers = new List<RdCancer>();
            this.RdHurts = new List<RdHurt>();
            this.RdInfectious = new List<RdInfectiou>();
            this.RdInfectStds = new List<RdInfectStd>();
            this.RdLivers = new List<RdLiver>();
            this.YbPatSeqs = new List<YbPatSeq>();
        }

        public int ID { get; set; }
        public string MzRegNo { get; set; }
        public System.DateTime RegTime { get; set; }
        public int PatId { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public bool IsBaby { get; set; }
        public Nullable<short> AgeDay { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public int PatTypeId { get; set; }
        public string MedicareNo { get; set; }
        public int RegTypeId { get; set; }
        public bool IsPriority { get; set; }
        public bool IsElder { get; set; }
        public int LineOrder { get; set; }
        public decimal RegFee { get; set; }
        public decimal ZyFee { get; set; }
        public decimal DiagnoFee { get; set; }
        public decimal OtherFee1 { get; set; }
        public decimal OtherFee2 { get; set; }
        public decimal PaySel { get; set; }
        public decimal TallyDiag { get; set; }
        public decimal FactGet { get; set; }
        public int RegDept { get; set; }
        public Nullable<int> DiagnDept { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string RoomNo { get; set; }
        public bool IsFreeDiag { get; set; }
        public bool IsFreeReg { get; set; }
        public bool IsInPatient { get; set; }
        public bool IsPreReg { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public Nullable<System.DateTime> CancelTime { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public string CancelMemo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> TimeSpanId { get; set; }
        public string RegDate { get; set; }
        public Nullable<byte> Age { get; set; }
        public string AgeString { get; set; }
        public string ContactPhone { get; set; }
        public string LinkmanName { get; set; }
        public Nullable<System.DateTime> TallyTime { get; set; }
        public Nullable<System.DateTime> CancelTallyTime { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
        public Nullable<int> TimeSpanSubId { get; set; }
        public Nullable<int> DiagRoomId { get; set; }
        public Nullable<int> CallDoctorId { get; set; }
        public Nullable<int> CallOrder { get; set; }
        public Nullable<bool> IsFirstCheck { get; set; }
        public Nullable<bool> IsGoodRecipe { get; set; }
        public string GoodRecipe { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsLocation BsLocation1 { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual ICollection<BsPatientYBIll> BsPatientYBIlls { get; set; }
        public virtual BsPatType BsPatType { get; set; }
        public virtual BsRegSpanSub BsRegSpanSub { get; set; }
        public virtual BsRegTimeSpan BsRegTimeSpan { get; set; }
        public virtual BsRegType BsRegType { get; set; }
        public virtual ICollection<CkLab> CkLabs { get; set; }
        public virtual ICollection<InHosInfo> InHosInfoes { get; set; }
        public virtual ICollection<NrRecord> NrRecords { get; set; }
        public virtual ICollection<OpsApply> OpsApplies { get; set; }
        public virtual ICollection<OuClincDiag> OuClincDiags { get; set; }
        public virtual ICollection<OuClinicFirst> OuClinicFirsts { get; set; }
        public virtual ICollection<OuDiagCall> OuDiagCalls { get; set; }
        public virtual ICollection<OuExecute> OuExecutes { get; set; }
        public virtual ICollection<OuLeadReg> OuLeadRegs { get; set; }
        public virtual ICollection<OuInvoice> OuInvoices { get; set; }
        public virtual ICollection<OuRecipe> OuRecipes { get; set; }
        public virtual ICollection<OulInvoiceReg> OulInvoiceRegs { get; set; }
        public virtual ICollection<OuIllReport> OuIllReports { get; set; }
        public virtual ICollection<OuInCar> OuInCars { get; set; }
        public virtual ICollection<OuNotAttach> OuNotAttaches { get; set; }
        public virtual ICollection<OuTransferHosp> OuTransferHosps { get; set; }
        public virtual ICollection<PsApplyReport> PsApplyReports { get; set; }
        public virtual ICollection<PsDrugAction> PsDrugActions { get; set; }
        public virtual ICollection<RdBrainDead> RdBrainDeads { get; set; }
        public virtual ICollection<RdCancer> RdCancers { get; set; }
        public virtual ICollection<RdHurt> RdHurts { get; set; }
        public virtual ICollection<RdInfectiou> RdInfectious { get; set; }
        public virtual ICollection<RdInfectStd> RdInfectStds { get; set; }
        public virtual ICollection<RdLiver> RdLivers { get; set; }
        public virtual ICollection<YbPatSeq> YbPatSeqs { get; set; }
    }
}
