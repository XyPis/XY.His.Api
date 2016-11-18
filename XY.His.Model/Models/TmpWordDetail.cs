using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TmpWordDetail
    {
        public int ID { get; set; }
        public string UseType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int ParentID { get; set; }
        public short LsOpenType { get; set; }
        public Nullable<int> OperID { get; set; }
        public System.DateTime OperTime { get; set; }
        public Nullable<int> LocationId { get; set; }
        public int OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
