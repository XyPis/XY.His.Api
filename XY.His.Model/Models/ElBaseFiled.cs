using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class ElBaseFiled
    {
        public ElBaseFiled()
        {
            this.ElDropDowns = new List<ElDropDown>();
            this.ElFormDtls = new List<ElFormDtl>();
            this.ElPatFormValues = new List<ElPatFormValue>();
            this.ElPatFormVDtls = new List<ElPatFormVDtl>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<short> LsDataType { get; set; }
        public Nullable<short> Lengh { get; set; }
        public string EditMask { get; set; }
        public string Memo { get; set; }
        public string ToolTips { get; set; }
        public string ErrorTips { get; set; }
        public Nullable<bool> IsHasChild { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<bool> IsEncrypt { get; set; }
        public Nullable<bool> IsLog { get; set; }
        public virtual ICollection<ElDropDown> ElDropDowns { get; set; }
        public virtual ICollection<ElFormDtl> ElFormDtls { get; set; }
        public virtual ICollection<ElPatFormValue> ElPatFormValues { get; set; }
        public virtual ICollection<ElPatFormVDtl> ElPatFormVDtls { get; set; }
    }
}
