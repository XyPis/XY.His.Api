using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class his_eng_order_operation
    {
        public int ID { get; set; }
        public Nullable<int> order_id { get; set; }
        public string code { get; set; }
        public string name { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public string incision_type { get; set; }
        public string incision_status { get; set; }
        public string Inplant { get; set; }
    }
}
