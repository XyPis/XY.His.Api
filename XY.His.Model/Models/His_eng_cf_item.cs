using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class His_eng_cf_item
    {
        public int Id { get; set; }
        public int Cfid { get; set; }
        public string Drug { get; set; }
        public string drug_name { get; set; }
        public string reg_name { get; set; }
        public string Manufacturer_name { get; set; }
        public Nullable<short> continue_day { get; set; }
        public string Spec { get; set; }
        public Nullable<decimal> Content { get; set; }
        public Nullable<int> content_unit { get; set; }
        public Nullable<decimal> Pack { get; set; }
        public decimal Quantity { get; set; }
        public int dispense_unit { get; set; }
        public string pack_unit { get; set; }
        public decimal unit_price { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public short group_no { get; set; }
        public string first_use { get; set; }
        public string prep_form { get; set; }
        public string admin_route { get; set; }
        public string admin_area { get; set; }
        public string admin_frequency { get; set; }
        public string admin_dose { get; set; }
        public string admin_method { get; set; }
        public string special_promote { get; set; }
        public string skin_test { get; set; }
    }
}
