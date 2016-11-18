using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblEmailUser
    {
        public int ID { get; set; }
        public int EmailId { get; set; }
        public int OperId { get; set; }
        public Nullable<bool> IsRead { get; set; }
        public Nullable<System.DateTime> ReadTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual GblEmail GblEmail { get; set; }
    }
}
