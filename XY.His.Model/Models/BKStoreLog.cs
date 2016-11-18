using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BKStoreLog
    {
        public int ID { get; set; }
        public System.DateTime HappenTime { get; set; }
        public int UserId { get; set; }
        public int PatCardid { get; set; }
        public string BKRegNo { get; set; }
        public short LsActType { get; set; }
        public decimal BeforeMoney { get; set; }
        public decimal HappenMoney { get; set; }
        public decimal AfterMoney { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
