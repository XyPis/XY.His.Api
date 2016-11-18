using System;
using System.Collections.Generic;
using XY.His.Domain.BS;
using XY.His.Domain.IN;

namespace XY.His.Domain.RM
{
    public partial class RmZyOutDtl : EntityBase
    {
        public int ID { get; set; }
        public int BillId { get; set; }
        public Nullable<int> InBatchId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public decimal DrugNum { get; set; }
        public decimal BackNum { get; set; }
        public decimal RetailPrice { get; set; }
        public decimal StockPrice { get; set; }
        public Nullable<int> ReqItemId { get; set; }
        public Nullable<int> RecipeItemId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }  
    }
}
