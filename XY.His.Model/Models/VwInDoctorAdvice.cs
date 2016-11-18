using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInDoctorAdvice
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> AdviceTime { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string LocationName { get; set; }
        public int HospId { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> BedId { get; set; }
        public string BedName { get; set; }
        public Nullable<int> Age { get; set; }
        public string SexName { get; set; }
        public int GroupNum { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string Spec { get; set; }
        public decimal Dosage { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public string UnitTakeName { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public string FrequencyName { get; set; }
        public Nullable<int> UsageId { get; set; }
        public string UsageName { get; set; }
        public Nullable<decimal> PriceIn { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<int> UnitInId { get; set; }
        public string UnitInName { get; set; }
        public int IsAttach { get; set; }
        public int IsSelf { get; set; }
        public int LsSpecialUsage { get; set; }
        public int LsExecLoc { get; set; }
        public int OperID { get; set; }
        public int IsEnd { get; set; }
        public Nullable<int> IsOtherFee { get; set; }
        public Nullable<short> LsRpType { get; set; }
        public string AdviceType { get; set; }
        public string InPatNo { get; set; }
        public int LsMarkType { get; set; }
        public int PatTypeId { get; set; }
        public string Memo { get; set; }
        public string ChkOperTime { get; set; }
        public string AuthOperTime { get; set; }
        public string ChkOperName { get; set; }
        public string AuthOperName { get; set; }
        public Nullable<int> FeeZyId { get; set; }
        public Nullable<int> ExecLocId { get; set; }
        public Nullable<bool> IsAuth { get; set; }
    }
}
