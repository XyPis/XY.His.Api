using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class his_eng_order_diagnose
    {
        public int Id { get; set; }
        public int order_id { get; set; }
        public string Date { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public string dscharge_type { get; set; }
        public string icde10 { get; set; }
    }
}
