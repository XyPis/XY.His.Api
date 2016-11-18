using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_zybryecx
    {
        public string 住院号 { get; set; }
        public string 姓名 { get; set; }
        public Nullable<System.DateTime> 入院日期 { get; set; }
        public string 床号 { get; set; }
        public string 科室 { get; set; }
        public string 类型 { get; set; }
        public decimal 预交额 { get; set; }
        public decimal 总金额 { get; set; }
        public Nullable<decimal> 欠款 { get; set; }
        public Nullable<decimal> 余款 { get; set; }
    }
}
