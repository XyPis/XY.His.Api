using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsLocService
    {
        public int ID { get; set; }
        public int LocId { get; set; }
        public int LogisticServeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual CsAppDeptType CsAppDeptType { get; set; }
    }
}
