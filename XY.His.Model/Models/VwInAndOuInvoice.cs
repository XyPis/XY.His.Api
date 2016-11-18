using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInAndOuInvoice
    {
        public string ID_NO { get; set; }
        public int ID { get; set; }
        public string Hosp_NO { get; set; }
        public string Invo_Num { get; set; }
        public string CHINESE { get; set; }
        public System.DateTime InvoTime { get; set; }
        public string LocationName { get; set; }
        public decimal Beprice { get; set; }
        public Nullable<decimal> SumTil { get; set; }
        public Nullable<decimal> Pay_Self { get; set; }
        public string Operator { get; set; }
        public string PatTypeName { get; set; }
        public string TallyGroupName { get; set; }
        public string SpeciaIll { get; set; }
        public string jbname { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public string HospitalName { get; set; }
    }
}
