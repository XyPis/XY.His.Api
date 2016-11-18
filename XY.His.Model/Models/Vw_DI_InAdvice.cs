using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_DI_InAdvice
    {
        public string 病案号 { get; set; }
        public int 住院次数 { get; set; }
        public Nullable<System.DateTime> 摆药时间 { get; set; }
        public short 医嘱类别 { get; set; }
        public string 药品编码 { get; set; }
        public string 药品通用名 { get; set; }
        public string 药品商品名 { get; set; }
        public string 药品生产企业 { get; set; }
        public string 给药途径 { get; set; }
        public string 规格 { get; set; }
        public string 剂型 { get; set; }
        public string 用法 { get; set; }
        public decimal 包装数量 { get; set; }
        public string 包装 { get; set; }
        public string 单位 { get; set; }
        public decimal 摆药数量 { get; set; }
        public decimal 单价 { get; set; }
        public Nullable<decimal> 药品金额 { get; set; }
        public string 医师工号 { get; set; }
        public string 医师的职称 { get; set; }
        public Nullable<int> 审核药师工号 { get; set; }
        public Nullable<int> 调剂药师工号 { get; set; }
    }
}
