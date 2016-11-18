using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkTestGroup
    {
        public CkTestGroup()
        {
            this.CkReports = new List<CkReport>();
            this.CkResults = new List<CkResult>();
            this.CkResultGroups = new List<CkResultGroup>();
            this.CkTestTypes = new List<CkTestType>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<CkReport> CkReports { get; set; }
        public virtual ICollection<CkResult> CkResults { get; set; }
        public virtual ICollection<CkResultGroup> CkResultGroups { get; set; }
        public virtual ICollection<CkTestType> CkTestTypes { get; set; }
    }
}
