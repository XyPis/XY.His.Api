using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsLocationRoomWindow
    {
        public int ID { get; set; }
        public int LocationId { get; set; }
        public string RoomWindowName { get; set; }
        public string PrinterName { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsLocation BsLocation { get; set; }
    }
}
