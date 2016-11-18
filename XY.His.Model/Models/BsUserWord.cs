using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsUserWord
    {
        public int ID { get; set; }
        public int OperId { get; set; }
        public string KeyType { get; set; }
        public string Content { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<short> IconIndex { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
