using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OaDocument
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> GroupMainId { get; set; }
        public Nullable<int> GroupSubId { get; set; }
        public Nullable<short> LsOpenType { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string InActiveReason { get; set; }
        public Nullable<System.DateTime> InActiveTime { get; set; }
        public Nullable<int> InActiveOperID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<short> IconIndex { get; set; }
        public Nullable<short> Security { get; set; }
        public string Password { get; set; }
    }
}
