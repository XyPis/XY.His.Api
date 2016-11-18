using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInExecuteLate
    {
        public int ID { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<System.DateTime> AdviceTime { get; set; }
        public int AdviceId { get; set; }
        public short LsMarkType { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public Nullable<short> GroupNum { get; set; }
        public int LocationId { get; set; }
        public bool IsPrint { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<short> LsExecLoc { get; set; }
        public Nullable<int> ExecLocId { get; set; }
        public string HospNo { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> LocIn { get; set; }
        public string SexName { get; set; }
        public int Age { get; set; }
        public Nullable<int> PatId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string Code { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public Nullable<decimal> PriceIn { get; set; }
        public string LoactionName { get; set; }
        public string BedName { get; set; }
        public string UnitTakeName { get; set; }
        public string UsageName { get; set; }
        public string FrequencyName { get; set; }
        public Nullable<bool> IsPoison { get; set; }
        public Nullable<decimal> Times { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<int> DetailId { get; set; }
        public Nullable<decimal> Dosage { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public string Memo { get; set; }
        public Nullable<int> BedId { get; set; }
        public Nullable<bool> IsPrintLabel { get; set; }
        public Nullable<bool> IsPrintReject { get; set; }
        public Nullable<bool> IsPrintDrug { get; set; }
        public Nullable<bool> IsPrintAst { get; set; }
        public Nullable<bool> IsPrintCure { get; set; }
        public Nullable<bool> IsPrintNurse { get; set; }
        public Nullable<bool> IsPrintExternal { get; set; }
        public Nullable<bool> IsPrintPush { get; set; }
        public Nullable<bool> IsPrintRejSkin { get; set; }
        public Nullable<bool> IsPrintDietetic { get; set; }
        public Nullable<bool> IsPrintBlood { get; set; }
        public Nullable<bool> IsSelected { get; set; }
        public Nullable<bool> IsExecuted { get; set; }
        public Nullable<System.DateTime> ExecutedTime { get; set; }
        public Nullable<int> ExecutedOperId { get; set; }
    }
}
