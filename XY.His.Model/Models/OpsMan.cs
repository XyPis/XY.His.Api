using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OpsMan
    {
        public int ID { get; set; }
        public int ApplyId { get; set; }
        public int UserId { get; set; }
        public short LsRole { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> DocLevId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Memo { get; set; }
        public virtual BsDocLevel BsDocLevel { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual OpsApply OpsApply { get; set; }
    }
}
