using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkCompanyGroup
    {
        public CkCompanyGroup()
        {
            this.CkCompanyMen = new List<CkCompanyMan>();
            this.CkCompGroupPsApplies = new List<CkCompGroupPsApply>();
            this.CkGroupItems = new List<CkGroupItem>();
            this.CkMains = new List<CkMain>();
        }

        public int ID { get; set; }
        public int CompanyId { get; set; }
        public int GroupId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual CkCompany CkCompany { get; set; }
        public virtual CkGroup CkGroup { get; set; }
        public virtual ICollection<CkCompanyMan> CkCompanyMen { get; set; }
        public virtual ICollection<CkCompGroupPsApply> CkCompGroupPsApplies { get; set; }
        public virtual ICollection<CkGroupItem> CkGroupItems { get; set; }
        public virtual ICollection<CkMain> CkMains { get; set; }
    }
}
