using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class YbQuery
    {
        public int ID { get; set; }
        public string DesigCode { get; set; }
        public string PersonNum { get; set; }
        public string YbSeq { get; set; }
        public string DocumentNo { get; set; }
        public string TransType { get; set; }
        public string SerialNum { get; set; }
        public string ReceiveNum { get; set; }
        public string TotalAmount { get; set; }
        public string InsuranceAmount { get; set; }
        public string SuppleAmount { get; set; }
        public string CashPayment { get; set; }
        public string SelfAmount { get; set; }
        public string SomeSelfAmount { get; set; }
        public string EnterCosts { get; set; }
        public string ToPayStandard { get; set; }
        public string IntoCosts { get; set; }
        public string SelfPaid { get; set; }
        public string EnterInsuranceCosts { get; set; }
        public string SuppInsurancePays { get; set; }
        public string LimitSelfPaid { get; set; }
        public string Ntime { get; set; }
        public string DevelopersLogo { get; set; }
        public string SettlementDate { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> MzregId { get; set; }
        public Nullable<int> HospId { get; set; }
    }
}
