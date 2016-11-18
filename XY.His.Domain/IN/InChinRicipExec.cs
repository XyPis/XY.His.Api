using System;
using System.Collections.Generic;

namespace XY.His.Domain.IN
{
    public partial class InChinRicipExec : EntityBase
    {
        public int ID { get; set; }
        public int RecipeId { get; set; }
        public string ExecTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
