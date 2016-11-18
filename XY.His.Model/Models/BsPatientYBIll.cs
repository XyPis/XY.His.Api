using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsPatientYBIll
    {
        public int ID { get; set; }
        public int PatTyeId { get; set; }
        public int YbIllId { get; set; }
        public string MedicareNo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> HospId { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
        public virtual BsYbIllType BsYbIllType { get; set; }
        public virtual BsPatType BsPatType { get; set; }
    }
}
