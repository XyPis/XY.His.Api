using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RmGroupPrintNum
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> PrintDate { get; set; }
        public Nullable<int> Group1PageNum { get; set; }
        public Nullable<int> Group2PageNum { get; set; }
        public Nullable<int> Group3PageNum { get; set; }
        public Nullable<int> Group4PageNum { get; set; }
        public Nullable<int> Group5PageNum { get; set; }
        public Nullable<int> Group6PageNum { get; set; }
        public Nullable<int> PreviousGroup1PageNum { get; set; }
        public Nullable<int> PreviousGroup2PageNum { get; set; }
        public Nullable<int> PreviousGroup3PageNum { get; set; }
        public Nullable<int> PreviousGroup4PageNum { get; set; }
        public Nullable<int> PreviousGroup5PageNum { get; set; }
        public Nullable<int> PreviousGroup6PageNum { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
