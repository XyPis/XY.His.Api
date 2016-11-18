using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsRegSpanSub
    {
        public BsRegSpanSub()
        {
            this.OuDocSpanSubs = new List<OuDocSpanSub>();
            this.OuHosInfoes = new List<OuHosInfo>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string TimeBegin { get; set; }
        public string TimeEnd { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<int> TimeSpanId { get; set; }
        public virtual ICollection<OuDocSpanSub> OuDocSpanSubs { get; set; }
        public virtual ICollection<OuHosInfo> OuHosInfoes { get; set; }
    }
}
