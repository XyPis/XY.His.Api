using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkLabMic
    {
        public CkLabMic()
        {
            this.CkLabMicDtls = new List<CkLabMicDtl>();
        }

        public int ID { get; set; }
        public int LabId { get; set; }
        public int BacteriaId { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public bool IsPrint { get; set; }
        public Nullable<System.DateTime> PrintTime { get; set; }
        public Nullable<int> PrintOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsBacteria BsBacteria { get; set; }
        public virtual CkLab CkLab { get; set; }
        public virtual ICollection<CkLabMicDtl> CkLabMicDtls { get; set; }
    }
}
