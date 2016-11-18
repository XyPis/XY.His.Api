using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DgIllGroup
    {
        public DgIllGroup()
        {
            this.DgIllCures = new List<DgIllCure>();
        }

        public int ID { get; set; }
        public Nullable<int> IcdId { get; set; }
        public string GroupDesc { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsIllness BsIllness { get; set; }
        public virtual ICollection<DgIllCure> DgIllCures { get; set; }
    }
}
