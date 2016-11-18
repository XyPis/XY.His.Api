using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_FlightExamineResult
    {
        public int LabId { get; set; }
        public int TestId { get; set; }
        public string 打印序号 { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Result { get; set; }
        public string Unit { get; set; }
        public string 结果正常标志 { get; set; }
        public System.DateTime OperTime { get; set; }
    }
}
