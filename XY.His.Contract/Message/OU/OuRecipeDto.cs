using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.OU
{
    [Serializable]
    public partial class OuRecipeDto : DtoBase
    {
        public int MzRegId { get; set; }
        public short LsRepType { get; set; }
        public string RecipeNum { get; set; }
        public System.DateTime RecipeTime { get; set; }
        public int LocationId { get; set; }
        public int DoctorId { get; set; }
        public Nullable<short> HowMany { get; set; }
        public bool IsPriority { get; set; }
        public string Memo { get; set; }
        public bool IsPend { get; set; }
        public bool IsExecuted { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> PatId { get; set; }
        public Nullable<bool> IsDosage { get; set; }
        public Nullable<int> DosageOperId { get; set; }
        public Nullable<System.DateTime> DosageTime { get; set; }
    }
}
