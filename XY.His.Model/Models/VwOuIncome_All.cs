using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuIncome_All
    {
        public string 日期 { get; set; }
        public string 科室 { get; set; }
        public string 大科 { get; set; }
        public string 分院 { get; set; }
        public string 医生 { get; set; }
        public string 基础分类 { get; set; }
        public decimal 金额 { get; set; }
        public int PatientId { get; set; }
    }
}
