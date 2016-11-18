using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuExecute
    {
        public OuExecute()
        {
            this.OuExecuteDtls = new List<OuExecuteDtl>();
            this.OuExecuteBacks = new List<OuExecuteBack>();
        }

        public int ID { get; set; }
        public int MzRegId { get; set; }
        public short LsRepType { get; set; }
        public string Name { get; set; }
        public int RecipeId { get; set; }
        public short GroupNum { get; set; }
        public short NDay { get; set; }
        public short NTime { get; set; }
        public int UsageId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<bool> IsExecuted { get; set; }
        public virtual BsUsage BsUsage { get; set; }
        public virtual ICollection<OuExecuteDtl> OuExecuteDtls { get; set; }
        public virtual OuRecipe OuRecipe { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
        public virtual ICollection<OuExecuteBack> OuExecuteBacks { get; set; }
    }
}
