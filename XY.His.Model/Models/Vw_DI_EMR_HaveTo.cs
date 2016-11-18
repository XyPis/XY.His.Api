using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_DI_EMR_HaveTo
    {
        public string 科室 { get; set; }
        public string 医生 { get; set; }
        public string 卡号 { get; set; }
        public string 住院号 { get; set; }
        public string 病人姓名 { get; set; }
        public System.DateTime 入院时间 { get; set; }
        public string 出院时间 { get; set; }
        public int 住院次数 { get; set; }
        public string 病历类别 { get; set; }
        public int HospId { get; set; }
        public int CatalogId { get; set; }
    }
}
