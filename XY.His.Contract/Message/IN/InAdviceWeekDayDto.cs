using System;
using System.Collections.Generic;

namespace XY.His.Contract.Message.IN
{
    [Serializable]
    public partial class InAdviceWeekDayDto : DtoBase
    {
        public int AdviceId { get; set; }
        public short WeekDay { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual InAdviceLongDto InAdviceLong { get; set; }
    }
}
