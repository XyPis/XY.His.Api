using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblPrinter
    {
        public int ID { get; set; }
        public string Hostname { get; set; }
        public string ReportName { get; set; }
        public string PrinterName { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
