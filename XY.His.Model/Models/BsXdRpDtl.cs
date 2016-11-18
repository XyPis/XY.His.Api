using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsXdRpDtl
    {
        public int ID { get; set; }
        public int XdRpId { get; set; }
        public short GroupNum { get; set; }
        public int ItemId { get; set; }
        public decimal Dosage { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<short> Days { get; set; }
        public Nullable<int> ExecLocId { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<decimal> FeeTotality { get; set; }
        public Nullable<int> UnitId { get; set; }
        public virtual BsFrequency BsFrequency { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual BsUnit BsUnit1 { get; set; }
        public virtual BsUsage BsUsage { get; set; }
        public virtual BsXdRp BsXdRp { get; set; }
    }
}
