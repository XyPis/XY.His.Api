using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwCkLab
    {
        public int ID { get; set; }
        public string LabNum { get; set; }
        public string InPatNo { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public string CardNo { get; set; }
        public string Name { get; set; }
        public string SexName { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string RefLocation { get; set; }
        public string IllHistory { get; set; }
        public string IdCardNo { get; set; }
        public string Memo { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string Diagnose { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string UserName { get; set; }
        public bool IsPriority { get; set; }
        public Nullable<System.DateTime> CollectTime { get; set; }
        public Nullable<int> CollectOperId { get; set; }
        public string CollectOperName { get; set; }
        public bool IsCancel { get; set; }
        public string CancelOperName { get; set; }
        public Nullable<System.DateTime> CancelTime { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public Nullable<bool> IsPass { get; set; }
        public Nullable<int> SpecialityId { get; set; }
        public short LsSource { get; set; }
        public string LsSourceName { get; set; }
        public string TestName { get; set; }
    }
}
