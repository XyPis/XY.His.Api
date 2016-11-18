using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblFieldDesc
    {
        public int ID { get; set; }
        public string TableName { get; set; }
        public string FieldName { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
