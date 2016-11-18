using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_InDaySum
    {
        public int ID { get; set; }
        public string InPatNo { get; set; }
        public string Name { get; set; }
        public System.DateTime InTime { get; set; }
        public int NTime { get; set; }
        public string PatTypeName { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string DoctorName { get; set; }
        public System.DateTime RegDate { get; set; }
        public decimal NotPay { get; set; }
        public decimal HasPay { get; set; }
        public decimal DaySum { get; set; }
        public string F1 { get; set; }
        public Nullable<decimal> Remain { get; set; }
        public string LocationName { get; set; }
    }
}
