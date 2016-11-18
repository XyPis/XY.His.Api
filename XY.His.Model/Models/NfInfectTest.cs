using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class NfInfectTest
    {
        public NfInfectTest()
        {
            this.NfInfectTestBacterias = new List<NfInfectTestBacteria>();
        }

        public int ID { get; set; }
        public int InfectId { get; set; }
        public string LabNo { get; set; }
        public int SourceId { get; set; }
        public System.DateTime LabTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsLabSource BsLabSource { get; set; }
        public virtual NfInfect NfInfect { get; set; }
        public virtual ICollection<NfInfectTestBacteria> NfInfectTestBacterias { get; set; }
    }
}
