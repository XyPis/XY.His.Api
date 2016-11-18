using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInPay
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public string HospNo { get; set; }
        public short LsChargeType { get; set; }
        public string LsChargeTypeName { get; set; }
        public decimal Amount { get; set; }
        public decimal Remain { get; set; }
        public int PayWayId { get; set; }
        public string PayWayName { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string OperName { get; set; }
        public Nullable<int> InvoId { get; set; }
        public Nullable<int> BedId { get; set; }
        public string BedName { get; set; }
        public Nullable<int> PatID { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string LocationName { get; set; }
        public string InPatNo { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public string Sex { get; set; }
        public string SexName { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<short> LsInStatus { get; set; }
        public string LsInStatusName { get; set; }
        public Nullable<int> PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public Nullable<int> TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public Nullable<bool> IsGf { get; set; }
        public Nullable<bool> IsYb { get; set; }
    }
}
