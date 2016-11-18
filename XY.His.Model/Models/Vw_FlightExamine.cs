using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_FlightExamine
    {
        public int ID { get; set; }
        public int CkLabDtlID { get; set; }
        public string 优先标志 { get; set; }
        public int PatId { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<System.DateTime> AuthTime { get; set; }
        public string patientName { get; set; }
        public string NamePY { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public string Age { get; set; }
        public string ItemName { get; set; }
        public string 检验目的 { get; set; }
        public string Diagnose { get; set; }
        public string F1 { get; set; }
        public string Memo { get; set; }
        public Nullable<System.DateTime> CollectTime { get; set; }
        public Nullable<System.DateTime> RecieveTime { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string DoctorName { get; set; }
        public Nullable<int> CollectLocId { get; set; }
        public string 结果状态 { get; set; }
        public Nullable<System.DateTime> ReportTime { get; set; }
        public Nullable<int> ReportOperId { get; set; }
        public string ReportName { get; set; }
        public Nullable<int> AuthOperId { get; set; }
        public string AuthOperNae { get; set; }
        public string 费用 { get; set; }
        public string 应收费用 { get; set; }
        public string ReportMemo { get; set; }
    }
}
