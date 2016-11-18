using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwCkMachineTest
    {
        public string MachineName { get; set; }
        public string TestName { get; set; }
        public int LabId { get; set; }
        public Nullable<System.DateTime> ReportTime { get; set; }
        public decimal Price { get; set; }
        public string LabNum { get; set; }
        public string OperName { get; set; }
        public int MachineID { get; set; }
        public int TestID { get; set; }
    }
}
