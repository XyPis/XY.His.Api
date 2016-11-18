using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblOnliner
    {
        public int ID { get; set; }
        public int UserId { get; set; }
        public string WorkStationName { get; set; }
        public string LockIp { get; set; }
        public System.DateTime LoginTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
