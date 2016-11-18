using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblPatientMenu
    {
        public GblPatientMenu()
        {
            this.BsPatMenuIndexes = new List<BsPatMenuIndex>();
            this.ElEhrs = new List<ElEhr>();
            this.ElFormBsPats = new List<ElFormBsPat>();
            this.ElFormDtls = new List<ElFormDtl>();
            this.ElPatForms = new List<ElPatForm>();
            this.ElTips = new List<ElTip>();
            this.GblPatientMenu1 = new List<GblPatientMenu>();
        }

        public int ID { get; set; }
        public short LsType { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public Nullable<int> ParentID { get; set; }
        public bool IsTitle { get; set; }
        public string FormName { get; set; }
        public string TableName { get; set; }
        public bool IsForNew { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<bool> IsAuth { get; set; }
        public Nullable<bool> IsPrint { get; set; }
        public string SearchConfig { get; set; }
        public virtual ICollection<BsPatMenuIndex> BsPatMenuIndexes { get; set; }
        public virtual ICollection<ElEhr> ElEhrs { get; set; }
        public virtual ICollection<ElFormBsPat> ElFormBsPats { get; set; }
        public virtual ICollection<ElFormDtl> ElFormDtls { get; set; }
        public virtual ICollection<ElPatForm> ElPatForms { get; set; }
        public virtual ICollection<ElTip> ElTips { get; set; }
        public virtual ICollection<GblPatientMenu> GblPatientMenu1 { get; set; }
        public virtual GblPatientMenu GblPatientMenu2 { get; set; }
    }
}
