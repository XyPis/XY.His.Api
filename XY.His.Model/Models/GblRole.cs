using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblRole
    {
        public GblRole()
        {
            this.BaseTableRoles = new List<BaseTableRole>();
            this.BsUserRoles = new List<BsUserRole>();
            this.GblBaseTableItems = new List<GblBaseTableItem>();
            this.GblRoleModules = new List<GblRoleModule>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<BaseTableRole> BaseTableRoles { get; set; }
        public virtual ICollection<BsUserRole> BsUserRoles { get; set; }
        public virtual ICollection<GblBaseTableItem> GblBaseTableItems { get; set; }
        public virtual ICollection<GblRoleModule> GblRoleModules { get; set; }
    }
}
