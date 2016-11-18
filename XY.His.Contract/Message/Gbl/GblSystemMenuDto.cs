using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.Gbl
{
    public partial class GblSystemMenuDto : DtoBase
    {
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
    }
}
