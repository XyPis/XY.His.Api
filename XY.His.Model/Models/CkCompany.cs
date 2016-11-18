using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkCompany
    {
        public CkCompany()
        {
            this.CkCompanyCkecks = new List<CkCompanyCkeck>();
            this.CkCompanyGroups = new List<CkCompanyGroup>();
            this.CkMains = new List<CkMain>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Address { get; set; }
        public string PostCode { get; set; }
        public string PayWayId { get; set; }
        public Nullable<decimal> Discount { get; set; }
        public string ResponMan { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<CkCompanyCkeck> CkCompanyCkecks { get; set; }
        public virtual ICollection<CkCompanyGroup> CkCompanyGroups { get; set; }
        public virtual ICollection<CkMain> CkMains { get; set; }
    }
}
