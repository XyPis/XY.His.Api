using System;
using System.Collections.Generic;
using XY.His.Domain.Gbl;

namespace XY.His.Domain.BS
{
    public partial class BsUserRole : EntityBase
    {
        public int ID { get; set; }
        public int OperId { get; set; }
        public int RoleId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
