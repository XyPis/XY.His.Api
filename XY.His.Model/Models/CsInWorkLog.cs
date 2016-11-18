using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CsInWorkLog
    {
        public int ID { get; set; }
        public string YearMonth { get; set; }
        public int LocId { get; set; }
        public Nullable<int> OriginalNum { get; set; }
        public Nullable<int> AdmittedOutps { get; set; }
        public Nullable<int> FromOtherDept { get; set; }
        public Nullable<int> TotalInHospitalDays { get; set; }
        public Nullable<int> TotalInDeptDays { get; set; }
        public Nullable<int> TransDeptNum { get; set; }
        public Nullable<int> TotalBedUsedDays { get; set; }
        public Nullable<int> OperID { get; set; }
        public Nullable<System.DateTime> InputTime { get; set; }
        public Nullable<decimal> BedUsedRates { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
