using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class ElPatForm
    {
        public ElPatForm()
        {
            this.ElPatFormDrugs = new List<ElPatFormDrug>();
            this.ElPatFormTests = new List<ElPatFormTest>();
            this.ElPatFormTrans = new List<ElPatFormTran>();
            this.ElPatFormValues = new List<ElPatFormValue>();
        }

        public int ID { get; set; }
        public Nullable<int> PatId { get; set; }
        public Nullable<int> HospitalId { get; set; }
        public int PatMenuId { get; set; }
        public Nullable<int> RecId { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public Nullable<bool> IsAuth { get; set; }
        public Nullable<System.DateTime> AuthTime { get; set; }
        public string RejectReason { get; set; }
        public bool IsActive { get; set; }
        public string InActiveReason { get; set; }
        public Nullable<System.DateTime> InActiveTime { get; set; }
        public Nullable<int> InActiveOperID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsHospital BsHospital { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual ElPatRecord ElPatRecord { get; set; }
        public virtual GblPatientMenu GblPatientMenu { get; set; }
        public virtual ICollection<ElPatFormDrug> ElPatFormDrugs { get; set; }
        public virtual ICollection<ElPatFormTest> ElPatFormTests { get; set; }
        public virtual ICollection<ElPatFormTran> ElPatFormTrans { get; set; }
        public virtual ICollection<ElPatFormValue> ElPatFormValues { get; set; }
    }
}
