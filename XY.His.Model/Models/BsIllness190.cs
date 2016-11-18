using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsIllness190
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public string OtherCode { get; set; }
        public string Name { get; set; }
        public string OtherDesc { get; set; }
        public string GroupMain { get; set; }
        public string GroupSub { get; set; }
        public string GroupSSub { get; set; }
        public Nullable<int> BelongIcd { get; set; }
        public bool IsSum { get; set; }
        public Nullable<decimal> FeeHigh { get; set; }
        public Nullable<short> DayHigh { get; set; }
        public int OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<bool> IsInfectious { get; set; }
    }
}
