using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_DI_OuInvoiceSum
    {
        public Nullable<decimal> 总金额 { get; set; }
        public string 日期 { get; set; }
        public Nullable<int> 月份 { get; set; }
        public Nullable<int> 年份 { get; set; }
        public string 科室 { get; set; }
    }
}
