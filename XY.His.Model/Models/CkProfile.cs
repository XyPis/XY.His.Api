using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkProfile
    {
        public int ID { get; set; }
        public int ProfileId { get; set; }
        public int TestId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> ItemId { get; set; }
    }
}
