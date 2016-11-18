using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblQuestion
    {
        public int ID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public int SystemId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
