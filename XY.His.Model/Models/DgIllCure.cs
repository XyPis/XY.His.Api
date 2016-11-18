using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DgIllCure
    {
        public int ID { get; set; }
        public Nullable<int> IllId { get; set; }
        public Nullable<int> IllGroupId { get; set; }
        public Nullable<int> CureId { get; set; }
        public Nullable<int> DrugId { get; set; }
        public Nullable<int> CheckId { get; set; }
        public Nullable<int> NurseId { get; set; }
        public Nullable<short> LsAdvType { get; set; }
        public Nullable<short> LsCureType { get; set; }
        public Nullable<bool> IsBaby { get; set; }
        public Nullable<bool> IsWomen { get; set; }
        public Nullable<bool> IsMen { get; set; }
        public Nullable<bool> IsOlder { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<decimal> Dosage { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<short> Days { get; set; }
        public Nullable<decimal> FeeTotality { get; set; }
        public Nullable<int> UnitId { get; set; }
        public virtual BsBaseCheck BsBaseCheck { get; set; }
        public virtual BsBaseCure BsBaseCure { get; set; }
        public virtual BsBaseDrug BsBaseDrug { get; set; }
        public virtual BsBaseNurse BsBaseNurse { get; set; }
        public virtual BsIllness BsIllness { get; set; }
        public virtual DgIllGroup DgIllGroup { get; set; }
    }
}
