using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwNfinfectDrug
    {
        public int InfectId { get; set; }
        public string BaseDrug { get; set; }
        public string Unit { get; set; }
        public string Usage { get; set; }
        public string Frequency { get; set; }
        public Nullable<short> Days { get; set; }
        public Nullable<decimal> totaldosage { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<decimal> Amount { get; set; }
    }
}
