using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblEmail
    {
        public GblEmail()
        {
            this.GblEmailUsers = new List<GblEmailUser>();
        }

        public int ID { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string FileName { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsSign { get; set; }
        public bool IsPriority { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual ICollection<GblEmailUser> GblEmailUsers { get; set; }
    }
}
