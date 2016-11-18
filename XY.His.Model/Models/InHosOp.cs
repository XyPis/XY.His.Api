using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InHosOp
    {
        public int ID { get; set; }
        public int HospId { get; set; }
        public int OpsTimes { get; set; }
        public Nullable<System.DateTime> OpsTime { get; set; }
        public Nullable<int> OpsId { get; set; }
        public Nullable<short> LsCut { get; set; }
        public Nullable<short> LsRecove { get; set; }
        public Nullable<int> OpsDoctorId { get; set; }
        public Nullable<int> AnaesId { get; set; }
        public Nullable<int> AssistantOperId1 { get; set; }
        public Nullable<int> AssistantOperId2 { get; set; }
        public Nullable<int> AnaesDoctorId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsAnae BsAnae { get; set; }
        public virtual BsDoctor BsDoctor { get; set; }
        public virtual BsDoctor BsDoctor1 { get; set; }
        public virtual BsOP BsOP { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsUser BsUser1 { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
