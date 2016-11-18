using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class EmrReCord
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> INTIME { get; set; }
        public Nullable<System.DateTime> OUTTIME { get; set; }
        public Nullable<int> HOSPID { get; set; }
        public Nullable<System.DateTime> MODIFYTIME { get; set; }
        public string RECCONTENT { get; set; }
        public Nullable<System.DateTime> FIRSTRETIME { get; set; }
        public Nullable<int> INEMRID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> ISMODIFY { get; set; }
        public Nullable<int> LocationId { get; set; }
    }
}
