using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TrPractise
    {
        public int ID { get; set; }
        public string Hospital { get; set; }
        public Nullable<int> OriId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<System.DateTime> PractiseTime { get; set; }
        public Nullable<byte> DebugMode { get; set; }
        public string Funtion { get; set; }
        public string UserName { get; set; }
        public string RoleName { get; set; }
        public string LocationName { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
