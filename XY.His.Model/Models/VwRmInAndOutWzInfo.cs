using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwRmInAndOutWzInfo
    {
        public int ID { get; set; }
        public string BillNo { get; set; }
        public int RoomId { get; set; }
        public string LocationName { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public int HouseId { get; set; }
        public Nullable<decimal> RetailTotle { get; set; }
        public Nullable<decimal> StockTotle { get; set; }
        public string Type { get; set; }
        public bool IsSign { get; set; }
        public int LsActType { get; set; }
        public System.DateTime SignTime { get; set; }
        public int pageNumber { get; set; }
    }
}
