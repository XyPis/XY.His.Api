using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DgRoad
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short LsOpenType { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int LocationId { get; set; }
        public Nullable<bool> IsBaby { get; set; }
        public Nullable<bool> IsWomen { get; set; }
        public Nullable<bool> IsMen { get; set; }
        public Nullable<bool> IsOlder { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
