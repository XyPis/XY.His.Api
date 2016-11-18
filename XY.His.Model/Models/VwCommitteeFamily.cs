using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwCommitteeFamily
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string ParentID { get; set; }
        public string FormName { get; set; }
        public int RecordId { get; set; }
    }
}
