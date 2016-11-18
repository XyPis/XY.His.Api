using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwCkResult
    {
        public int ID { get; set; }
        public string PatientNo { get; set; }
        public string PatientName { get; set; }
        public int CheckId { get; set; }
        public int TestId { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public Nullable<short> LsTestType { get; set; }
        public Nullable<int> TestTypeId { get; set; }
        public string TestTypeName { get; set; }
        public Nullable<int> TestGroupId { get; set; }
        public string TestGroupName { get; set; }
        public Nullable<bool> IsZero { get; set; }
        public Nullable<short> LsGroup { get; set; }
        public Nullable<bool> IsReport { get; set; }
        public string UseRange { get; set; }
        public string Unit { get; set; }
        public string Format { get; set; }
        public Nullable<decimal> LimitHigh { get; set; }
        public Nullable<decimal> LimitLow { get; set; }
        public string PrintHigh { get; set; }
        public string PrintLow { get; set; }
        public Nullable<decimal> DefaultDalAbsolute { get; set; }
        public Nullable<decimal> DefaultDalPercent { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public Nullable<bool> IsDisplay { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<short> LsStatus { get; set; }
        public string Result { get; set; }
        public string LastResult { get; set; }
        public Nullable<short> LsRefFlag { get; set; }
        public Nullable<bool> IsPanic { get; set; }
        public Nullable<bool> IsDalta { get; set; }
        public Nullable<double> DalAbsolute { get; set; }
        public Nullable<double> DalPercent { get; set; }
        public Nullable<decimal> LowValue { get; set; }
        public Nullable<decimal> HighValue { get; set; }
        public Nullable<decimal> PanicLow { get; set; }
        public Nullable<decimal> PanicHigh { get; set; }
        public Nullable<bool> IsPass { get; set; }
        public Nullable<System.DateTime> ReportDate { get; set; }
        public string ReportBy { get; set; }
        public Nullable<bool> IsPrint { get; set; }
        public string Memo { get; set; }
        public Nullable<int> ParentID { get; set; }
        public string CheckNo { get; set; }
        public Nullable<int> PatId { get; set; }
        public Nullable<System.DateTime> CheckTime { get; set; }
        public Nullable<int> CompanyCkeckId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public Nullable<bool> IsCancel { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<int> CompanyId { get; set; }
        public string CompanyName { get; set; }
        public Nullable<System.DateTime> CkeckDate { get; set; }
        public string CkeckNo { get; set; }
        public string SexName { get; set; }
        public string HighLow { get; set; }
        public string IsDangerous { get; set; }
        public string Compare { get; set; }
        public string NormalRange { get; set; }
        public Nullable<int> Age { get; set; }
        public string MarriageName { get; set; }
        public string AddressHome { get; set; }
        public string PhotoFolder { get; set; }
    }
}
