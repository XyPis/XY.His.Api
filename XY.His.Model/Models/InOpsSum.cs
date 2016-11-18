using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InOpsSum
    {
        public int ID { get; set; }
        public int LocationId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public int SelectDateNum { get; set; }
        public int EmergencyNum { get; set; }
        public int OutPatientNum { get; set; }
        public string Memo { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
