using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInTempDrugApply
    {
        public string HospNO { get; set; }
        public System.DateTime AdviceTime { get; set; }
        public string DoctorName { get; set; }
        public int HospID { get; set; }
        public short GroupNum { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public decimal Dosage { get; set; }
        public string UnitName { get; set; }
        public int AdviceID { get; set; }
        public Nullable<int> UnitTakeID { get; set; }
        public Nullable<int> FrequencyID { get; set; }
        public Nullable<int> UsageID { get; set; }
        public int DoctorID { get; set; }
        public string PatientName { get; set; }
        public int LocationID { get; set; }
        public int ItemID { get; set; }
        public string ItemCode { get; set; }
        public decimal Totality { get; set; }
        public int UnitInID { get; set; }
        public bool IsAttach { get; set; }
        public decimal TOTALRoom { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int UnitKC { get; set; }
        public string UnitRoomName { get; set; }
        public string BedName { get; set; }
        public string Memo { get; set; }
        public string FrequencyPrintName { get; set; }
        public string UsageName { get; set; }
        public string UsagePrintName { get; set; }
        public Nullable<bool> IsIssued { get; set; }
        public Nullable<int> requestid { get; set; }
        public Nullable<bool> ForToday { get; set; }
        public Nullable<int> RoomID { get; set; }
        public Nullable<decimal> StoreNum { get; set; }
        public Nullable<decimal> BackNum { get; set; }
        public Nullable<decimal> BackedNum { get; set; }
        public Nullable<bool> IsBack { get; set; }
        public Nullable<bool> IsBackReq { get; set; }
        public short LsExecLoc { get; set; }
        public Nullable<bool> IsMinus { get; set; }
    }
}
