using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TrLocDayRatio
    {
        public int ID { get; set; }
        public int LocationId { get; set; }
        public System.DateTime RegDate { get; set; }
        public decimal MedicineRatio { get; set; }
        public Nullable<decimal> AntiBiRatio { get; set; }
        public Nullable<decimal> Ratio1 { get; set; }
        public Nullable<decimal> Ratio2 { get; set; }
        public Nullable<decimal> Ratio3 { get; set; }
        public Nullable<decimal> Ratio4 { get; set; }
        public Nullable<decimal> Ratio5 { get; set; }
        public Nullable<decimal> Ratio6 { get; set; }
        public Nullable<decimal> Ratio7 { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
