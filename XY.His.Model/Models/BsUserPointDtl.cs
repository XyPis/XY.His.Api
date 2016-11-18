using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsUserPointDtl
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public decimal Point { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
