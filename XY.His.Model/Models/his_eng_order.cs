using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class his_eng_order
    {
        public int Id { get; set; }
        public string Sex { get; set; }
        public string pay_type { get; set; }
        public string Patient_no { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string phone_no { get; set; }
        public string id_card { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string birth_weight { get; set; }
        public string Allergy_list { get; set; }
        public string Pregnancy { get; set; }
        public string time_of_preg { get; set; }
        public string breast_feeding { get; set; }
        public string Birthday { get; set; }
        public string Marital { get; set; }
        public string Occpation { get; set; }
        public string Natonality { get; set; }
        public int entry_time { get; set; }
        public string in_date { get; set; }
        public string in_department { get; set; }
        public string in_area { get; set; }
        public string out_date { get; set; }
        public string out_department { get; set; }
        public string doc_group { get; set; }
        public string dept_group { get; set; }
        public string out_area { get; set; }
        public string hi_code { get; set; }
        public string hi_name { get; set; }
        public string hi_out_come { get; set; }
        public string rescue_times { get; set; }
        public string rescue_succ_times { get; set; }
        public string pathologic_diag { get; set; }
        public string pathologic_name { get; set; }
        public decimal bed_fee { get; set; }
        public decimal nurse_fee { get; set; }
        public decimal wm_fee { get; set; }
        public decimal cpd_fee { get; set; }
        public decimal cmh_fee { get; set; }
        public string radio_fee { get; set; }
        public string exam_fee { get; set; }
        public string oxy_fee { get; set; }
        public string blood_fee { get; set; }
        public string operation_fee { get; set; }
        public string check_fee { get; set; }
        public string anesth_fee { get; set; }
        public string treat_fee { get; set; }
        public string other_fee { get; set; }
        public decimal total_fee { get; set; }
    }
}
