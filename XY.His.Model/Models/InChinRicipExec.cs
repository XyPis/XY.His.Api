using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InChinRicipExec
    {
        public int ID { get; set; }
        public int RecipeId { get; set; }
        public string ExecTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual InChinRicipe InChinRicipe { get; set; }
    }
}
