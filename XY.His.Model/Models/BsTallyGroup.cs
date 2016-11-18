using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsTallyGroup
    {
        public BsTallyGroup()
        {
            this.BsItemYbs = new List<BsItemYb>();
            this.BsYbCodeSpecs = new List<BsYbCodeSpec>();
            this.OuGFReports = new List<OuGFReport>();
            this.BsTallyTypes = new List<BsTallyType>();
            this.InGfReports = new List<InGfReport>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsGf { get; set; }
        public bool IsYb { get; set; }
        public string YbHospNo { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<BsItemYb> BsItemYbs { get; set; }
        public virtual BsItemYbTip BsItemYbTip { get; set; }
        public virtual ICollection<BsYbCodeSpec> BsYbCodeSpecs { get; set; }
        public virtual ICollection<OuGFReport> OuGFReports { get; set; }
        public virtual ICollection<BsTallyType> BsTallyTypes { get; set; }
        public virtual ICollection<InGfReport> InGfReports { get; set; }
    }
}
