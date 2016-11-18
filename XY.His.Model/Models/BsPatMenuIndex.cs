using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsPatMenuIndex
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public int PatMenuId { get; set; }
        public string ParentID { get; set; }
        public int RecordId { get; set; }
        public string Tips { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual GblPatientMenu GblPatientMenu { get; set; }
    }
}
