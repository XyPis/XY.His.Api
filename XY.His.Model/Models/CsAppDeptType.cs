using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsAppDeptType
    {
        public CsAppDeptType()
        {
            this.BsLocations = new List<BsLocation>();
            this.CsLocServices = new List<CsLocService>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ICollection<BsLocation> BsLocations { get; set; }
        public virtual ICollection<CsLocService> CsLocServices { get; set; }
    }
}
