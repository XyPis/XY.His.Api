using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblSystemMenu
    {
        public GblSystemMenu()
        {
            this.BsUserMenus = new List<BsUserMenu>();
            this.BsUserWindows = new List<BsUserWindow>();
            this.GblFuctions = new List<GblFuction>();
            this.GblModules = new List<GblModule>();
            this.TmpItems = new List<TmpItem>();
        }

        public int ID { get; set; }
        public int SystemId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<short> IconIndex { get; set; }
        public string Hint { get; set; }
        public string Shortcut { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public Nullable<bool> IsMostUsed { get; set; }
        public Nullable<bool> IsBeginGroup { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ICollection<BsUserMenu> BsUserMenus { get; set; }
        public virtual ICollection<BsUserWindow> BsUserWindows { get; set; }
        public virtual ICollection<GblFuction> GblFuctions { get; set; }
        public virtual ICollection<GblModule> GblModules { get; set; }
        public virtual GblSystem GblSystem { get; set; }
        public virtual ICollection<TmpItem> TmpItems { get; set; }
    }
}
