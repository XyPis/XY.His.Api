using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VWRequestBillBackReq
    {
        public string RoomName { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string PatientName { get; set; }
        public string BedName { get; set; }
        public Nullable<int> Age { get; set; }
        public string SexName { get; set; }
        public string ItemName { get; set; }
        public short GroupNum { get; set; }
        public short LsMarkType { get; set; }
        public int RoomId { get; set; }
        public decimal Dosage { get; set; }
        public string Spec { get; set; }
        public System.DateTime ForDate { get; set; }
        public Nullable<bool> IsBack { get; set; }
        public string UnitInName { get; set; }
        public decimal Totality { get; set; }
        public int ListNum { get; set; }
        public int RequestId { get; set; }
        public int HospId { get; set; }
        public bool IsIssued { get; set; }
        public decimal ReqBackTotality { get; set; }
        public Nullable<bool> IsBackReq { get; set; }
        public Nullable<int> DetailId { get; set; }
        public Nullable<System.DateTime> ConfirmOperTime { get; set; }
        public Nullable<int> ConfirmOperId { get; set; }
        public bool IsConfirm { get; set; }
        public bool IsPrint { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UnitTake { get; set; }
        public int UnitReq { get; set; }
        public int AdviceId { get; set; }
        public int ItemId { get; set; }
        public int ID { get; set; }
        public short LsSendStatus { get; set; }
        public System.DateTime ReqTime { get; set; }
        public int ReqOperId { get; set; }
        public string RequestNo { get; set; }
        public string ItemCode { get; set; }
        public decimal PriceIn { get; set; }
        public string HospNo { get; set; }
        public string ReqOperName { get; set; }
        public int ReqLocationId { get; set; }
        public string ReqLocationName { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> ReqBackId { get; set; }
        public decimal BackTotality { get; set; }
        public string FrequencyName { get; set; }
        public string UsageName { get; set; }
    }
}
