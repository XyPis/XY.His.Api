using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OaSchedule
    {
        public int ID { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Subject { get; set; }
        public string Location { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string Description { get; set; }
        public Nullable<int> LabelId { get; set; }
        public Nullable<System.DateTime> Reminder { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
