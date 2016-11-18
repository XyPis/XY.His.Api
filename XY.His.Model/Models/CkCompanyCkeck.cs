using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkCompanyCkeck
    {
        public CkCompanyCkeck()
        {
            this.CkMains = new List<CkMain>();
        }

        public int ID { get; set; }
        public int CompanyId { get; set; }
        public System.DateTime CkeckDate { get; set; }
        public string CkeckNo { get; set; }
        public virtual CkCompany CkCompany { get; set; }
        public virtual ICollection<CkMain> CkMains { get; set; }
    }
}
