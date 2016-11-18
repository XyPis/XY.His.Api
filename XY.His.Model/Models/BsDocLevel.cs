using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsDocLevel
    {
        public BsDocLevel()
        {
            this.BsLimitDocLevs = new List<BsLimitDocLev>();
            this.BsPatTypeLimits = new List<BsPatTypeLimit>();
            this.BsUsers = new List<BsUser>();
            this.BsDoctors = new List<BsDoctor>();
            this.OpsMen = new List<OpsMan>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public int OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<BsLimitDocLev> BsLimitDocLevs { get; set; }
        public virtual ICollection<BsPatTypeLimit> BsPatTypeLimits { get; set; }
        public virtual ICollection<BsUser> BsUsers { get; set; }
        public virtual ICollection<BsDoctor> BsDoctors { get; set; }
        public virtual ICollection<OpsMan> OpsMen { get; set; }
    }
}
