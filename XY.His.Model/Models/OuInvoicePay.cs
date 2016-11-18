using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuInvoicePay
    {
        public int ID { get; set; }
        public int InvoId { get; set; }
        public int PaywayId { get; set; }
        public decimal Amount { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> cancelPaywayId { get; set; }
        public virtual BsPayWay BsPayWay { get; set; }
        public virtual OuInvoice OuInvoice { get; set; }
    }
}
