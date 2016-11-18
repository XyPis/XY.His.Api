using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DgRoadPatDtl
    {
        public int ID { get; set; }
        public Nullable<int> RoadPatId { get; set; }
        public int RoadDtlId { get; set; }
        public Nullable<int> DayGroupId { get; set; }
        public Nullable<int> CureId { get; set; }
        public Nullable<int> DrugId { get; set; }
        public Nullable<int> CheckId { get; set; }
        public Nullable<int> NurseId { get; set; }
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
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<bool> IsChange { get; set; }
        public string Reason { get; set; }
        public int AdviceId { get; set; }
        public short LsMarkType { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
