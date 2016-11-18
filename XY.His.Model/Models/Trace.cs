using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Trace
    {
        public int ID { get; set; }
        public System.DateTime CreateDate { get; set; }
        public int UserID { get; set; }
        public string IP { get; set; }
        public string Messages { get; set; }
        public string Type { get; set; }
        public string OperateType { get; set; }
        public Nullable<int> RecordId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
