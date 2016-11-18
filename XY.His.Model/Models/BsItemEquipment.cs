using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsItemEquipment
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public Nullable<short> LsEqType { get; set; }
        public Nullable<int> EqTypeId { get; set; }
        public string EqType { get; set; }
        public string SeriesNo { get; set; }
        public string Brand { get; set; }
        public Nullable<int> CountryId { get; set; }
        public string RepairBy { get; set; }
        public Nullable<int> LimitYears { get; set; }
        public Nullable<short> LsQuaClass { get; set; }
        public Nullable<short> LsEqClass { get; set; }
        public Nullable<decimal> MonthDisc { get; set; }
        public Nullable<short> LsMoneyFrom { get; set; }
        public Nullable<decimal> MoneyGiven { get; set; }
        public Nullable<decimal> MoneySelf { get; set; }
        public Nullable<decimal> UnderLine { get; set; }
        public Nullable<int> UnitId { get; set; }
        public Nullable<int> CostPercent { get; set; }
        public Nullable<decimal> AlarmLine { get; set; }
        public Nullable<bool> IsCalProfit { get; set; }
        public string UseArea { get; set; }
        public string UseMemo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<short> IconIndex { get; set; }
        public virtual BsEqType BsEqType { get; set; }
        public virtual BsItem BsItem { get; set; }
    }
}
