using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuIncomeReportGroup
    {
        public string 执行科室 { get; set; }
        public Nullable<decimal> 金额 { get; set; }
        public Nullable<decimal> 实收金额 { get; set; }
        public Nullable<decimal> 记帐金额 { get; set; }
        public Nullable<decimal> 自付金额 { get; set; }
        public string 医嘱医生 { get; set; }
        public string 病人姓名 { get; set; }
        public string 主诊医生 { get; set; }
        public string 卡号 { get; set; }
        public string 门诊号 { get; set; }
        public Nullable<int> 年龄 { get; set; }
        public string 性别 { get; set; }
        public string 病人类别 { get; set; }
        public string 报表分类 { get; set; }
        public string 发票号 { get; set; }
        public Nullable<System.DateTime> 发票日期 { get; set; }
        public string 申请科室 { get; set; }
    }
}
