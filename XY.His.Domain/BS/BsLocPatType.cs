using System;
using System.Collections.Generic;

namespace XY.His.Domain.BS
{
    public partial class BsLocPatType : EntityBase
    {
        public int ID { get; set; }
        public int LocationId { get; set; }
        public int PatTypeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
