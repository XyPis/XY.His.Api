using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblCatalogKey
    {
        public int ID { get; set; }
        public int CatalogId { get; set; }
        public string XmlField { get; set; }
        public string KeyFile { get; set; }
        public string TmpWord { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual GblEMRCatalog GblEMRCatalog { get; set; }
    }
}
