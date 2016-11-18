using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuDiagCall
    {
        public int ID { get; set; }
        public int MzRegId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string PatName { get; set; }
        public string ActType { get; set; }
        public Nullable<bool> IsCall { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
    }
}
