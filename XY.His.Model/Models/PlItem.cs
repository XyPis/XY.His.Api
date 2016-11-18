using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class PlItem
    {
        public PlItem()
        {
            this.PlProjectItems = new List<PlProjectItem>();
        }

        public int ID { get; set; }
        public short GroupType { get; set; }
        public string Name { get; set; }
        public string Memo { get; set; }
        public Nullable<short> Hours { get; set; }
        public Nullable<int> ParentID { get; set; }
        public int OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ICollection<PlProjectItem> PlProjectItems { get; set; }
    }
}
