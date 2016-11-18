using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblReportDetail
    {
        public int ID { get; set; }
        public int GroupId { get; set; }
        public int FeeId { get; set; }
        public virtual GblReportGroup GblReportGroup { get; set; }
    }
}
