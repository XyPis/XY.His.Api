using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsItemIllType
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public int IllTypeId { get; set; }
        public string YbCode { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
