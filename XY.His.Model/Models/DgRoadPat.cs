using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DgRoadPat
    {
        public int ID { get; set; }
        public Nullable<int> HospId { get; set; }
        public int RoadId { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<bool> IsChk { get; set; }
        public Nullable<System.DateTime> ChkOperTime { get; set; }
        public Nullable<int> ChkOperID { get; set; }
    }
}
