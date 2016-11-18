using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsUserPoint
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public int UserId { get; set; }
        public int OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
