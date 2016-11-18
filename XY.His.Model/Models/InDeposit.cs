using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InDeposit
    {
        public InDeposit()
        {
            this.InPays = new List<InPay>();
        }

        public int ID { get; set; }
        public string BillNo { get; set; }
        public int HospId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public decimal Amount { get; set; }
        public decimal Remain { get; set; }
        public bool IsFirst { get; set; }
        public string Remark { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<short> LsCancelType { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public Nullable<int> InvoId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public Nullable<System.DateTime> CancelCheckTime { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsUser BsUser1 { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual InInvoice InInvoice { get; set; }
        public virtual ICollection<InPay> InPays { get; set; }
    }
}
