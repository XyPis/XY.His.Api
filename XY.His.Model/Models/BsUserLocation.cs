using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsUserLocation
    {
        public int ID { get; set; }
        public int OperId { get; set; }
        public int LocationId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
