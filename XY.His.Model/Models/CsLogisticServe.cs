using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsLogisticServe
    {
        public CsLogisticServe()
        {
            this.CsStLogisticServes = new List<CsStLogisticServe>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Unit { get; set; }
        public Nullable<decimal> UnitPrice { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ICollection<CsStLogisticServe> CsStLogisticServes { get; set; }
    }
}
