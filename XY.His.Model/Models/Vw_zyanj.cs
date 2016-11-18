using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_zyanj
    {
        public string 住院号 { get; set; }
        public string 姓名 { get; set; }
        public int 住院次数 { get; set; }
        public System.DateTime 日期 { get; set; }
        public Nullable<decimal> 金额 { get; set; }
        public string 科室 { get; set; }
        public string 交付方式 { get; set; }
        public string 单据号 { get; set; }
        public string 住院状态 { get; set; }
    }
}
