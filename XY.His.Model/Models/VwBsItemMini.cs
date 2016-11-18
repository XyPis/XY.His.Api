using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwBsItemMini
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public string StrokeCode { get; set; }
        public bool IsActive { get; set; }
        public string OtherCode { get; set; }
        public string LongDesc { get; set; }
        public string EngDesc { get; set; }
        public string Spec { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public string Name { get; set; }
        public string UnitInName { get; set; }
        public short LsGfType { get; set; }
        public bool IsRpForbid { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public bool OptionPrice { get; set; }
        public Nullable<bool> IsSpecial { get; set; }
        public short LsRpType { get; set; }
        public string UnitDiagName { get; set; }
        public decimal PriceIn { get; set; }
        public decimal PriceDiag { get; set; }
        public string Memo { get; set; }
    }
}
