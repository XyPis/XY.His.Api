using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.IN
{
    [Serializable]
    public partial class InChinRicipExecDto : DtoBase
    {
        public int RecipeId { get; set; }
        public string ExecTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual InChinRicipeDto InChinRicipe { get; set; }
    }
}
