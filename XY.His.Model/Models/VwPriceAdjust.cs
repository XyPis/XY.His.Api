using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwPriceAdjust
    {
        public string BillNo { get; set; }
        public System.DateTime NotifyDate { get; set; }
        public string DispUnit { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string Memo { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Spec { get; set; }
        public string PNo { get; set; }
        public int UnitId { get; set; }
        public Nullable<int> CompId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal OldPrice { get; set; }
        public decimal NewPrice { get; set; }
        public decimal ProfLoss { get; set; }
        public int ItemId { get; set; }
    }
}
