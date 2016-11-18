using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class his_eng_order_drug
    {
        public string Id { get; set; }
        public int order_id { get; set; }
        public string Type { get; set; }
        public string start_time { get; set; }
        public string end_time { get; set; }
        public Nullable<int> continue_day { get; set; }
        public string first_execute_time { get; set; }
        public int group_no { get; set; }
        public int co_admin { get; set; }
        public string drug_id { get; set; }
        public string drug_name { get; set; }
        public string reg_name { get; set; }
        public string Manufacturer_name { get; set; }
        public Nullable<decimal> Content { get; set; }
        public string content_unit { get; set; }
        public Nullable<decimal> Pack { get; set; }
        public string pack_unit { get; set; }
        public string dispense_unit { get; set; }
        public Nullable<decimal> Quantity { get; set; }
        public Nullable<decimal> unit_price { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public string admin_route { get; set; }
        public string prep_form { get; set; }
        public string admin_dose { get; set; }
        public string admin_frequency { get; set; }
        public string admin_method { get; set; }
        public string admin_goal { get; set; }
        public string doc_id { get; set; }
        public string doc_name { get; set; }
        public string doc_title { get; set; }
        public string Pharm_pre_id { get; set; }
        public string Pharm_chk_id { get; set; }
        public string Qty { get; set; }
        public string qty_unit { get; set; }
    }
}
