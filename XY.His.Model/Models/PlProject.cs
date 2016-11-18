using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class PlProject
    {
        public PlProject()
        {
            this.PlProjectItems = new List<PlProjectItem>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public int ChargeOperId { get; set; }
        public System.DateTime RecTime { get; set; }
        public Nullable<bool> IsClose { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual ICollection<PlProjectItem> PlProjectItems { get; set; }
    }
}
