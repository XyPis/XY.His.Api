using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TrScheLine
    {
        public TrScheLine()
        {
            this.TrSchedulers = new List<TrScheduler>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string Memo { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> LabelId { get; set; }
        public Nullable<System.DateTime> StartTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual ICollection<TrScheduler> TrSchedulers { get; set; }
    }
}
