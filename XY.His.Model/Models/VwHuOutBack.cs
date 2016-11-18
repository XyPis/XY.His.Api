using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwHuOutBack
    {
        public System.DateTime 发生日期 { get; set; }
        public int HouseId { get; set; }
        public string 药库名称 { get; set; }
        public string 药品代码 { get; set; }
        public string 药品名称 { get; set; }
        public string 规格 { get; set; }
        public Nullable<decimal> 发生数量 { get; set; }
        public decimal 零售价 { get; set; }
        public decimal 进货价 { get; set; }
        public Nullable<decimal> 进货金额 { get; set; }
        public Nullable<decimal> 零售金额 { get; set; }
        public string 单位 { get; set; }
        public string 供应商 { get; set; }
        public string 出入库类型 { get; set; }
        public string 药品类型 { get; set; }
        public string 领药单位 { get; set; }
        public string 剂型 { get; set; }
        public string 单号 { get; set; }
    }
}
