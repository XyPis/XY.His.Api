using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkResultGroup
    {
        public int ID { get; set; }
        public int TestGroupId { get; set; }
        public int CheckId { get; set; }
        public string CheckDesc { get; set; }
        public string Summary { get; set; }
        public string DoctorAdvice { get; set; }
        public Nullable<short> LsStatus { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<System.DateTime> ResultTime { get; set; }
        public Nullable<int> ResultOperId { get; set; }
        public Nullable<System.DateTime> AuthTime { get; set; }
        public Nullable<int> AuthOperId { get; set; }
        public virtual CkMain CkMain { get; set; }
        public virtual CkTestGroup CkTestGroup { get; set; }
    }
}
