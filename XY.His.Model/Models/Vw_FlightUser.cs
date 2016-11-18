using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_FlightUser
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string 输入码 { get; set; }
        public Nullable<int> 科室代码 { get; set; }
        public int 工作类别 { get; set; }
        public string 职称 { get; set; }
        public string 性别 { get; set; }
        public string 出生日期 { get; set; }
        public string 身份证 { get; set; }
        public string 职务 { get; set; }
        public string 联系方式 { get; set; }
        public string 电子邮件 { get; set; }
        public string 家庭住址 { get; set; }
        public string 人员状态 { get; set; }
        public string 入职时间 { get; set; }
        public string 离职时间 { get; set; }
    }
}
