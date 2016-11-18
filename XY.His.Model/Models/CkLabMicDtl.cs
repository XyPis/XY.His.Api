using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkLabMicDtl
    {
        public int ID { get; set; }
        public int MicId { get; set; }
        public Nullable<int> DrugId { get; set; }
        public string Result { get; set; }
        public string LsMic { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsBaseDrug BsBaseDrug { get; set; }
        public virtual CkLabMic CkLabMic { get; set; }
    }
}
