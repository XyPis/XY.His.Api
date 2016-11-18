using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwPsApplyReport
    {
        public int ID { get; set; }
        public string ApplyNo { get; set; }
        public System.DateTime OperTime { get; set; }
        public string ApplyOperName { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string DoctorName { get; set; }
        public Nullable<int> ItemId { get; set; }
        public string ItemName { get; set; }
        public string InPatNo { get; set; }
        public string MzRegNo { get; set; }
        public string PatientName { get; set; }
        public string CardNo { get; set; }
        public short XType { get; set; }
        public string Equipment { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public string CheckOperName { get; set; }
        public string CheckBody { get; set; }
        public bool IsAbNormal { get; set; }
    }
}
