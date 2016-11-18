using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsUserWindow
    {
        public int ID { get; set; }
        public int OperId { get; set; }
        public int MenuId { get; set; }
        public string Name { get; set; }
        public string Caption { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual GblSystemMenu GblSystemMenu { get; set; }
    }
}
