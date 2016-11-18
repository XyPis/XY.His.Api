using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InChinRicipeDtl
    {
        public InChinRicipeDtl()
        {
            this.RmZyOutDtls = new List<RmZyOutDtl>();
        }

        public int ID { get; set; }
        public int RecipeId { get; set; }
        public int ItemId { get; set; }
        public decimal Dosage { get; set; }
        public int UnitTakeId { get; set; }
        public short LsDecoctWay { get; set; }
        public string Memo { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<int> DetailId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual InChinRicipe InChinRicipe { get; set; }
        public virtual ICollection<RmZyOutDtl> RmZyOutDtls { get; set; }
    }
}
