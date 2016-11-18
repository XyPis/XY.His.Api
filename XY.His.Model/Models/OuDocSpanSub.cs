using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuDocSpanSub
    {
        public int id { get; set; }
        public Nullable<int> weekplanid { get; set; }
        public Nullable<int> spanlimitnum { get; set; }
        public Nullable<int> sublimitnum { get; set; }
        public Nullable<int> timespansubid { get; set; }
        public string f1 { get; set; }
        public string f2 { get; set; }
        public string f3 { get; set; }
        public string f4 { get; set; }
        public virtual BsDocRegType BsDocRegType { get; set; }
        public virtual BsRegSpanSub BsRegSpanSub { get; set; }
    }
}
