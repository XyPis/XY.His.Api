using System;
using System.Collections.Generic;

namespace XY.His.Domain.OU
{
    public partial class OuInvoiceDtl : EntityBase
    {
        public int ID { get; set; }
        public int InvoId { get; set; }
        public int ItemId { get; set; }
        public decimal Totality { get; set; }
        public int UnitId { get; set; }
        public decimal Price { get; set; }
        public decimal DiscDiag { get; set; }
        public bool IsModiDisc { get; set; }
        public decimal DiscSelf { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountFact { get; set; }
        public decimal AmountSelf { get; set; }
        public decimal AmountTally { get; set; }
        public Nullable<decimal> AmountPay { get; set; }
        public short LsPerform { get; set; }
        public Nullable<int> LimitGroupId { get; set; }
        public decimal LimitFee { get; set; }
        public int ExecLocId { get; set; }
        public int DoctorId { get; set; }
        public int InvItemId { get; set; }
        public int FeeId { get; set; }
        public Nullable<int> FeeHsId { get; set; }
        public Nullable<int> XDRpId { get; set; }
        public Nullable<short> LsReportType { get; set; }
        public string Memo { get; set; }
        public Nullable<int> RecipeItemId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> RecipeGroupId { get; set; }
        public Nullable<int> DocLocID { get; set; }
    }
}
