using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RdFollow
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int DoctorId { get; set; }
        public int OperID { get; set; }
        public string Code { get; set; }
        public System.DateTime PlanTime { get; set; }
        public string VisitMan { get; set; }
        public string Purpose { get; set; }
        public short LsVisitType { get; set; }
        public bool IsVisited { get; set; }
        public string Process { get; set; }
        public string Result { get; set; }
        public string Other { get; set; }
        public string SumUp { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
