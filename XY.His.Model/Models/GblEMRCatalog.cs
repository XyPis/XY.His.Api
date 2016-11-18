using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblEMRCatalog
    {
        public GblEMRCatalog()
        {
            this.GblCatalogExcepts = new List<GblCatalogExcept>();
            this.GblCatalogJoins = new List<GblCatalogJoin>();
            this.GblCatalogJoins1 = new List<GblCatalogJoin>();
            this.GblCatalogKeys = new List<GblCatalogKey>();
            this.GblEMRBranches = new List<GblEMRBranch>();
            this.GblEMRFiles = new List<GblEMRFile>();
            this.InEMRs = new List<InEMR>();
            this.InEmrRtfs = new List<InEmrRtf>();
            this.InEmrXmls = new List<InEmrXml>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public string InfoPathFile { get; set; }
        public Nullable<short> LsCompareType { get; set; }
        public Nullable<short> AheadHours { get; set; }
        public virtual ICollection<GblCatalogExcept> GblCatalogExcepts { get; set; }
        public virtual ICollection<GblCatalogJoin> GblCatalogJoins { get; set; }
        public virtual ICollection<GblCatalogJoin> GblCatalogJoins1 { get; set; }
        public virtual ICollection<GblCatalogKey> GblCatalogKeys { get; set; }
        public virtual ICollection<GblEMRBranch> GblEMRBranches { get; set; }
        public virtual ICollection<GblEMRFile> GblEMRFiles { get; set; }
        public virtual ICollection<InEMR> InEMRs { get; set; }
        public virtual ICollection<InEmrRtf> InEmrRtfs { get; set; }
        public virtual ICollection<InEmrXml> InEmrXmls { get; set; }
    }
}
