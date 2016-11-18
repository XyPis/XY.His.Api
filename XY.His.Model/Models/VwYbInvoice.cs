using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwYbInvoice
    {
        public System.DateTime 结算日期 { get; set; }
        public string 序号 { get; set; }
        public string 住院号 { get; set; }
        public string 发票号 { get; set; }
        public string 姓名 { get; set; }
        public string 科室 { get; set; }
        public decimal 总金额 { get; set; }
        public Nullable<decimal> 统筹支付金额 { get; set; }
        public Nullable<decimal> 个人自付金额 { get; set; }
        public string 病人类别 { get; set; }
        public string 病人大类 { get; set; }
        public string 特殊病种 { get; set; }
        public string 诊断 { get; set; }
        public Nullable<System.DateTime> 出院日期 { get; set; }
        public string 结算日期信息 { get; set; }
        public string 出院日期信息 { get; set; }
    }
}
