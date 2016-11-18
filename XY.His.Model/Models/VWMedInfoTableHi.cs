using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VWMedInfoTableHi
    {
        public string MedOnlyCode { get; set; }
        public string MedName { get; set; }
        public string MedPack { get; set; }
        public string MedUnitPack { get; set; }
        public string Medunit { get; set; }
        public Nullable<decimal> MedConvercof { get; set; }
        public string MedPYCode { get; set; }
        public string MedFactory { get; set; }
        public decimal MedUnitPrice { get; set; }
    }
}
