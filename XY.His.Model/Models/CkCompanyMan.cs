using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkCompanyMan
    {
        public int ID { get; set; }
        public int CompanyGroupId { get; set; }
        public int PatId { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual CkCompanyGroup CkCompanyGroup { get; set; }
    }
}
