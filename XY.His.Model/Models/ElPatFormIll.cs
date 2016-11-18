using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class ElPatFormIll
    {
        public int ID { get; set; }
        public Nullable<int> PatFormId { get; set; }
        public Nullable<int> ListNum { get; set; }
        public Nullable<int> IcdId { get; set; }
        public string IllDesc { get; set; }
        public Nullable<short> LsInOut { get; set; }
        public Nullable<short> LsWestChin { get; set; }
        public Nullable<int> Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsIllness BsIllness { get; set; }
    }
}
