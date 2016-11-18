using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DhInvoiceTemp
    {
        public int ID { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public short LsInOut { get; set; }
        public string InvoNo { get; set; }
        public System.DateTime InvoTime { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public string OperName { get; set; }
        public string InPatNo { get; set; }
        public string CardNo { get; set; }
        public string PatientName { get; set; }
        public string RegTypeName { get; set; }
        public Nullable<short> InDays { get; set; }
        public string PatTypeCode { get; set; }
        public string PatType1 { get; set; }
        public string PatType2 { get; set; }
        public string PatType3 { get; set; }
        public string ICDCode { get; set; }
        public string Illness { get; set; }
        public Nullable<decimal> AmountPay { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
