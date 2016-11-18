using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwCkLabResult
    {
        public int ID { get; set; }
        public string LabNum { get; set; }
        public string InPatNo { get; set; }
        public string CardNo { get; set; }
        public string PatientName { get; set; }
        public string SexName { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Diagnose { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string UserName { get; set; }
        public bool IsPriority { get; set; }
        public Nullable<System.DateTime> CollectTime { get; set; }
        public Nullable<int> CollectOperId { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CancelTime { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public string LsSourceName { get; set; }
        public int LabId { get; set; }
        public int TestId { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public string TestTypeName { get; set; }
        public string LastResult { get; set; }
        public string Result { get; set; }
        public string Unit { get; set; }
        public short LsRefFlag { get; set; }
        public bool IsPanic { get; set; }
        public bool IsDalta { get; set; }
        public decimal DalAbsolute { get; set; }
        public decimal DalPercent { get; set; }
        public decimal LowValue { get; set; }
        public decimal HighValue { get; set; }
        public decimal PanicLow { get; set; }
        public decimal PanicHigh { get; set; }
        public bool IsPass { get; set; }
        public bool IsReport { get; set; }
        public string Memo { get; set; }
        public System.DateTime ReportOperTime { get; set; }
        public int ReportOperId { get; set; }
        public string ReportOperName { get; set; }
        public bool IsPrint { get; set; }
        public Nullable<System.DateTime> PrintTime { get; set; }
        public Nullable<int> PrintOperId { get; set; }
        public int IsPositive { get; set; }
    }
}
