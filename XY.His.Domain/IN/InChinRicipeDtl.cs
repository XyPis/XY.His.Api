using System;
using System.Collections.Generic;
using XY.His.Domain.RM;
using XY.His.Domain.BS;

namespace XY.His.Domain.IN
{
    public partial class InChinRicipeDtl : EntityBase
    {
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
    }
}
