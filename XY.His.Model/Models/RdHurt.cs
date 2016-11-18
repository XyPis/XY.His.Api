using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RdHurt
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string Code { get; set; }
        public int MzRegId { get; set; }
        public string HospitalCode { get; set; }
        public Nullable<System.DateTime> HurtTime { get; set; }
        public Nullable<System.DateTime> DiagDate { get; set; }
        public Nullable<int> LsHurtReason { get; set; }
        public Nullable<int> LsHurtCensus { get; set; }
        public string ElHurtReason { get; set; }
        public Nullable<int> LsHurtPlace { get; set; }
        public string ElHurtPlace { get; set; }
        public Nullable<int> LsHurtActivity { get; set; }
        public string ElHurtActivity { get; set; }
        public Nullable<int> LsIsDeliberately { get; set; }
        public Nullable<int> LsHurtNature { get; set; }
        public string ElHurtNature { get; set; }
        public Nullable<int> LsHurtPosition { get; set; }
        public string ElHurtPosition { get; set; }
        public Nullable<int> LsHurtDegree { get; set; }
        public string HurtClinical { get; set; }
        public Nullable<int> LsHurtEnding { get; set; }
        public string ElHurtEnding { get; set; }
        public Nullable<int> LsHurtProduct { get; set; }
        public Nullable<int> LsHurtProducts { get; set; }
        public string ProductName { get; set; }
        public string ProductNames { get; set; }
        public string ProductType { get; set; }
        public string ProductTypes { get; set; }
        public string Typical { get; set; }
        public Nullable<int> LocId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
    }
}
