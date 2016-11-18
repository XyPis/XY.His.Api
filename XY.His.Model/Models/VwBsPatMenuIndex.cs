using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwBsPatMenuIndex
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public string PatientName { get; set; }
        public string Sex { get; set; }
        public Nullable<int> CommitteeId { get; set; }
        public int PatMenuId { get; set; }
        public int RecordId { get; set; }
        public string Tips { get; set; }
        public short LsType { get; set; }
        public string Code { get; set; }
        public string MenuName { get; set; }
        public Nullable<int> ParentID { get; set; }
        public bool IsTitle { get; set; }
        public string FormName { get; set; }
        public string TableName { get; set; }
        public bool IsForNew { get; set; }
        public Nullable<int> FamilyId { get; set; }
        public Nullable<int> PatTypeId { get; set; }
    }
}
