using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwCkMachineSample
    {
        public string 仪器名称 { get; set; }
        public string 检验项目 { get; set; }
        public int 仪器流水号 { get; set; }
        public Nullable<System.DateTime> 匹配时间 { get; set; }
        public decimal 价格 { get; set; }
        public string 标本号 { get; set; }
        public string 操作员 { get; set; }
    }
}
