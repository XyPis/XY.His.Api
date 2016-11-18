using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class PlProjectItem
    {
        public int ID { get; set; }
        public int ProjId { get; set; }
        public int ItemId { get; set; }
        public string Memo { get; set; }
        public short Hours { get; set; }
        public Nullable<System.DateTime> BeginPlan { get; set; }
        public Nullable<System.DateTime> EndPlan { get; set; }
        public Nullable<bool> IsClose { get; set; }
        public Nullable<short> HoursFact { get; set; }
        public Nullable<System.DateTime> EndFact { get; set; }
        public Nullable<int> ChargeOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual PlItem PlItem { get; set; }
        public virtual PlProject PlProject { get; set; }
    }
}
