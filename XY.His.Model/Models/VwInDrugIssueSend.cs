using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInDrugIssueSend
    {
        public int ID { get; set; }
        public string BedName { get; set; }
        public string HospNo { get; set; }
        public string PatientName { get; set; }
        public int NTime { get; set; }
        public short GroupNum { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Spec { get; set; }
        public decimal Dosage { get; set; }
        public short LsMarkType { get; set; }
        public decimal Totality { get; set; }
        public decimal PriceIn { get; set; }
        public int HospId { get; set; }
        public int RequestId { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int ItemId { get; set; }
        public int UnitReq { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> DetailId { get; set; }
        public Nullable<int> SpecialityId { get; set; }
        public Nullable<System.DateTime> ConfirmOperTime { get; set; }
        public Nullable<int> ConfirmOperId { get; set; }
        public bool IsConfirm { get; set; }
        public bool IsIssued { get; set; }
        public bool IsPrint { get; set; }
        public Nullable<int> UnitTake { get; set; }
        public int AdviceId { get; set; }
        public System.DateTime ForDate { get; set; }
        public int ListNum { get; set; }
        public int RoomId { get; set; }
        public Nullable<int> PatLocationId { get; set; }
        public Nullable<decimal> BackTotality { get; set; }
        public bool IsBack { get; set; }
        public Nullable<bool> IsInject { get; set; }
        public Nullable<bool> IsReject { get; set; }
        public int LocationId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string F1 { get; set; }
    }
}
