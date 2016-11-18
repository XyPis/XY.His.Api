using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InEmrXml
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public int CatalogId { get; set; }
        public string XmlField { get; set; }
        public string XmlValue { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> InEmrId { get; set; }
        public virtual GblEMRCatalog GblEMRCatalog { get; set; }
        public virtual InEMR InEMR { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
