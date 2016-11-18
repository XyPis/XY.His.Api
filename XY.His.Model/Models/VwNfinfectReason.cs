using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwNfinfectReason
    {
        public int InfectId { get; set; }
        public Nullable<bool> IsRelated { get; set; }
        public string InfReason { get; set; }
        public string InfReasonType { get; set; }
    }
}
