using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsRegPatAmount
    {
        public int ID { get; set; }
        public int RegTypeID { get; set; }
        public int PatTypeID { get; set; }
        public decimal RegFee { get; set; }
        public decimal DiagnoFee { get; set; }
        public decimal OtherFee1 { get; set; }
        public decimal OtherFee2 { get; set; }
        public decimal PaySel { get; set; }
        public decimal TallyFee { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsPatType BsPatType { get; set; }
        public virtual BsRegType BsRegType { get; set; }
    }
}
