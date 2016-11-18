using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwResidentPatient
    {
        public string 档案号 { get; set; }
        public string 姓名 { get; set; }
        public string 性别 { get; set; }
        public Nullable<System.DateTime> 出生日期 { get; set; }
        public Nullable<int> 年龄 { get; set; }
        public string 村_居委 { get; set; }
        public string 镇_街道 { get; set; }
        public string 街_巷 { get; set; }
        public string 户主 { get; set; }
        public string 地址 { get; set; }
        public string 电话 { get; set; }
        public string 医疗证 { get; set; }
        public string 身份证 { get; set; }
        public string 职业 { get; set; }
        public string 病人类别 { get; set; }
        public Nullable<bool> 公费 { get; set; }
        public Nullable<bool> 医保 { get; set; }
        public string 学历 { get; set; }
        public System.DateTime 登记时间 { get; set; }
        public string 登记人 { get; set; }
        public string 档案类别 { get; set; }
        public int 档案ID { get; set; }
    }
}
