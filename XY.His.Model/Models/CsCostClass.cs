using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsCostClass
    {
        public CsCostClass()
        {
            this.CsCostClassRelas = new List<CsCostClassRela>();
            this.CsCostSubjs = new List<CsCostSubj>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string SuppItemCode { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string LastLevel { get; set; }
        public string PyCode { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string WbCode { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public virtual ICollection<CsCostClassRela> CsCostClassRelas { get; set; }
        public virtual ICollection<CsCostSubj> CsCostSubjs { get; set; }
    }
}
