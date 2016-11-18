using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuInvoicePay
    {
        public int ID { get; set; }
        public int InvoId { get; set; }
        public string InvoNo { get; set; }
        public decimal Amount { get; set; }
        public int PaywayId { get; set; }
        public string PayWayName { get; set; }
        public int MzRegId { get; set; }
        public string MzRegNo { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> RegDept { get; set; }
        public string LocationName { get; set; }
        public string CardNo { get; set; }
        public Nullable<System.DateTime> RegTime { get; set; }
        public Nullable<int> PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public Nullable<int> TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public Nullable<bool> IsGf { get; set; }
        public Nullable<bool> IsYb { get; set; }
        public bool IsCancel { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string SexName { get; set; }
        public string OperName { get; set; }
    }
}
