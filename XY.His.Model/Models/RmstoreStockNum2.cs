using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RmstoreStockNum2
    {
        public System.DateTime opertime { get; set; }
        public int HospitalId { get; set; }
        public int LsRoomType { get; set; }
        public int LsInOut { get; set; }
        public int ItemId { get; set; }
        public Nullable<decimal> StockNum { get; set; }
    }
}
