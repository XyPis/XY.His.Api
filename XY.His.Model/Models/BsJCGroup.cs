using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsJCGroup
    {
        public BsJCGroup()
        {
            this.BsJCGroupAttaches = new List<BsJCGroupAttach>();
            this.BsJCGroupItems = new List<BsJCGroupItem>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<BsJCGroupAttach> BsJCGroupAttaches { get; set; }
        public virtual ICollection<BsJCGroupItem> BsJCGroupItems { get; set; }
    }
}
