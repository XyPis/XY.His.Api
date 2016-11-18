using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_OuOperDayInvoice
    {
        public string 单据号 { get; set; }
        public string 病人ID { get; set; }
        public string 卡号 { get; set; }
        public string 姓名 { get; set; }
        public string 病人大类 { get; set; }
        public string 病人类别 { get; set; }
        public string 科室 { get; set; }
        public string 收费员 { get; set; }
        public System.DateTime 收费日期 { get; set; }
        public decimal 总金额 { get; set; }
        public decimal 自付金额 { get; set; }
        public Nullable<decimal> 记账金额 { get; set; }
        public Nullable<decimal> 优惠金额 { get; set; }
        public decimal 应交金额 { get; set; }
        public decimal 凑整费 { get; set; }
    }
}
