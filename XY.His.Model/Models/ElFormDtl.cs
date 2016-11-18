using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class ElFormDtl
    {
        public int ID { get; set; }
        public int PatMenuId { get; set; }
        public Nullable<int> ElId { get; set; }
        public Nullable<short> NColumn { get; set; }
        public Nullable<short> NRow { get; set; }
        public Nullable<short> ColumnSpan { get; set; }
        public string Title { get; set; }
        public Nullable<bool> IsReadOnly { get; set; }
        public Nullable<bool> IsRequire { get; set; }
        public string DefultValue { get; set; }
        public Nullable<short> LsAlignment { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<bool> IsInherit { get; set; }
        public Nullable<short> ColWidth { get; set; }
        public Nullable<decimal> FontSize { get; set; }
        public string FontColor { get; set; }
        public virtual ElBaseFiled ElBaseFiled { get; set; }
        public virtual GblPatientMenu GblPatientMenu { get; set; }
    }
}
