using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_ItemTrace
    {
        public Nullable<System.DateTime> CreateDate { get; set; }
        public string UserName { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public string CompanyName { get; set; }
        public int ItemTraceType { get; set; }
        public Nullable<int> UserID { get; set; }
        public int ItemId { get; set; }
        public short LsRpType { get; set; }
    }
}
