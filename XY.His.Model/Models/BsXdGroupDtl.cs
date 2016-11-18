using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsXdGroupDtl
    {
        public int ID { get; set; }
        public int GroupId { get; set; }
        public int XdRpId { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public short LsOpenType { get; set; }
        public int OperId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int LocationId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsXdGroup BsXdGroup { get; set; }
    }
}
