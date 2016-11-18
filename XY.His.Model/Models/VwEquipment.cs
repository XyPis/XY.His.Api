using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwEquipment
    {
        public int ID { get; set; }
        public string CODE { get; set; }
        public string Name { get; set; }
        public string Spec { get; set; }
        public string EqType { get; set; }
        public string SeriesNo { get; set; }
        public string Brand { get; set; }
        public string CountryName { get; set; }
        public string ManufacturerName { get; set; }
        public string LocationName { get; set; }
        public Nullable<short> LsEqClass { get; set; }
        public Nullable<int> ManuId { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<short> LsEqStatus { get; set; }
        public string LotNo { get; set; }
        public string Manager { get; set; }
        public Nullable<System.DateTime> BuyDate { get; set; }
        public Nullable<int> UseLocId { get; set; }
    }
}
