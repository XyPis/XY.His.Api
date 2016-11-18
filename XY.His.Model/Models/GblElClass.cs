using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblElClass
    {
        public GblElClass()
        {
            this.ElPatFormValues = new List<ElPatFormValue>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual ICollection<ElPatFormValue> ElPatFormValues { get; set; }
    }
}
