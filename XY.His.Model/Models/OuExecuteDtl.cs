using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuExecuteDtl
    {
        public OuExecuteDtl()
        {
            this.OuExecuteBacks = new List<OuExecuteBack>();
        }

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
        public Nullable<bool> IsExecuted { get; set; }
        public Nullable<System.DateTime> ExecutedTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public virtual BsFrequency BsFrequency { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual BsUsage BsUsage { get; set; }
        public virtual OuExecute OuExecute { get; set; }
        public virtual ICollection<OuExecuteBack> OuExecuteBacks { get; set; }
    }
}
