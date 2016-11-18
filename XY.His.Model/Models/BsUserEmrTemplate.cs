using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsUserEmrTemplate
    {
        public int ID { get; set; }
        public int OperId { get; set; }
        public int CatalogId { get; set; }
        public string Name { get; set; }
        public string TemplateFile { get; set; }
        public bool IsDefault { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<short> LsOpenType { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
