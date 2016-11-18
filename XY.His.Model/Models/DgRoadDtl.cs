using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DgRoadDtl
    {
        public int ID { get; set; }
        public int RoadId { get; set; }
        public Nullable<int> DayGroupId { get; set; }
        public Nullable<int> CureId { get; set; }
        public Nullable<int> DrugId { get; set; }
        public Nullable<int> CheckId { get; set; }
        public Nullable<int> NurseId { get; set; }
        public string Name { get; set; }
        public string Spec { get; set; }
        public Nullable<short> LsAdvType { get; set; }
        public Nullable<short> LsCureType { get; set; }
        public Nullable<int> CatalogId { get; set; }
        public Nullable<decimal> Dosage { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<short> Days { get; set; }
        public Nullable<decimal> FeeTotality { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<bool> IsNeed { get; set; }
        public Nullable<bool> IsReason { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
