using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_FlightReceipe
    {
        public int PatID { get; set; }
        public int HospId { get; set; }
        public string 医嘱序号 { get; set; }
        public string 医嘱子序号 { get; set; }
        public string 长期医嘱标志 { get; set; }
        public string 医嘱类别 { get; set; }
        public string Name { get; set; }
        public int ID { get; set; }
        public decimal Dosage { get; set; }
        public string UnitTakeName { get; set; }
        public Nullable<int> UsageId { get; set; }
        public string UsageName { get; set; }
        public Nullable<System.DateTime> ChkOperTime { get; set; }
        public Nullable<System.DateTime> EndOperTime { get; set; }
        public string 持续时间 { get; set; }
        public string 持续时间单位 { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public string PrintName { get; set; }
        public decimal Times { get; set; }
        public int Days { get; set; }
        public string 频率间隔单位 { get; set; }
        public string 执行时间详细描述 { get; set; }
        public Nullable<System.DateTime> AuthOperTime { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string 医嘱状态 { get; set; }
        public int 药品计价属性 { get; set; }
        public string 计价属性 { get; set; }
    }
}
