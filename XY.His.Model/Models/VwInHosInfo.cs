using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInHosInfo
    {
        public int ID { get; set; }
        public string InPatNo { get; set; }
        public string Name { get; set; }
        public string SexName { get; set; }
        public System.DateTime InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public string Company { get; set; }
        public string WorkType { get; set; }
        public string PatType { get; set; }
        public string Doctor { get; set; }
        public string Bed { get; set; }
        public string Residence { get; set; }
        public string LsInStatusName { get; set; }
        public string LonIn { get; set; }
        public string Location { get; set; }
    }
}
