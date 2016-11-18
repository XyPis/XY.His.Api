using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsPatIll
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public Nullable<int> IcdId { get; set; }
        public string IllDesc { get; set; }
        public Nullable<short> LsWestChin { get; set; }
        public Nullable<System.DateTime> IllTime { get; set; }
        public string ConfirmDoctor { get; set; }
        public Nullable<short> LsEffect { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> OperID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsIllness BsIllness { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
