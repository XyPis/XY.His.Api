using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsGroupSub
    {
        public BsGroupSub()
        {
            this.BsGroupSub2 = new List<BsGroupSub2>();
            this.BsItems = new List<BsItem>();
        }

        public int ID { get; set; }
        public int MainId { get; set; }
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
        public virtual BsGroup BsGroup { get; set; }
        public virtual ICollection<BsGroupSub2> BsGroupSub2 { get; set; }
        public virtual ICollection<BsItem> BsItems { get; set; }
    }
}
