using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_mmzy_mztf
    {
        public string 单据号 { get; set; }
        public string 原单据号 { get; set; }
        public string 退费员 { get; set; }
        public string 收费员 { get; set; }
        public System.DateTime 收费日期 { get; set; }
        public string 结算种类 { get; set; }
        public Nullable<System.DateTime> 退费日期 { get; set; }
        public Nullable<decimal> 总金额 { get; set; }
        public decimal 自付金额 { get; set; }
        public Nullable<decimal> 记账金额 { get; set; }
        public int 优惠金额 { get; set; }
        public int ID { get; set; }
        public string 病人姓名 { get; set; }
        public string 流水号 { get; set; }
    }
}
