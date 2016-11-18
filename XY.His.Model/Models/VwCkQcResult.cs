using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwCkQcResult
    {
        public string 仪器 { get; set; }
        public string 标准 { get; set; }
        public int TestId { get; set; }
        public string 项目编码 { get; set; }
        public string 检验项目 { get; set; }
        public string 日期 { get; set; }
        public Nullable<decimal> 结果 { get; set; }
        public string 备注 { get; set; }
        public string 批号 { get; set; }
        public string 标本类型 { get; set; }
        public string 操作员 { get; set; }
        public string 单位 { get; set; }
        public string 项目类型 { get; set; }
        public int ID { get; set; }
        public string 实验方法 { get; set; }
        public Nullable<decimal> 标准偏差_3 { get; set; }
        public Nullable<decimal> 标准偏差_2 { get; set; }
        public Nullable<decimal> 标准偏差_1 { get; set; }
        public Nullable<decimal> 标准偏差_11 { get; set; }
        public Nullable<decimal> 标准偏差_21 { get; set; }
        public Nullable<decimal> 标准偏差_31 { get; set; }
        public Nullable<decimal> 平均值 { get; set; }
        public int 状态 { get; set; }
    }
}
