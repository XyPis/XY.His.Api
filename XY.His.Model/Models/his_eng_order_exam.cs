using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class his_eng_order_exam
    {
        public int Id { get; set; }
        public Nullable<int> order_id { get; set; }
        public string sample_id { get; set; }
        public string sample_type { get; set; }
        public string sample_name { get; set; }
        public string Sample { get; set; }
        public string exam_item_id { get; set; }
        public string exam_item_name { get; set; }
        public string Department { get; set; }
        public string doc_name { get; set; }
        public System.DateTime send_time { get; set; }
        public Nullable<System.DateTime> receive_time { get; set; }
        public Nullable<System.DateTime> report_time { get; set; }
        public string receive_doc_id { get; set; }
        public string report_doc_id { get; set; }
        public string check_doc_id { get; set; }
    }
}
