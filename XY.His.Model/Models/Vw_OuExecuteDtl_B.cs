using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_OuExecuteDtl_B
    {
        public System.DateTime OperDate { get; set; }
        public int ID { get; set; }
        public int ExecuteId { get; set; }
        public Nullable<int> RecipeDtlId { get; set; }
        public int listNum { get; set; }
        public int ItemId { get; set; }
        public decimal Dosage { get; set; }
        public int UnitId { get; set; }
        public int UsageId { get; set; }
        public int FrequencyId { get; set; }
        public short Days { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public Nullable<int> UnitDiagId { get; set; }
        public Nullable<System.DateTime> IssueTime { get; set; }
        public Nullable<System.DateTime> BackTime { get; set; }
    }
}
