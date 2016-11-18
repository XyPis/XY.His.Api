using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.OU
{
    [Serializable]
    public partial class OuInvoiceDto : DtoBase
    {
        public string InvoNo { get; set; }
        public int MzRegId { get; set; }
        public int PatId { get; set; }
        public System.DateTime InvoTime { get; set; }
        public decimal Beprice { get; set; }
        public decimal FactGet { get; set; }
        public decimal Insurance { get; set; }
        public decimal PaySelf { get; set; }
        public decimal AmountPay { get; set; }
        public decimal AddFee { get; set; }
        public string TallyNo { get; set; }
        public string Remark { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public string CancelMemo { get; set; }
        public Nullable<int> InvoLastId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> FeeMainId { get; set; }
        public Nullable<int> FeeSubId { get; set; }
        public Nullable<System.DateTime> TallyTime { get; set; }
        public Nullable<System.DateTime> CancelTallyTime { get; set; }
        public Nullable<decimal> ReAmount { get; set; }
        public Nullable<System.DateTime> ReAmountDate { get; set; }
        public string ReAmountMemo { get; set; }
        public Nullable<int> PatTypeId { get; set; }
        public string F5 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> YbIllId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public Nullable<System.DateTime> CancelCheckTime { get; set; }
        public Nullable<int> DocLocId { get; set; }
    }
}
