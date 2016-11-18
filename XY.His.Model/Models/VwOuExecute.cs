using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuExecute
    {
        public string MzRegNo { get; set; }
        public string PatientName { get; set; }
        public int MzRegId { get; set; }
        public short GroupNum { get; set; }
        public short NDay { get; set; }
        public short NTime { get; set; }
        public Nullable<bool> IsExecuted { get; set; }
        public Nullable<System.DateTime> ExecutedTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public string OperName { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public decimal Dosage { get; set; }
        public string UnitTakeName { get; set; }
        public string UsageName { get; set; }
        public string FrequencyName { get; set; }
        public Nullable<decimal> Totality { get; set; }
        public string UnitDiagName { get; set; }
        public Nullable<System.DateTime> IssueTime { get; set; }
        public Nullable<System.DateTime> BackTime { get; set; }
        public Nullable<int> DiagnDept { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string CardNo { get; set; }
        public int ItemId { get; set; }
        public decimal PriceDiag { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public short Days { get; set; }
        public Nullable<bool> IsSend { get; set; }
        public Nullable<bool> IsBack { get; set; }
        public Nullable<bool> IsPatientBack { get; set; }
    }
}
