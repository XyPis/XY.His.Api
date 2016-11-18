using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InPay
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public Nullable<int> InvoId { get; set; }
        public Nullable<int> DepositId { get; set; }
        public short LsChargeType { get; set; }
        public decimal Amount { get; set; }
        public int PayWayId { get; set; }
        public string Memo { get; set; }
        public decimal Remain { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> CancelPaywayId { get; set; }
        public virtual BsPayWay BsPayWay { get; set; }
        public virtual InDeposit InDeposit { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual InInvoice InInvoice { get; set; }
    }
}
