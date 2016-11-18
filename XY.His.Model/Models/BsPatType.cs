using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsPatType
    {
        public BsPatType()
        {
            this.BsFixCharges = new List<BsFixCharge>();
            this.BsItemPatTypes = new List<BsItemPatType>();
            this.BsItemYbTips = new List<BsItemYbTip>();
            this.BsLocPatTypes = new List<BsLocPatType>();
            this.BsOuMergeFees = new List<BsOuMergeFee>();
            this.BsPatientYBIlls = new List<BsPatientYBIll>();
            this.InHosInfoes = new List<InHosInfo>();
            this.BsPatTypeLimits = new List<BsPatTypeLimit>();
            this.BsPatTypeYbIlls = new List<BsPatTypeYbIll>();
            this.OuGfbxReports = new List<OuGfbxReport>();
            this.OuHosInfoes = new List<OuHosInfo>();
            this.BsRegPatAmounts = new List<BsRegPatAmount>();
            this.OuInvoices = new List<OuInvoice>();
            this.InDayCharges = new List<InDayCharge>();
            this.InInvoices = new List<InInvoice>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal LimitFee { get; set; }
        public decimal LimitIn { get; set; }
        public decimal ArrearFei { get; set; }
        public decimal DiscDiag { get; set; }
        public decimal DiscIn { get; set; }
        public string HeadNo { get; set; }
        public int TallyTypeId { get; set; }
        public decimal ArrearAmount { get; set; }
        public Nullable<short> LsGFPatType { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public bool IsActive { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<decimal> TwoDiscIn1 { get; set; }
        public Nullable<decimal> TwoDiscIn2 { get; set; }
        public virtual ICollection<BsFixCharge> BsFixCharges { get; set; }
        public virtual ICollection<BsItemPatType> BsItemPatTypes { get; set; }
        public virtual ICollection<BsItemYbTip> BsItemYbTips { get; set; }
        public virtual ICollection<BsLocPatType> BsLocPatTypes { get; set; }
        public virtual ICollection<BsOuMergeFee> BsOuMergeFees { get; set; }
        public virtual ICollection<BsPatientYBIll> BsPatientYBIlls { get; set; }
        public virtual ICollection<InHosInfo> InHosInfoes { get; set; }
        public virtual ICollection<BsPatTypeLimit> BsPatTypeLimits { get; set; }
        public virtual ICollection<BsPatTypeYbIll> BsPatTypeYbIlls { get; set; }
        public virtual ICollection<OuGfbxReport> OuGfbxReports { get; set; }
        public virtual ICollection<OuHosInfo> OuHosInfoes { get; set; }
        public virtual ICollection<BsRegPatAmount> BsRegPatAmounts { get; set; }
        public virtual ICollection<OuInvoice> OuInvoices { get; set; }
        public virtual BsTallyType BsTallyType { get; set; }
        public virtual ICollection<InDayCharge> InDayCharges { get; set; }
        public virtual ICollection<InInvoice> InInvoices { get; set; }
    }
}
