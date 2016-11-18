using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class NfInfectDrug
    {
        public int ID { get; set; }
        public int InfectId { get; set; }
        public int BaseDrugId { get; set; }
        public decimal Dosage { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<short> Days { get; set; }
        public virtual BsBaseDrug BsBaseDrug { get; set; }
        public virtual BsFrequency BsFrequency { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual BsUsage BsUsage { get; set; }
        public virtual NfInfect NfInfect { get; set; }
    }
}
