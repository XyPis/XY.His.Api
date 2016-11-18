using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_zycybrjk
    {
        public int 单据号 { get; set; }
        public string 住院号 { get; set; }
        public string 住院信息 { get; set; }
        public Nullable<int> 住院次数 { get; set; }
        public string 姓名 { get; set; }
        public Nullable<System.DateTime> 出院日期 { get; set; }
        public string 住院状态 { get; set; }
        public string 结算类型 { get; set; }
        public string 病人类别 { get; set; }
        public string 病学中心 { get; set; }
        public string 住院科室 { get; set; }
        public string 收费员 { get; set; }
        public System.DateTime 收费日期 { get; set; }
        public decimal 总金额 { get; set; }
        public Nullable<decimal> 记账金额 { get; set; }
        public decimal 应交金额 { get; set; }
        public decimal 预收金额 { get; set; }
        public decimal 结欠费用 { get; set; }
        public Nullable<decimal> 退款 { get; set; }
        public decimal 补款 { get; set; }
        public decimal 凑整费 { get; set; }
        public string 结算方式 { get; set; }
        public string 病人大类 { get; set; }
        public short 住院天数 { get; set; }
        public string 入院诊断 { get; set; }
    }
}
