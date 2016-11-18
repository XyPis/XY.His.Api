using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInExecute
    {
        public int ID { get; set; }
        public string 用法 { get; set; }
        public string 科室 { get; set; }
        public string 病区 { get; set; }
        public Nullable<decimal> 次数 { get; set; }
        public Nullable<int> 年 { get; set; }
        public Nullable<int> 月 { get; set; }
    }
}
