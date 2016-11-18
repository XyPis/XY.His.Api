using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsXdRp
    {
        public BsXdRp()
        {
            this.DgIllXdRps = new List<DgIllXdRp>();
            this.BsXdRpDtls = new List<BsXdRpDtl>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string GroupMain { get; set; }
        public string GroupSub { get; set; }
        public Nullable<int> OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short LsOpenType { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int LocationId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<int> TestId { get; set; }
        public Nullable<short> LsInOut { get; set; }
        public Nullable<int> ExecLocId { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsLocation BsLocation1 { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual ICollection<DgIllXdRp> DgIllXdRps { get; set; }
        public virtual ICollection<BsXdRpDtl> BsXdRpDtls { get; set; }
    }
}
