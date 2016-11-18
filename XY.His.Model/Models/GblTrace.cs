using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblTrace
    {
        public int ID { get; set; }
        public string SqlString { get; set; }
        public string WhereCondition { get; set; }
        public string OrderByExpression { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
