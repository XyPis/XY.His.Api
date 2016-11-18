using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_InAdviceTemp_B
    {
        public System.DateTime OperDate { get; set; }
        public int ID { get; set; }
        public System.DateTime AdviceTime { get; set; }
        public int DoctorId { get; set; }
        public int LocationId { get; set; }
        public int HospId { get; set; }
        public short GroupNum { get; set; }
        public int ItemId { get; set; }
        public decimal Dosage { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public decimal PriceIn { get; set; }
        public decimal Totality { get; set; }
        public int UnitInId { get; set; }
        public bool IsUrgent { get; set; }
        public bool IsAttach { get; set; }
        public bool IsSelf { get; set; }
        public short LsSpecialUsage { get; set; }
        public short LsExecLoc { get; set; }
        public bool IsSkin { get; set; }
        public Nullable<System.DateTime> SkinTime { get; set; }
        public string SkinTest { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public bool IsPrinted { get; set; }
        public Nullable<bool> IsOtherFee { get; set; }
        public bool IsChk { get; set; }
        public Nullable<System.DateTime> ChkOperTime { get; set; }
        public Nullable<int> ChkOperID { get; set; }
        public bool IsAuth { get; set; }
        public Nullable<System.DateTime> AuthOperTime { get; set; }
        public Nullable<int> AuthOperID { get; set; }
        public bool IsAuthFee { get; set; }
        public Nullable<System.DateTime> AuthFeeOperTime { get; set; }
        public Nullable<int> AuthFeeOperID { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
        public Nullable<int> CancelOperID { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<short> SN { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public int ExecLocId { get; set; }
    }
}
