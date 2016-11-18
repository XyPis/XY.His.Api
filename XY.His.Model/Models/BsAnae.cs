using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsAnae
    {
        public BsAnae()
        {
            this.BsAnaeItems = new List<BsAnaeItem>();
            this.BsOPS = new List<BsOP>();
            this.InHosOps = new List<InHosOp>();
            this.NfInfects = new List<NfInfect>();
            this.OpsApplies = new List<OpsApply>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string FunctionM { get; set; }
        public string Effect { get; set; }
        public string Tabu { get; set; }
        public string MEMO { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<BsAnaeItem> BsAnaeItems { get; set; }
        public virtual ICollection<BsOP> BsOPS { get; set; }
        public virtual ICollection<InHosOp> InHosOps { get; set; }
        public virtual ICollection<NfInfect> NfInfects { get; set; }
        public virtual ICollection<OpsApply> OpsApplies { get; set; }
    }
}
