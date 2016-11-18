using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwBsPatType
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public decimal DiscDiag { get; set; }
        public decimal DiscIn { get; set; }
        public Nullable<short> LsGFPatType { get; set; }
        public string LsGFPatTypeName { get; set; }
        public int TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public bool IsGf { get; set; }
        public bool IsYb { get; set; }
        public decimal ArrearAmount { get; set; }
    }
}
