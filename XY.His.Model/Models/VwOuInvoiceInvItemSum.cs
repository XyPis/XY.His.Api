using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuInvoiceInvItemSum
    {
        public System.DateTime 日期 { get; set; }
        public string 费别 { get; set; }
        public decimal 金额 { get; set; }
        public string 科室 { get; set; }
        public string 医生 { get; set; }
        public int ID { get; set; }
        public int Expr1 { get; set; }
    }
}
