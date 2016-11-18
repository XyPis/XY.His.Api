using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuInvoiceFeetySum
    {
        public int ID { get; set; }
        public int InvoId { get; set; }
        public int FeeId { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountFact { get; set; }
        public decimal AmountSelf { get; set; }
        public decimal AmountTally { get; set; }
        public decimal AmountPay { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsMzFeety BsMzFeety { get; set; }
        public virtual OuInvoice OuInvoice { get; set; }
    }
}
