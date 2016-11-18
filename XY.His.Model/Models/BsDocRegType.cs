using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsDocRegType
    {
        public BsDocRegType()
        {
            this.OuDocSpanSubs = new List<OuDocSpanSub>();
        }

        public int ID { get; set; }
        public int DoctorId { get; set; }
        public int RegTypeId { get; set; }
        public int LocationId { get; set; }
        public Nullable<short> LimitNum { get; set; }
        public Nullable<System.DateTime> LastLimitDate { get; set; }
        public Nullable<short> LastLimitNum { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short WeekDay { get; set; }
        public int TimeSpanId { get; set; }
        public string RoomNo { get; set; }
        public Nullable<int> Diagroomid { get; set; }
        public virtual ICollection<OuDocSpanSub> OuDocSpanSubs { get; set; }
    }
}
