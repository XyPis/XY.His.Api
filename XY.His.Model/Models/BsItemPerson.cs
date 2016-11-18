using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsItemPerson
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public int UserId { get; set; }
        public Nullable<int> PatId { get; set; }
        public Nullable<System.DateTime> FromTime { get; set; }
        public Nullable<System.DateTime> ToTime { get; set; }
        public Nullable<bool> IsExcept { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
