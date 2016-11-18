using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OulInvoiceReg
    {
        public OulInvoiceReg()
        {
            this.OulInvoiceReg1 = new List<OulInvoiceReg>();
        }

        public int ID { get; set; }
        public string InvoNo { get; set; }
        public int MzRegId { get; set; }
        public System.DateTime InvoTime { get; set; }
        public decimal RegFee { get; set; }
        public decimal DiagnoFee { get; set; }
        public decimal ZyFee { get; set; }
        public decimal OtherFee1 { get; set; }
        public decimal OtherFee2 { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CancelTime { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public Nullable<int> InvoLastId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<int> RegTypeId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public Nullable<int> PatTypeId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public Nullable<System.DateTime> CancelCheckTime { get; set; }
        public Nullable<int> DocLocId { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
        public virtual ICollection<OulInvoiceReg> OulInvoiceReg1 { get; set; }
        public virtual OulInvoiceReg OulInvoiceReg2 { get; set; }
    }
}
