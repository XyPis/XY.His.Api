using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_FlightChecking
    {
        public string ApplyNo { get; set; }
        public string 检查号类别 { get; set; }
        public string 检查标识号 { get; set; }
        public int PatId { get; set; }
        public Nullable<int> HospId { get; set; }
        public string XtypeName { get; set; }
        public string CheckBody { get; set; }
        public Nullable<System.DateTime> ConfirmTime { get; set; }
        public string 临床症状 { get; set; }
        public string 体征 { get; set; }
        public string 相关化验结果 { get; set; }
        public string 其他诊断 { get; set; }
        public string Diagnose { get; set; }
        public string 检查方式 { get; set; }
        public string Equipment { get; set; }
        public string 使用仪器 { get; set; }
        public Nullable<int> ExecLocId { get; set; }
        public string 病人来源 { get; set; }
        public string 外来医疗单位名称 { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string doctorName { get; set; }
        public string ApplyMemo { get; set; }
        public Nullable<System.DateTime> 预约日期及时间 { get; set; }
        public string 注意事项 { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public Nullable<System.DateTime> ReportTime { get; set; }
        public string 操作者 { get; set; }
        public string reportDoctorName { get; set; }
        public string 检查结果状态 { get; set; }
    }
}
