using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblFunTrace
    {
        public int ID { get; set; }
        public Nullable<byte> DebugMode { get; set; }
        public Nullable<int> FuntionId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> UserID { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual GblFuction GblFuction { get; set; }
    }
}
