using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInDoctorAdviceLongTemp
    {
        public int ID { get; set; }
        public System.DateTime AdviceTime { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public int HospId { get; set; }
        public short GroupNum { get; set; }
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
        public decimal Totality { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int UnitInId { get; set; }
        public string UnitInName { get; set; }
        public bool IsAttach { get; set; }
        public bool IsSelf { get; set; }
        public short LsSpecialUsage { get; set; }
        public short LsExecLoc { get; set; }
        public int OperID { get; set; }
        public bool IsEnd { get; set; }
        public Nullable<bool> IsOtherFee { get; set; }
        public Nullable<short> LsRpType { get; set; }
        public string AdviceType { get; set; }
        public int LsMarkType { get; set; }
        public string Memo { get; set; }
        public string InPatNo { get; set; }
        public string PatientName { get; set; }
        public int age { get; set; }
        public Nullable<int> BedId { get; set; }
        public string BedName { get; set; }
        public int PatTypeId { get; set; }
        public string SexName { get; set; }
    }
}
