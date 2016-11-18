using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_DoctorInSum
    {
        public int ID { get; set; }
        public string GroupSubName { get; set; }
        public string ItemName { get; set; }
        public decimal Price { get; set; }
        public decimal Totality { get; set; }
        public string UnitIdName { get; set; }
        public decimal Amount { get; set; }
        public string DoctorName { get; set; }
        public string InvItemName { get; set; }
        public int MzRegId { get; set; }
        public string PatientName { get; set; }
        public string LocationName { get; set; }
        public System.DateTime InvoTime { get; set; }
    }
}
