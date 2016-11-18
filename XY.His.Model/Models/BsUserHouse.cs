using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsUserHouse
    {
        public int ID { get; set; }
        public int OperId { get; set; }
        public int HouseId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsHouse BsHouse { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
