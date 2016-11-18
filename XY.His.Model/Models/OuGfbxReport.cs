using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuGfbxReport
    {
        public int ID { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public System.DateTime BeginTime { get; set; }
        public System.DateTime EndTime { get; set; }
        public int PatType { get; set; }
        public int TypeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsPatType BsPatType { get; set; }
    }
}
