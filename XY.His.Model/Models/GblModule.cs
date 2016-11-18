using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblModule
    {
        public GblModule()
        {
            this.BsUserModules = new List<BsUserModule>();
            this.GblRoleModules = new List<GblRoleModule>();
        }

        public int ID { get; set; }
        public Nullable<int> FunctionID { get; set; }
        public Nullable<int> MenuId { get; set; }
        public int OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ICollection<BsUserModule> BsUserModules { get; set; }
        public virtual GblSystemFunction GblSystemFunction { get; set; }
        public virtual GblSystemMenu GblSystemMenu { get; set; }
        public virtual ICollection<GblRoleModule> GblRoleModules { get; set; }
    }
}
