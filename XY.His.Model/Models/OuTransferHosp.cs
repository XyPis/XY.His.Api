using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuTransferHosp
    {
        public int ID { get; set; }
        public string InPatNo { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> HospId { get; set; }
        public int HospitalId { get; set; }
        public System.DateTime OutTime { get; set; }
        public string Reason { get; set; }
        public string Memo { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public Nullable<System.DateTime> ReturnTime { get; set; }
        public string ReturnMemo { get; set; }
        public Nullable<System.DateTime> ReturnOperTime { get; set; }
        public Nullable<int> ReturnOperID { get; set; }
        public virtual BsHospital BsHospital { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsUser BsUser1 { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
    }
}
