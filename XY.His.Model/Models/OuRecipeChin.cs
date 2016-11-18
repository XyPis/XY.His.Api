using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuRecipeChin
    {
        public int ID { get; set; }
        public int RecipeId { get; set; }
        public Nullable<int> FrequencyId { get; set; }
        public Nullable<int> UsageId { get; set; }
        public short DecoctNum { get; set; }
        public short LsCookSelf { get; set; }
        public Nullable<short> CookMinute { get; set; }
        public Nullable<short> LsFire { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsFrequency BsFrequency { get; set; }
        public virtual BsUsage BsUsage { get; set; }
        public virtual OuRecipe OuRecipe { get; set; }
    }
}
