using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_DI_OurecipeDtl
    {
        public string 就诊卡号 { get; set; }
        public string 性别 { get; set; }
        public Nullable<int> 年龄 { get; set; }
        public string 医疗付款方式 { get; set; }
        public string 科室名称 { get; set; }
        public string 医师工号 { get; set; }
        public string 医师职称 { get; set; }
        public string 处方编号 { get; set; }
        public System.DateTime 处方时间 { get; set; }
        public string 药品编码 { get; set; }
        public string 药品通用名 { get; set; }
        public string 药品商品名 { get; set; }
        public string 药品生产企业 { get; set; }
        public string 给药途径 { get; set; }
        public string 药品规格 { get; set; }
        public string 剂量 { get; set; }
        public decimal 用法 { get; set; }
        public string 包装数量 { get; set; }
        public string 包装 { get; set; }
        public string 单价 { get; set; }
        public Nullable<decimal> 数量 { get; set; }
        public Nullable<decimal> 药品金额 { get; set; }
        public Nullable<int> 审核药师工号 { get; set; }
        public Nullable<int> 调剂药师工号 { get; set; }
    }
}
