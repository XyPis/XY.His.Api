using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RdLessonMan
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> LessonId { get; set; }
        public virtual BsPatient BsPatient { get; set; }
    }
}
