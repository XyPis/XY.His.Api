using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InInvoiceDtlTemp
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public int ItemId { get; set; }
        public System.DateTime RegOperTime { get; set; }
        public int RegOperId { get; set; }
        public int LocationId { get; set; }
        public int AdviceId { get; set; }
        public short LsMarkType { get; set; }
        public decimal Totality { get; set; }
        public decimal PriceIn { get; set; }
        public int UnitId { get; set; }
        public bool IsPay { get; set; }
        public decimal DiscIn { get; set; }
        public decimal DiscSelf { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountFact { get; set; }
        public decimal AmountSelf { get; set; }
        public decimal AmountTally { get; set; }
        public decimal AmountPay { get; set; }
        public Nullable<int> InvoId { get; set; }
        public short LsPerform { get; set; }
        public bool IsModiDisc { get; set; }
        public Nullable<int> LimitGroupId { get; set; }
        public Nullable<decimal> LimitFee { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public int ExecOperId { get; set; }
        public int ExecLocId { get; set; }
        public int InvItemId { get; set; }
        public int FeeId { get; set; }
        public Nullable<int> FeeHsId { get; set; }
        public Nullable<int> LsReportType { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<int> CancelId { get; set; }
        public bool IsManual { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsHsFeety BsHsFeety { get; set; }
        public virtual BsInvInItem BsInvInItem { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsLimitGroup BsLimitGroup { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsLocation BsLocation1 { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual BsZyFeety BsZyFeety { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual InInvoice InInvoice { get; set; }
    }
}
