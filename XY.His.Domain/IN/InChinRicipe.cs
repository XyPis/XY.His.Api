using System;
using System.Collections.Generic;
using XY.His.Domain.BS;

namespace XY.His.Domain.IN
{
    public partial class InChinRicipe : EntityBase
    {
        public int ID { get; set; }
        public string RecipeNo { get; set; }
        public int HospId { get; set; }
        public int LocationId { get; set; }
        public int DoctorId { get; set; }
        public short DrugNum { get; set; }
        public short DecoctNum { get; set; }
        public bool IsConfirm { get; set; }
        public short LsCookSelf { get; set; }
        public Nullable<int> ConfirmOperID { get; set; }
        public Nullable<System.DateTime> ConfirmOperTime { get; set; }
        public bool IsBack { get; set; }
        public bool IsPrint { get; set; }
        public string Memo { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public Nullable<bool> IsPriority { get; set; }
        public Nullable<bool> IsAuth { get; set; }
        public Nullable<System.DateTime> BackTime { get; set; }
        public Nullable<short> CookMinute { get; set; }
        public Nullable<short> LsFire { get; set; }
        public Nullable<int> AdviceLocationId { get; set; }     
    }
}
