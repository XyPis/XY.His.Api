using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class FtMain
    {
        public FtMain()
        {
            this.FtDetails = new List<FtDetail>();
        }

        public int ID { get; set; }
        public string CheckNo { get; set; }
        public Nullable<int> UserId { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public string Memo { get; set; }
        public Nullable<bool> IsPrint { get; set; }
        public bool IsConfirm { get; set; }
        public Nullable<System.DateTime> ConfirmOperTime { get; set; }
        public Nullable<int> ConfirmOperID { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual ICollection<FtDetail> FtDetails { get; set; }
    }
}
