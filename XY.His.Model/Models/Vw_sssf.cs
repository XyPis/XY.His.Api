using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_sssf
    {
        public string 申请科室 { get; set; }
        public string 执行科室 { get; set; }
        public string 日期 { get; set; }
        public string 发票分类 { get; set; }
        public Nullable<decimal> 金额 { get; set; }
        public string 基础分类 { get; set; }
        public string 住院号 { get; set; }
        public int 住院次数 { get; set; }
        public string 姓名 { get; set; }
    }
}
