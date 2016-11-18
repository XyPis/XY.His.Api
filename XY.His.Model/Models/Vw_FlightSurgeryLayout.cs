using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_FlightSurgeryLayout
    {
        public Nullable<int> HospId { get; set; }
        public string ApplyNo { get; set; }
        public string 手术安排标识 { get; set; }
        public string LocationName { get; set; }
        public string 病人所在床号 { get; set; }
        public System.DateTime ApplyTime { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> OpsRoomId { get; set; }
        public string SeqNum { get; set; }
        public string Diagnose { get; set; }
        public string 病情说明 { get; set; }
        public string 手术等级 { get; set; }
        public string 隔离标志 { get; set; }
        public Nullable<int> 手术科室 { get; set; }
        public string DoctorName { get; set; }
        public string 第一手术助手 { get; set; }
        public string 第二手术助手 { get; set; }
        public string 第三手术助手 { get; set; }
        public string 第四手术助手 { get; set; }
        public string Name { get; set; }
        public string 麻醉医师 { get; set; }
        public string 麻醉助手 { get; set; }
        public string 输血者 { get; set; }
        public string Memo { get; set; }
        public Nullable<System.DateTime> PlanTime { get; set; }
        public Nullable<int> PlanOperId { get; set; }
    }
}
