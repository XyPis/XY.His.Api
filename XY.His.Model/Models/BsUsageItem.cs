using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsUsageItem
    {
        public int ID { get; set; }
        public int UsageId { get; set; }
        public int ItemId { get; set; }
        public decimal Totality { get; set; }
        public short LsUseArea { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<bool> IsBaby { get; set; }
        public Nullable<bool> IsWomen { get; set; }
        public Nullable<bool> IsMen { get; set; }
        public Nullable<bool> IsOlder { get; set; }
        public string Memo { get; set; }
        public Nullable<bool> IsDrugTwoDay { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsUsage BsUsage { get; set; }
    }
}
