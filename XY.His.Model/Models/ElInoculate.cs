using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class ElInoculate
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public int ItemId { get; set; }
        public short NTime { get; set; }
        public System.DateTime PlanTime { get; set; }
        public int PlanOperId { get; set; }
        public string Memo { get; set; }
        public bool IsInoculate { get; set; }
        public Nullable<System.DateTime> InoTime { get; set; }
        public Nullable<int> InoOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsUser BsUser1 { get; set; }
    }
}
