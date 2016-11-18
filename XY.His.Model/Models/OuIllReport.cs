using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuIllReport
    {
        public int ID { get; set; }
        public int MzRegId { get; set; }
        public string XML { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
    }
}
