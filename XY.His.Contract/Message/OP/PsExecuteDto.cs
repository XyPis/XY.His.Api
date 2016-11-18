using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.OP
{
    [Serializable]
    public partial class PsExecuteDto : DtoBase
    {
        public string ApplyId { get; set; }
        public Nullable<int> RecipeId { get; set; }
        public Nullable<bool> IsExecuted { get; set; }
        public Nullable<System.DateTime> ExecutedTime { get; set; }
        public Nullable<int> ExecutedOperId { get; set; }
        public Nullable<int> ExecLocId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
