using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DhInAdviceLong
    {
        public int ID { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public Nullable<int> RecId { get; set; }
        public int PatId { get; set; }
        public string InPatNo { get; set; }
        public System.DateTime AdviceTime { get; set; }
        public string DiagnDeptName { get; set; }
        public string DoctorName { get; set; }
        public int ListNum { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public string DrugName { get; set; }
        public string Spec { get; set; }
        public decimal PriceIn { get; set; }
        public Nullable<short> GroupNum { get; set; }
        public Nullable<decimal> Dosage { get; set; }
        public Nullable<int> UnitTakeId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<short> Days { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public Nullable<int> UnitDiagId { get; set; }
        public Nullable<short> FirstDay { get; set; }
        public Nullable<short> LastDay { get; set; }
        public Nullable<bool> IsAttach { get; set; }
        public Nullable<bool> IsSelf { get; set; }
        public Nullable<bool> IsSkin { get; set; }
        public Nullable<System.DateTime> SkinTime { get; set; }
        public string SkinTest { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public string OperName { get; set; }
        public Nullable<System.DateTime> AuthTime { get; set; }
        public string AuthName { get; set; }
        public Nullable<bool> IsExec { get; set; }
        public Nullable<System.DateTime> ExecTime { get; set; }
        public string ExecOperName { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsFrequency BsFrequency { get; set; }
        public virtual BsHospital BsHospital { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual BsUnit BsUnit1 { get; set; }
        public virtual BsUsage BsUsage { get; set; }
        public virtual ElPatRecord ElPatRecord { get; set; }
    }
}
