using System;
using System.Collections.Generic;

namespace XY.His.Domain.IN
{
    public partial class InDrugReqdtl : EntityBase
    {
        public int ID { get; set; }
        public int RequestId { get; set; }
        public int ListNum { get; set; }
        public int HospId { get; set; }
        public System.DateTime ForDate { get; set; }
        public int ItemId { get; set; }
        public int AdviceId { get; set; }
        public short GroupNum { get; set; }
        public short LsMarkType { get; set; }
        public Nullable<decimal> Dosage { get; set; }
        public int UnitReq { get; set; }
        public Nullable<int> UnitTake { get; set; }
        public decimal Totality { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public bool IsPrint { get; set; }
        public bool IsIssued { get; set; }
        public bool IsConfirm { get; set; }
        public Nullable<int> ConfirmOperId { get; set; }
        public Nullable<System.DateTime> ConfirmOperTime { get; set; }
        public Nullable<int> DetailId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> ExecuteId { get; set; }
        public string RegDate { get; set; }
        public Nullable<int> LsSecMarkType { get; set; }
        public string BedName { get; set; }
        public Nullable<bool> Refusal { get; set; }
        public Nullable<bool> IsArrearage { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<decimal> PriceIn { get; set; }
        public Nullable<bool> LsArrearage { get; set; }
    }
}
