using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class ElBaseDtl
    {
        public ElBaseDtl()
        {
            this.ElPatFormVDtls = new List<ElPatFormVDtl>();
        }

        public int ID { get; set; }
        public Nullable<int> ElId { get; set; }
        public Nullable<int> ElId1 { get; set; }
        public Nullable<bool> IsReadOnly { get; set; }
        public Nullable<bool> IsAllowSort { get; set; }
        public Nullable<short> Width { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ICollection<ElPatFormVDtl> ElPatFormVDtls { get; set; }
    }
}
