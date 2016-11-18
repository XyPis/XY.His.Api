using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class NfInfectTestBacteria
    {
        public int ID { get; set; }
        public int TestId { get; set; }
        public int BacteriaId { get; set; }
        public Nullable<int> BaseDrugId { get; set; }
        public Nullable<short> LsResult { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsBacteria BsBacteria { get; set; }
        public virtual BsBaseDrug BsBaseDrug { get; set; }
        public virtual NfInfectTest NfInfectTest { get; set; }
    }
}
