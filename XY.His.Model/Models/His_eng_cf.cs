using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class His_eng_cf
    {
        public int Id { get; set; }
        public int depart_id { get; set; }
        public string Department { get; set; }
        public string Age { get; set; }
        public string pres_type { get; set; }
        public System.DateTime pres_date_time { get; set; }
        public string Sex { get; set; }
        public string pay_type { get; set; }
        public string patient_no { get; set; }
        public string pres_no { get; set; }
        public string Name { get; set; }
        public string Diagnose { get; set; }
        public string Address { get; set; }
        public string Phone_no { get; set; }
        public string Id_card { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string Birth_weight { get; set; }
        public string Ccr { get; set; }
        public string allergy_list { get; set; }
        public string Pregnancy { get; set; }
        public string time_of_preg { get; set; }
        public string breast_feeding { get; set; }
        public string Dialysis { get; set; }
        public string prox_name { get; set; }
        public string prox_id_card { get; set; }
        public string doc_id { get; set; }
        public string doc_name { get; set; }
        public string doc_title { get; set; }
        public string doc_group { get; set; }
        public string dept_group { get; set; }
        public Nullable<decimal> Total_amount { get; set; }
        public string pres_source { get; set; }
        public string Pharm_audt_id { get; set; }
        public string Pharm_audt_name { get; set; }
        public string Pharm_pre_ID { get; set; }
        public string Pharm_pre_name { get; set; }
        public string Pharm_chk_id { get; set; }
        public string Pharm_chk_name { get; set; }
        public string Pharm_delv_id { get; set; }
        public string Pharm_delv_name { get; set; }
        public string corres_cf_presno { get; set; }
    }
}
