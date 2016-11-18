using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VWInOutLocation
    {
        public Nullable<System.DateTime> OutOperTime { get; set; }
        public string InPatNo { get; set; }
        public string PatientName { get; set; }
        public string InLocation { get; set; }
        public string OutLocation { get; set; }
        public Nullable<System.DateTime> InOperTime { get; set; }
        public string OutOperName { get; set; }
        public string InOperName { get; set; }
        public Nullable<short> LsInStatus { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public Nullable<int> ID { get; set; }
        public int OutLocId { get; set; }
        public Nullable<int> InLocId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> LocIn { get; set; }
    }
}
