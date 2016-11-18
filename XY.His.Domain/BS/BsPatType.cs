using System;
using System.Collections.Generic;

namespace XY.His.Domain.BS
{
    public partial class BsPatType : EntityBase
    {        
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal LimitFee { get; set; }
        public decimal LimitIn { get; set; }
        public decimal ArrearFei { get; set; }
        public decimal DiscDiag { get; set; }
        public decimal DiscIn { get; set; }
        public string HeadNo { get; set; }
        public int TallyTypeId { get; set; }
        public decimal ArrearAmount { get; set; }
        public Nullable<short> LsGFPatType { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public bool IsActive { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<decimal> TwoDiscIn1 { get; set; }
        public Nullable<decimal> TwoDiscIn2 { get; set; }    
    }
}
