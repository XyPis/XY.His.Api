using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_FlightSurgeryNotice
    {
        public string ApplyNo { get; set; }
        public Nullable<int> HospId { get; set; }
        public string 病历号 { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string Name { get; set; }
        public Nullable<int> UserId { get; set; }
        public bool IsUrgent { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<System.DateTime> PlanTime { get; set; }
        public string Diagnose { get; set; }
        public string 病情说明 { get; set; }
        public string 手术等级 { get; set; }
        public string 隔离标志 { get; set; }
        public string 第一手术助手 { get; set; }
        public string 第二手术助手 { get; set; }
        public string 第三手术助手 { get; set; }
        public string 第四手术助手 { get; set; }
    }
}
