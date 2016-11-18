using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class ElPatFormDrug
    {
        public int ID { get; set; }
        public Nullable<int> PatFormId { get; set; }
        public Nullable<int> ListNum { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<short> GroupNum { get; set; }
        public Nullable<decimal> Dosage { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<short> Days { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public Nullable<int> UnitDiagId { get; set; }
        public Nullable<bool> IsAttach { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ElPatForm ElPatForm { get; set; }
    }
}
