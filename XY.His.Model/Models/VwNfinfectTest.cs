using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwNfinfectTest
    {
        public int TestId { get; set; }
        public int InfectId { get; set; }
        public string LabNo { get; set; }
        public string LsResultName { get; set; }
        public System.DateTime LabTime { get; set; }
        public string Bacteria { get; set; }
        public string BaseDrugTest { get; set; }
        public string LabSource { get; set; }
        public string BacteriaGrams { get; set; }
        public string BacteriaShu { get; set; }
        public string BacteriaType { get; set; }
        public string BacteriaStandType { get; set; }
    }
}
