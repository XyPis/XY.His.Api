using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TmpItem
    {
        public int ID { get; set; }
        public Nullable<int> MenuId { get; set; }
        public string CKey { get; set; }
        public string CType { get; set; }
        public string Value { get; set; }
        public Nullable<int> LsType { get; set; }
        public Nullable<int> OperId { get; set; }
        public string TempName { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual GblSystemMenu GblSystemMenu { get; set; }
    }
}
