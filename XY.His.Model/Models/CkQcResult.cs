using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkQcResult
    {
        public int ID { get; set; }
        public System.DateTime ResultDate { get; set; }
        public string Result { get; set; }
        public string ResultComment { get; set; }
        public int OperId { get; set; }
        public string ResultStatus { get; set; }
        public int LotId { get; set; }
        public int TestId { get; set; }
        public int CtrlId { get; set; }
        public Nullable<bool> IsShowQc { get; set; }
        public string RejectMemo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual CkQcControl CkQcControl { get; set; }
        public virtual CkQcLot CkQcLot { get; set; }
    }
}
