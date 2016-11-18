using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_yptj
    {
        public System.DateTime 调价日期 { get; set; }
        public System.DateTime 调价日期字符 { get; set; }
        public string 药品代码 { get; set; }
        public string 药品名称 { get; set; }
        public string 规格 { get; set; }
        public decimal 数量 { get; set; }
        public decimal 原零售价 { get; set; }
        public decimal 现零售价 { get; set; }
        public decimal 零售损益 { get; set; }
        public string 单位 { get; set; }
        public string 批号 { get; set; }
        public string 调价员 { get; set; }
        public string 采购公司 { get; set; }
        public string 药品分类 { get; set; }
        public string 调价地点 { get; set; }
    }
}
