using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OaDocAuth
    {
        public int ID { get; set; }
        public Nullable<int> DocId { get; set; }
        public Nullable<int> AuthOperId { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public bool IsAuth { get; set; }
        public Nullable<System.DateTime> AuthOperTime { get; set; }
        public Nullable<bool> IsReject { get; set; }
        public string RejectReason { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<short> LsReadClass { get; set; }
    }
}
