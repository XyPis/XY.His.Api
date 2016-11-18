using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsHsFeety
    {
        public BsHsFeety()
        {
            this.CsDeptIncomes = new List<CsDeptIncome>();
            this.CsIncomeDetails = new List<CsIncomeDetail>();
            this.InInvoiceDtlDumps = new List<InInvoiceDtlDump>();
            this.InInvoiceDtlTemps = new List<InInvoiceDtlTemp>();
            this.OuInvoiceDtls = new List<OuInvoiceDtl>();
            this.BsItemLocations = new List<BsItemLocation>();
            this.BsItemLocations1 = new List<BsItemLocation>();
            this.InInvoiceDtls = new List<InInvoiceDtl>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public string Name { get; set; }
        public Nullable<int> LocationId { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<bool> IsDrug { get; set; }
        public virtual ICollection<CsDeptIncome> CsDeptIncomes { get; set; }
        public virtual ICollection<CsIncomeDetail> CsIncomeDetails { get; set; }
        public virtual ICollection<InInvoiceDtlDump> InInvoiceDtlDumps { get; set; }
        public virtual ICollection<InInvoiceDtlTemp> InInvoiceDtlTemps { get; set; }
        public virtual ICollection<OuInvoiceDtl> OuInvoiceDtls { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual ICollection<BsItemLocation> BsItemLocations { get; set; }
        public virtual ICollection<BsItemLocation> BsItemLocations1 { get; set; }
        public virtual ICollection<InInvoiceDtl> InInvoiceDtls { get; set; }
    }
}
