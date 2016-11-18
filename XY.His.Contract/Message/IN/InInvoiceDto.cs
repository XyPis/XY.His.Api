using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.IN
{
    [Serializable]
    public partial class InInvoiceDto : DtoBase
    {
        public string InvoNo { get; set; }
        public short LsPayType { get; set; }
        public int HospId { get; set; }
        public int PatTypeId { get; set; }
        public System.DateTime FromDate { get; set; }
        public System.DateTime ToDate { get; set; }
        public short ChargeDays { get; set; }
        public decimal Beprice { get; set; }
        public string TallyNo { get; set; }
        public decimal FactGet { get; set; }
        public decimal Insurance { get; set; }
        public decimal PaySelf { get; set; }
        public decimal AmountPay { get; set; }
        public decimal Deposit { get; set; }
        public decimal Complement { get; set; }
        public decimal Arrearage { get; set; }
        public decimal AddFee { get; set; }
        public string Remark { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
        public Nullable<int> CancelOperID { get; set; }
        public string CancelMemo { get; set; }
        public Nullable<int> InvoLastId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> YbIllId { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public Nullable<System.DateTime> CancelCheckTime { get; set; }
        public Nullable<decimal> ReAmount { get; set; }
        public Nullable<System.DateTime> ReAmountDate { get; set; }
        public string ReAmountMemo { get; set; }        
    }
}
