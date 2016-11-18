using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InOutLocation
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public int BedId { get; set; }
        public int OutLocId { get; set; }
        public Nullable<System.DateTime> OutOperTime { get; set; }
        public Nullable<int> OutOperId { get; set; }
        public Nullable<bool> isReceived { get; set; }
        public Nullable<int> InLocId { get; set; }
        public Nullable<System.DateTime> InOperTime { get; set; }
        public Nullable<int> InOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsBed BsBed { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsLocation BsLocation1 { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsUser BsUser1 { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
