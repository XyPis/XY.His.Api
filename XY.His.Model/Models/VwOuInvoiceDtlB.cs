using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwOuInvoiceDtlB
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public Nullable<short> LsGroupType { get; set; }
        public string LsGroupTypeName { get; set; }
        public string Code { get; set; }
        public Nullable<int> GroupMainId { get; set; }
        public string GroupMainName { get; set; }
        public Nullable<int> GroupSubId { get; set; }
        public string GroupSubName { get; set; }
        public string Name { get; set; }
        public string Spec { get; set; }
        public string OrderLocationName { get; set; }
        public Nullable<bool> IsSpecSum { get; set; }
        public Nullable<bool> IsNew { get; set; }
        public Nullable<bool> IsRpForbid { get; set; }
        public Nullable<bool> IsChildAdd { get; set; }
        public Nullable<bool> IsBedFee { get; set; }
        public Nullable<bool> IsOpsAdd { get; set; }
        public decimal DiscSelf { get; set; }
        public decimal Price { get; set; }
        public decimal DiscDiag { get; set; }
        public decimal Totality { get; set; }
        public int UnitId { get; set; }
        public string UnitIdName { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountFact { get; set; }
        public decimal AmountSelf { get; set; }
        public decimal AmountTally { get; set; }
        public Nullable<decimal> AmountPay { get; set; }
        public int ExecLocId { get; set; }
        public int DoctorId { get; set; }
        public string DoctorName { get; set; }
        public short LsPerform { get; set; }
        public string LsPerformName { get; set; }
        public bool IsModiDisc { get; set; }
        public Nullable<int> LimitGroupId { get; set; }
        public string LimitGroupName { get; set; }
        public decimal LimitFee { get; set; }
        public string InvItemName { get; set; }
        public int FeeId { get; set; }
        public string FeetyName { get; set; }
        public Nullable<int> FeeHsId { get; set; }
        public string FeeHsName { get; set; }
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
        public Nullable<int> PatId { get; set; }
        public string SexName { get; set; }
        public string MedicareNo { get; set; }
        public Nullable<int> Age { get; set; }
        public Nullable<int> PatTypeId { get; set; }
        public string PatTypeName { get; set; }
        public Nullable<short> LsGFPatType { get; set; }
        public string LsGFPatTypeName { get; set; }
        public Nullable<int> TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public Nullable<bool> IsGf { get; set; }
        public Nullable<bool> IsYb { get; set; }
        public Nullable<int> RegTypeId { get; set; }
        public string RegTypeName { get; set; }
        public int OperId { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public System.DateTime OperTime { get; set; }
        public string OperName { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> LocationID { get; set; }
        public Nullable<int> RegDept { get; set; }
        public Nullable<System.DateTime> CancelOperTime { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public string CancelOperName { get; set; }
        public Nullable<int> InvoLastId { get; set; }
        public Nullable<int> XDRpId { get; set; }
        public string XdRpName { get; set; }
        public Nullable<int> RecipeItemId { get; set; }
        public bool IsCancel { get; set; }
    }
}
