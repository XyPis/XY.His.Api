using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkIllAdvice
    {
        public int ID { get; set; }
        public Nullable<int> TestTypeId { get; set; }
        public string Code { get; set; }
        public string IllDesc { get; set; }
        public string OrderBy { get; set; }
        public string Advice { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
