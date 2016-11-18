using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            this.EqAttaches = new List<EqAttach>();
            this.EqChecks = new List<EqCheck>();
            this.EqRepairs = new List<EqRepair>();
            this.EqTransfers = new List<EqTransfer>();
        }

        public int ID { get; set; }
        public string CODE { get; set; }
        public string Name { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public string Spec { get; set; }
        public string EqType { get; set; }
        public string SeriesNo { get; set; }
        public string Brand { get; set; }
        public Nullable<int> CountryId { get; set; }
        public Nullable<int> ManuId { get; set; }
        public Nullable<int> CompId { get; set; }
        public string RepairBy { get; set; }
        public Nullable<System.DateTime> BuyDate { get; set; }
        public Nullable<System.DateTime> StartDate { get; set; }
        public Nullable<int> LimitYears { get; set; }
        public Nullable<int> MnrgLocId { get; set; }
        public Nullable<int> UseLocId { get; set; }
        public Nullable<short> LsQuaClass { get; set; }
        public Nullable<short> LsEqClass { get; set; }
        public string InActiveReason { get; set; }
        public Nullable<System.DateTime> InActiveTime { get; set; }
        public Nullable<int> InActiveOperID { get; set; }
        public string LotNo { get; set; }
        public string StoreIn { get; set; }
        public string Manager { get; set; }
        public Nullable<short> LsEqStatus { get; set; }
        public Nullable<decimal> Price { get; set; }
        public Nullable<int> HowMany { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> MonthDisc { get; set; }
        public Nullable<short> LsMoneyFrom { get; set; }
        public Nullable<decimal> MoneyGiven { get; set; }
        public Nullable<decimal> MoneySelf { get; set; }
        public Nullable<decimal> UnderLine { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<int> CostPercent { get; set; }
        public Nullable<decimal> AlarmLine { get; set; }
        public Nullable<bool> IsCalProfit { get; set; }
        public string Attachment { get; set; }
        public string UseArea { get; set; }
        public string UseMemo { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public short LsEqType { get; set; }
        public Nullable<int> GroupSubId { get; set; }
        public Nullable<int> CopyId { get; set; }
        public string VoucherNo { get; set; }
        public string ProduceArea { get; set; }
        public virtual BsCompany BsCompany { get; set; }
        public virtual BsCountry BsCountry { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsLocation BsLocation1 { get; set; }
        public virtual BsManufacturer BsManufacturer { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual ICollection<EqAttach> EqAttaches { get; set; }
        public virtual ICollection<EqCheck> EqChecks { get; set; }
        public virtual ICollection<EqRepair> EqRepairs { get; set; }
        public virtual ICollection<EqTransfer> EqTransfers { get; set; }
    }
}
