using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class vw_DI_CkLab
    {
        public int ID { get; set; }
        public string 标本号 { get; set; }
        public string 住院号 { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public string 卡号 { get; set; }
        public string 病人姓名 { get; set; }
        public string 性别 { get; set; }
        public Nullable<int> 年龄 { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string 送检单位 { get; set; }
        public string IllHistory { get; set; }
        public string 科室 { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string 医生 { get; set; }
        public string Diagnose { get; set; }
        public bool IsPriority { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<bool> 阴性 { get; set; }
        public Nullable<int> SpecialityId { get; set; }
        public short LsSource { get; set; }
        public Nullable<System.DateTime> 报告时间 { get; set; }
        public string 检验人 { get; set; }
        public string 标本来源 { get; set; }
        public string 检验类别 { get; set; }
        public string 检验项目 { get; set; }
        public Nullable<int> TogetherNum { get; set; }
    }
}
