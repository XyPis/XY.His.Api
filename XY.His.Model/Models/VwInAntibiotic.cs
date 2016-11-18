using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInAntibiotic
    {
        public Nullable<decimal> 金额 { get; set; }
        public string 病人姓名 { get; set; }
        public string 主诊医生 { get; set; }
        public string 卡号 { get; set; }
        public string 病人ID号 { get; set; }
        public Nullable<int> 年龄 { get; set; }
        public string 性别 { get; set; }
        public string 病人类别 { get; set; }
        public string 发票号 { get; set; }
        public System.DateTime 发票日期 { get; set; }
        public string 申请科室 { get; set; }
        public bool 抗生素 { get; set; }
    }
}
