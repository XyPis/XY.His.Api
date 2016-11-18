using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OaDocReader
    {
        public int ID { get; set; }
        public Nullable<int> DocId { get; set; }
        public Nullable<int> AllowOperId { get; set; }
        public Nullable<System.DateTime> ExpireTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
