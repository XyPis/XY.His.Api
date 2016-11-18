using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwGnKsFee
    {
        public string 日期 { get; set; }
        public string 科室 { get; set; }
        public string 项目名称 { get; set; }
        public string 医生 { get; set; }
        public string 费别 { get; set; }
        public Nullable<decimal> 金额 { get; set; }
        public Nullable<int> InvoId { get; set; }
        public string 住院或门诊 { get; set; }
        public string 项目编号 { get; set; }
    }
}
