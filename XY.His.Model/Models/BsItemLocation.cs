using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsItemLocation
    {
        public int ID { get; set; }
        public int LocationId { get; set; }
        public int ItemId { get; set; }
        public Nullable<int> FeeHsMzId { get; set; }
        public Nullable<int> FeeHsZyId { get; set; }
        public Nullable<decimal> Dosage { get; set; }
        public Nullable<int> UnitTake { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public bool IsLocDrug { get; set; }
        public int OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<int> ExecLocId { get; set; }
        public Nullable<bool> IsLocUse { get; set; }
        public virtual BsFrequency BsFrequency { get; set; }
        public virtual BsHsFeety BsHsFeety { get; set; }
        public virtual BsHsFeety BsHsFeety1 { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsLocation BsLocation1 { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual BsUsage BsUsage { get; set; }
    }
}
