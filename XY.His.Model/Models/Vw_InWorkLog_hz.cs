using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_InWorkLog_hz
    {
        public string 科号 { get; set; }
        public string 科别 { get; set; }
        public string 三级科室 { get; set; }
        public Nullable<decimal> 床位数 { get; set; }
        public Nullable<decimal> 期末实有病床数 { get; set; }
        public Nullable<int> 原人数 { get; set; }
        public Nullable<int> 期初人数 { get; set; }
        public Nullable<int> 入院人数 { get; set; }
        public Nullable<int> 他科转入 { get; set; }
        public Nullable<int> 转往他科 { get; set; }
        public Nullable<int> 出院人数 { get; set; }
        public Nullable<int> 死亡人数 { get; set; }
        public Nullable<int> 现有人数 { get; set; }
        public Nullable<int> 期末人数 { get; set; }
        public Nullable<int> 陪人数 { get; set; }
        public string 年月 { get; set; }
        public Nullable<int> 天数 { get; set; }
    }
}
