using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkItem
    {
        public CkItem()
        {
            this.CkGroupItems = new List<CkGroupItem>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public short LsTestType { get; set; }
        public Nullable<int> TestTypeId { get; set; }
        public Nullable<int> TubeTypeId { get; set; }
        public string ShortName { get; set; }
        public string Name { get; set; }
        public string OperMemo { get; set; }
        public bool IsZero { get; set; }
        public short LsGroup { get; set; }
        public bool IsReport { get; set; }
        public string UseRange { get; set; }
        public short LsForSex { get; set; }
        public Nullable<int> SourceId { get; set; }
        public decimal Price { get; set; }
        public string Unit { get; set; }
        public string Format { get; set; }
        public decimal LimitHigh { get; set; }
        public decimal LimitLow { get; set; }
        public string PrintHigh { get; set; }
        public string PrintLow { get; set; }
        public decimal DalAbsolute { get; set; }
        public decimal DalPercent { get; set; }
        public Nullable<int> ItemId { get; set; }
        public short OrderBy { get; set; }
        public bool IsDisplay { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> FluidId { get; set; }
        public string TestWay { get; set; }
        public Nullable<decimal> Dev3 { get; set; }
        public Nullable<decimal> Dev2 { get; set; }
        public Nullable<decimal> Dev1 { get; set; }
        public Nullable<decimal> DevM1 { get; set; }
        public Nullable<decimal> DevM2 { get; set; }
        public Nullable<decimal> DevM3 { get; set; }
        public Nullable<decimal> AvgValue { get; set; }
        public string DefultValue { get; set; }
        public virtual BsFluid BsFluid { get; set; }
        public virtual ICollection<CkGroupItem> CkGroupItems { get; set; }
        public virtual CkTestType CkTestType { get; set; }
    }
}
