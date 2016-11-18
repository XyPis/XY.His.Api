using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsRegType
    {
        public BsRegType()
        {
            this.BsDoctors = new List<BsDoctor>();
            this.BsRegPatAmounts = new List<BsRegPatAmount>();
            this.OuLeadRegs = new List<OuLeadReg>();
            this.OuHosInfoes = new List<OuHosInfo>();
            this.OuDocRegTypes = new List<OuDocRegType>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<BsDoctor> BsDoctors { get; set; }
        public virtual ICollection<BsRegPatAmount> BsRegPatAmounts { get; set; }
        public virtual ICollection<OuLeadReg> OuLeadRegs { get; set; }
        public virtual ICollection<OuHosInfo> OuHosInfoes { get; set; }
        public virtual ICollection<OuDocRegType> OuDocRegTypes { get; set; }
    }
}
