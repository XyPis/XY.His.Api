using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.IN
{
    [Serializable]
    public partial class InPatFeesListDto : DtoBase
    {
        public int HospId { get; set; }
        public string Name { get; set; }
        public Nullable<int> BedID { get; set; }
        public System.DateTime InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public int PatTypeID { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> LocIn { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> AmountPay { get; set; }
        public Nullable<decimal> Deposit { get; set; }
        public Nullable<decimal> NotPay { get; set; }
        public Nullable<decimal> HasPay { get; set; }
        public Nullable<decimal> Remain { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string InPatNo { get; set; }
        public Nullable<decimal> AmountNoPay { get; set; }
        public Nullable<decimal> AmountPayNoPay { get; set; }
        public Nullable<decimal> DepositNoPay { get; set; }
        public Nullable<decimal> DepositMz { get; set; }
        public Nullable<decimal> FactGet { get; set; }
        public Nullable<decimal> AllFactGet { get; set; }
        public Nullable<decimal> YPAmount { get; set; }
        public Nullable<decimal> YPBL { get; set; }
    }
}
