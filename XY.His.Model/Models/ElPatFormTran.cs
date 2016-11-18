using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class ElPatFormTran
    {
        public int ID { get; set; }
        public Nullable<int> PatFormId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string RecNo { get; set; }
        public Nullable<System.DateTime> ChangeTime { get; set; }
        public Nullable<int> ChangeOperId { get; set; }
        public string Reason { get; set; }
        public string FromHospital { get; set; }
        public string ToHospital { get; set; }
        public Nullable<System.DateTime> RecieveTime { get; set; }
        public Nullable<int> RecieveOperId { get; set; }
        public string Disposal { get; set; }
        public string Diagnose { get; set; }
        public string Memo { get; set; }
        public virtual ElPatForm ElPatForm { get; set; }
    }
}
