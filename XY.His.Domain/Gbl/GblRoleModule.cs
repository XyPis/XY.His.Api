using System;
using System.Collections.Generic;

namespace XY.His.Domain.Gbl
{
    public partial class GblRoleModule : EntityBase
    {
        public int ID { get; set; }
        public int RoleId { get; set; }
        public int ModuleId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
