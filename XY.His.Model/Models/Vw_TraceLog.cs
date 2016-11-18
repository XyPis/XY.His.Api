using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_TraceLog
    {
        public string 操作员 { get; set; }
        public System.DateTime 日期 { get; set; }
        public int 项目ID { get; set; }
        public string 项目名称 { get; set; }
        public string 规格 { get; set; }
        public string 信息 { get; set; }
        public string 项目类别 { get; set; }
        public string 操作类别 { get; set; }
    }
}
