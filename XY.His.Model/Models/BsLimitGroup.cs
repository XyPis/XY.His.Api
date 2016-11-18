using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsLimitGroup
    {
        public BsLimitGroup()
        {
            this.BsItemPatTypes = new List<BsItemPatType>();
            this.BsLimitDocLevs = new List<BsLimitDocLev>();
            this.BsPatTypeLimits = new List<BsPatTypeLimit>();
            this.InInvoiceDtlDumps = new List<InInvoiceDtlDump>();
            this.InInvoiceDtlTemps = new List<InInvoiceDtlTemp>();
            this.OuInvoiceDtls = new List<OuInvoiceDtl>();
            this.InInvoiceDtls = new List<InInvoiceDtl>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> PatTypeId { get; set; }
        public Nullable<int> TypeGFXEId { get; set; }
        public decimal LimitFeeMz { get; set; }
        public decimal LimitFeeZy { get; set; }
        public string LsLimitType { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<int> DocLevelId { get; set; }
        public virtual BsGfxe BsGfxe { get; set; }
        public virtual ICollection<BsItemPatType> BsItemPatTypes { get; set; }
        public virtual ICollection<BsLimitDocLev> BsLimitDocLevs { get; set; }
        public virtual ICollection<BsPatTypeLimit> BsPatTypeLimits { get; set; }
        public virtual ICollection<InInvoiceDtlDump> InInvoiceDtlDumps { get; set; }
        public virtual ICollection<InInvoiceDtlTemp> InInvoiceDtlTemps { get; set; }
        public virtual ICollection<OuInvoiceDtl> OuInvoiceDtls { get; set; }
        public virtual ICollection<InInvoiceDtl> InInvoiceDtls { get; set; }
    }
}
