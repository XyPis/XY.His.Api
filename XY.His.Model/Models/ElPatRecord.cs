using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class ElPatRecord
    {
        public ElPatRecord()
        {
            this.DhInAdviceLongs = new List<DhInAdviceLong>();
            this.DhInAdviceTemps = new List<DhInAdviceTemp>();
            this.ElPatForms = new List<ElPatForm>();
        }

        public int ID { get; set; }
        public Nullable<int> PatId { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public int GroupId { get; set; }
        public string RecNo { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ICollection<DhInAdviceLong> DhInAdviceLongs { get; set; }
        public virtual ICollection<DhInAdviceTemp> DhInAdviceTemps { get; set; }
        public virtual ICollection<ElPatForm> ElPatForms { get; set; }
    }
}
