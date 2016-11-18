using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RmSending
    {
        public int ID { get; set; }
        public int RoomId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
