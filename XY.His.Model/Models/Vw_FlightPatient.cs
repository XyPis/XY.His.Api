using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_FlightPatient
    {
        public int patID { get; set; }
        public string InPatNo { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Native { get; set; }
        public string CountryName { get; set; }
        public string NationName { get; set; }
        public string IdCardNo { get; set; }
        public string Identity { get; set; }
        public string patTypeName { get; set; }
        public string AddressHome { get; set; }
        public string PostCodeHome { get; set; }
        public string PhoneHome { get; set; }
        public string PhoneWork { get; set; }
        public string LinkmanName { get; set; }
        public string RelationName { get; set; }
        public string LinkmanAddress { get; set; }
        public string LinkmanPost { get; set; }
        public string LinkmanPhone { get; set; }
        public Nullable<decimal> Height { get; set; }
        public Nullable<decimal> Weight { get; set; }
    }
}
