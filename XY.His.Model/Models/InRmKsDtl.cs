using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InRmKsDtl
    {
        public int ID { get; set; }
        public Nullable<int> DetailId { get; set; }
        public int BillId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
