using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkLabResult
    {
        public int ID { get; set; }
        public int LabId { get; set; }
        public int TestId { get; set; }
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
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsPrint { get; set; }
        public Nullable<System.DateTime> PrintTime { get; set; }
        public Nullable<int> PrintOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string TextRange { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual CkLab CkLab { get; set; }
    }
}
