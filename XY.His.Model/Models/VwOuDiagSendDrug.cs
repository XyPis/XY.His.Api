using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuDiagSendDrug
    {
        public int MzRegId { get; set; }
        public short LsRepType { get; set; }
        public string RecipeNum { get; set; }
        public System.DateTime RecipeTime { get; set; }
        public Nullable<short> HowMany { get; set; }
        public bool IsPriority { get; set; }
        public bool IsPend { get; set; }
        public string Name { get; set; }
        public int ListNum { get; set; }
        public short GroupNum { get; set; }
        public string Code { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public decimal Totality { get; set; }
        public string UnitName { get; set; }
        public decimal PriceDiag { get; set; }
        public string UsageName { get; set; }
        public string MzRegNo { get; set; }
    }
}
