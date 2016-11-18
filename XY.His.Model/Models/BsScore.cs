using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsScore
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public int TestPaperId { get; set; }
        public int Score { get; set; }
        public string Answer { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
