using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InChinRicipe
    {
        public InChinRicipe()
        {
            this.InChinRicipExecs = new List<InChinRicipExec>();
            this.InChinRicipeDtls = new List<InChinRicipeDtl>();
        }

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
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsFrequency BsFrequency { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsUsage BsUsage { get; set; }
        public virtual ICollection<InChinRicipExec> InChinRicipExecs { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual ICollection<InChinRicipeDtl> InChinRicipeDtls { get; set; }
    }
}
