using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class NfInfectReason
    {
        public int ID { get; set; }
        public int InfectId { get; set; }
        public int InfReasonId { get; set; }
        public Nullable<bool> IsRelated { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsInfReason BsInfReason { get; set; }
        public virtual NfInfect NfInfect { get; set; }
    }
}
