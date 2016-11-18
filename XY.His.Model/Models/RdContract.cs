using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RdContract
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string Code { get; set; }
        public string Content { get; set; }
        public bool IsTeach { get; set; }
        public bool IsMessage { get; set; }
        public bool IsEmail { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
