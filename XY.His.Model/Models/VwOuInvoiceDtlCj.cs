using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuInvoiceDtlCj
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Spec { get; set; }
        public string LocationName { get; set; }
        public string DoctorName { get; set; }
        public decimal Price { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public string UnitIdName { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public int ExecLocId { get; set; }
        public string ExecLocName { get; set; }
        public int LsPerform { get; set; }
        public string LsPerformName { get; set; }
        public string InvItemName { get; set; }
        public int FeeId { get; set; }
        public string FeetyName { get; set; }
        public int InvItemId { get; set; }
        public Nullable<short> LsReportType { get; set; }
        public int InvoId { get; set; }
        public string InvoNo { get; set; }
        public int MzRegId { get; set; }
        public string PatientName { get; set; }
        public System.DateTime InvoTime { get; set; }
        public string TallyNo { get; set; }
        public string MzRegNo { get; set; }
        public string CardNo { get; set; }
        public int PatId { get; set; }
        public string SexName { get; set; }
        public string MedicareNo { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public int OperId { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public string OperName { get; set; }
    }
}
