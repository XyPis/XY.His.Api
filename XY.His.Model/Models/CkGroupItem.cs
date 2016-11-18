using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkGroupItem
    {
        public int ID { get; set; }
        public int CompanyGroupId { get; set; }
        public int TestId { get; set; }
        public int ParentID { get; set; }
        public string ItemId { get; set; }
        public string AppId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual CkCompanyGroup CkCompanyGroup { get; set; }
        public virtual CkItem CkItem { get; set; }
    }
}
