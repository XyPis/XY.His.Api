using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInLongDrugApply
    {
        public string InPatNo { get; set; }
        public string HospNo { get; set; }
        public Nullable<System.DateTime> AdviceTime { get; set; }
        public string DoctorName { get; set; }
        public int HospId { get; set; }
        public short GroupNum { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public int ItemID { get; set; }
        public decimal Dosage { get; set; }
        public string UnitName { get; set; }
        public int AdviceID { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public bool IsAttach { get; set; }
        public decimal TOTALRoom { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int DoctorId { get; set; }
        public string Memo { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string ItemCode { get; set; }
        public int UnitKC { get; set; }
        public string UnitRoomName { get; set; }
        public string BedName { get; set; }
        public string FrequencyPrintName { get; set; }
        public Nullable<bool> IsIssued { get; set; }
        public Nullable<int> RequestId { get; set; }
        public Nullable<bool> ForToday { get; set; }
        public Nullable<int> RoomID { get; set; }
        public Nullable<decimal> StoreNum { get; set; }
        public Nullable<decimal> BackNum { get; set; }
        public Nullable<decimal> BackedNum { get; set; }
        public Nullable<bool> IsBack { get; set; }
        public Nullable<bool> IsBackReq { get; set; }
        public string UsagePrintName { get; set; }
        public short LsExecLoc { get; set; }
        public Nullable<bool> IsMinus { get; set; }
        public Nullable<short> FirstDay { get; set; }
        public Nullable<short> LastDay { get; set; }
        public bool IsEnd { get; set; }
        public int Expr1 { get; set; }
        public int LocIn { get; set; }
        public short OrderBy { get; set; }
        public string Sex { get; set; }
        public int PatID { get; set; }
        public int UnitInId { get; set; }
        public Nullable<decimal> PriceIn { get; set; }
        public Nullable<decimal> Times { get; set; }
        public Nullable<int> BedId { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> MainDoctorId { get; set; }
        public string F4 { get; set; }
        public Nullable<short> LsMarkType { get; set; }
        public short Lsrptype { get; set; }
    }
}
