using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CKReportDefine
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> TestTypeID { get; set; }
        public byte[] ReportContent { get; set; }
    }
}
