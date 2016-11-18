using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OpsEvent
    {
        public int ID { get; set; }
        public int ApplyId { get; set; }
        public Nullable<int> ItemId { get; set; }
        public decimal Dosage { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public System.DateTime EventTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Memo { get; set; }
        public int OperID { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<int> UsageId { get; set; }
    }
}
