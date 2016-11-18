using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkBloodSend
    {
        public int ID { get; set; }
        public string RecNo { get; set; }
        public int LabId { get; set; }
        public int BloodId { get; set; }
        public System.DateTime NoteTime { get; set; }
        public int NoteOperId { get; set; }
        public Nullable<bool> IsSend { get; set; }
        public Nullable<System.DateTime> SendTime { get; set; }
        public Nullable<int> SendOperId { get; set; }
        public string TakeMan { get; set; }
        public string Memo { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual CkBdBank CkBdBank { get; set; }
        public virtual CkLab CkLab { get; set; }
    }
}
