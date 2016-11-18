using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RdLesson
    {
        public int ID { get; set; }
        public int LessonTypeId { get; set; }
        public Nullable<System.DateTime> LessonTime { get; set; }
        public string Location { get; set; }
        public Nullable<short> Numbers { get; set; }
        public string Company { get; set; }
        public string Occupation { get; set; }
        public string Teacher { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> OperID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
