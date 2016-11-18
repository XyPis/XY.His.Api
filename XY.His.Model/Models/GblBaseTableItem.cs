using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblBaseTableItem
    {
        public GblBaseTableItem()
        {
            this.BaseTableRoles = new List<BaseTableRole>();
        }

        public int ID { get; set; }
        public int ParentID { get; set; }
        public string BaseTable { get; set; }
        public string Name { get; set; }
        public string BLLClassName { get; set; }
        public string ModelClassName { get; set; }
        public string ConfigType { get; set; }
        public bool IsTable { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public Nullable<int> RoleId { get; set; }
        public string OrderField { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<bool> IsToWmr { get; set; }
        public virtual ICollection<BaseTableRole> BaseTableRoles { get; set; }
        public virtual GblRole GblRole { get; set; }
    }
}
