using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsInvInItem
    {
        public BsInvInItem()
        {
            this.BsItemPatTypes = new List<BsItemPatType>();
            this.BsZyFeeties = new List<BsZyFeety>();
            this.InInvoiceDtls = new List<InInvoiceDtl>();
            this.InInvoiceDtlCancels = new List<InInvoiceDtlCancel>();
            this.InInvoiceDtlDumps = new List<InInvoiceDtlDump>();
            this.InInvoiceDtlTemps = new List<InInvoiceDtlTemp>();
            this.InInvoiceInvItemSums = new List<InInvoiceInvItemSum>();
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
        public virtual ICollection<BsItemPatType> BsItemPatTypes { get; set; }
        public virtual ICollection<BsZyFeety> BsZyFeeties { get; set; }
        public virtual ICollection<InInvoiceDtl> InInvoiceDtls { get; set; }
        public virtual ICollection<InInvoiceDtlCancel> InInvoiceDtlCancels { get; set; }
        public virtual ICollection<InInvoiceDtlDump> InInvoiceDtlDumps { get; set; }
        public virtual ICollection<InInvoiceDtlTemp> InInvoiceDtlTemps { get; set; }
        public virtual ICollection<InInvoiceInvItemSum> InInvoiceInvItemSums { get; set; }
    }
}
