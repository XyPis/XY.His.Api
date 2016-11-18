using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsQuestion
    {
        public int ID { get; set; }
        public string Question { get; set; }
        public string Answer { get; set; }
        public string OptionA { get; set; }
        public string OptionB { get; set; }
        public string OptionC { get; set; }
        public string OptionD { get; set; }
        public int SubjectId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsSubject BsSubject { get; set; }
    }
}
