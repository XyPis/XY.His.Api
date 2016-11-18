using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkItemResult
    {
        public int ID { get; set; }
        public int TestId { get; set; }
        public string Result { get; set; }
        public bool IsBold { get; set; }
        public bool IsPass { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Summary { get; set; }
        public string DoctorAdvice { get; set; }
    }
}
