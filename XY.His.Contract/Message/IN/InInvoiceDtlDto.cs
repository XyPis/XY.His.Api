using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.IN
{
    [Serializable]
    public partial class InInvoiceDtlDto : DtoBase
    {
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
        public Nullable<decimal> Amount { get; set; }
        public decimal AmountFact { get; set; }
        public decimal AmountSelf { get; set; }
        public decimal AmountTally { get; set; }
        public decimal AmountPay { get; set; }
        public Nullable<int> InvoId { get; set; }
        public short LsPerform { get; set; }
        public bool IsModiDisc { get; set; }
        public Nullable<int> LimitGroupId { get; set; }
        public Nullable<decimal> LimitFee { get; set; }
        public int DoctorId { get; set; }
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
        public string HostName { get; set; }
        public Nullable<int> ExecuteId { get; set; }
        public string RegDate { get; set; }
        public Nullable<int> GroupItemId { get; set; }
        public Nullable<int> XDRpId { get; set; }
        public string AdviceName { get; set; }
        public Nullable<int> MainDoctorId { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
        public Nullable<int> OuInvoId { get; set; }
        public string Urgent { get; set; }
        public string ReservedField { get; set; }
        public string ReservedField2 { get; set; }
        public Nullable<decimal> PriceIn1 { get; set; }
        public Nullable<decimal> PriceIn2 { get; set; }
        public Nullable<int> LsPriceState { get; set; }
        public Nullable<int> DocLocId { get; set; }
        public Nullable<int> ExecDoctorId { get; set; }
    }
}
