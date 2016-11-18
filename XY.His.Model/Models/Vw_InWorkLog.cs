using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_InWorkLog
    {
        public string 科号 { get; set; }
        public string 科别 { get; set; }
        public string 三级科室 { get; set; }
        public Nullable<decimal> 床位数 { get; set; }
        public Nullable<decimal> 期末实有病床数 { get; set; }
        public string 统标 { get; set; }
        public Nullable<short> 原人数 { get; set; }
        public Nullable<short> 期初人数 { get; set; }
        public Nullable<short> 入院人数 { get; set; }
        public Nullable<short> 他科转入 { get; set; }
        public Nullable<short> 转往他科 { get; set; }
        public Nullable<short> 出院人数 { get; set; }
        public Nullable<short> 死亡人数 { get; set; }
        public Nullable<short> 现有人数 { get; set; }
        public Nullable<short> 期末人数 { get; set; }
        public Nullable<short> 陪人数 { get; set; }
        public string 年月 { get; set; }
        public string 科室_月份 { get; set; }
        public Nullable<System.DateTime> 日期 { get; set; }
    }
}
