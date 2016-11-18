using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblEMRBranch
    {
        public int ID { get; set; }
        public Nullable<int> BranchId { get; set; }
        public int CatalogId { get; set; }
        public string XSDFile { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsBranch BsBranch { get; set; }
        public virtual GblEMRCatalog GblEMRCatalog { get; set; }
    }
}
