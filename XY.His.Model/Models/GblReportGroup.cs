using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblReportGroup
    {
        public GblReportGroup()
        {
            this.GblReportDetails = new List<GblReportDetail>();
        }

        public int ID { get; set; }
        public int ReportId { get; set; }
        public string Name { get; set; }
        public int OrderBy { get; set; }
        public virtual GblReport GblReport { get; set; }
        public virtual ICollection<GblReportDetail> GblReportDetails { get; set; }
    }
}
