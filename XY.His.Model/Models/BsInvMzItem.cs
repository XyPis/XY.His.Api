using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsInvMzItem
    {
        public BsInvMzItem()
        {
            this.OuInvoiceDtls = new List<OuInvoiceDtl>();
            this.OuInvoiceDtls1 = new List<OuInvoiceDtl>();
            this.OuInvoiceInvItemSums = new List<OuInvoiceInvItemSum>();
            this.BsItemPatTypes = new List<BsItemPatType>();
            this.BsMzFeeties = new List<BsMzFeety>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<OuInvoiceDtl> OuInvoiceDtls { get; set; }
        public virtual ICollection<OuInvoiceDtl> OuInvoiceDtls1 { get; set; }
        public virtual ICollection<OuInvoiceInvItemSum> OuInvoiceInvItemSums { get; set; }
        public virtual ICollection<BsItemPatType> BsItemPatTypes { get; set; }
        public virtual ICollection<BsMzFeety> BsMzFeeties { get; set; }
    }
}
