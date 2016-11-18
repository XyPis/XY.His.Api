using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsBacteriaType
    {
        public BsBacteriaType()
        {
            this.BsBacterias = new List<BsBacteria>();
            this.BsBacteriaGrams = new List<BsBacteriaGram>();
            this.BsBacteriaShus = new List<BsBacteriaShu>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual ICollection<BsBacteria> BsBacterias { get; set; }
        public virtual ICollection<BsBacteriaGram> BsBacteriaGrams { get; set; }
        public virtual ICollection<BsBacteriaShu> BsBacteriaShus { get; set; }
    }
}
