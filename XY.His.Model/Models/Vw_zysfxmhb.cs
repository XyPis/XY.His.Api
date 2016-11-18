using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_zysfxmhb
    {
        public string 住院号 { get; set; }
        public Nullable<int> 住院次数 { get; set; }
        public string 住院信息 { get; set; }
        public string 姓名 { get; set; }
        public string 病人类别 { get; set; }
        public string 项目名称 { get; set; }
        public string 项目代码 { get; set; }
        public Nullable<decimal> 单价 { get; set; }
        public decimal 数量 { get; set; }
        public decimal 金额 { get; set; }
        public System.DateTime 日期 { get; set; }
        public string 住院状态 { get; set; }
        public string 性别 { get; set; }
    }
}
