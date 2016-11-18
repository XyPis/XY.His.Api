using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkItemRange
    {
        public int ID { get; set; }
        public int TestId { get; set; }
        public string Sex { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public decimal LowValue { get; set; }
        public decimal HighValue { get; set; }
        public decimal PanicLow { get; set; }
        public decimal PanicHigh { get; set; }
        public string PrintResult { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string TextRange { get; set; }
        public Nullable<short> LsAgeUnit { get; set; }
        public Nullable<int> MachineId { get; set; }
        public virtual CKMachine CKMachine { get; set; }
    }
}
