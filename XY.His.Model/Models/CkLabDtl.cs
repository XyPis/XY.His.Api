using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkLabDtl
    {
        public int ID { get; set; }
        public int LabId { get; set; }
        public int TestId { get; set; }
        public Nullable<int> SourceId { get; set; }
        public Nullable<int> TubeTypeId { get; set; }
        public bool IsDownLoad { get; set; }
        public bool IsPrint { get; set; }
        public Nullable<System.DateTime> PrintTime { get; set; }
        public Nullable<int> PrintOperId { get; set; }
        public bool IsBilled { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> ParentID { get; set; }
        public Nullable<int> RecipeDtlId { get; set; }
        public Nullable<int> DetailId { get; set; }
        public string ItemId { get; set; }
        public virtual BsLabSource BsLabSource { get; set; }
        public virtual BsTubeType BsTubeType { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual CkLab CkLab { get; set; }
    }
}
