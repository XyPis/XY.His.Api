using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblSystemFunction
    {
        public GblSystemFunction()
        {
            this.GblModules = new List<GblModule>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ICollection<GblModule> GblModules { get; set; }
    }
}
