using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwHuInAndOutInfo_Wz
    {
        public int ID { get; set; }
        public string BillNo { get; set; }
        public int HouseId { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public bool IsSign { get; set; }
        public Nullable<decimal> RetailTotle { get; set; }
        public Nullable<decimal> StockTotle { get; set; }
        public string Type { get; set; }
        public int LsActType { get; set; }
        public Nullable<System.DateTime> SignTime { get; set; }
        public string Name { get; set; }
    }
}
