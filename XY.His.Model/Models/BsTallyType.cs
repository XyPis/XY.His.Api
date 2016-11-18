using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsTallyType
    {
        public BsTallyType()
        {
            this.BsPatTypes = new List<BsPatType>();
            this.BsPatTypeYbIlls = new List<BsPatTypeYbIll>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<BsPatType> BsPatTypes { get; set; }
        public virtual ICollection<BsPatTypeYbIll> BsPatTypeYbIlls { get; set; }
        public virtual BsTallyGroup BsTallyGroup { get; set; }
    }
}
