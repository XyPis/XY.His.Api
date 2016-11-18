using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblEMRFile
    {
        public int ID { get; set; }
        public Nullable<int> LocationId { get; set; }
        public int CatalogId { get; set; }
        public string XSDFile { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual GblEMRCatalog GblEMRCatalog { get; set; }
    }
}
