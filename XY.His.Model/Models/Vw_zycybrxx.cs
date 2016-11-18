using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_zycybrxx
    {
        public string 住院号 { get; set; }
        public string 姓名 { get; set; }
        public string 住院信息 { get; set; }
        public string 性别 { get; set; }
        public string 主管医生 { get; set; }
        public int 住院次数 { get; set; }
        public System.DateTime 入院日期 { get; set; }
        public Nullable<System.DateTime> 出院日期 { get; set; }
        public string 病人类别 { get; set; }
        public string 入院科室 { get; set; }
        public string 住院科室 { get; set; }
        public string 床位号 { get; set; }
        public Nullable<int> 住院天数 { get; set; }
        public Nullable<short> 排序 { get; set; }
    }
}
