using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsItemName
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public string Name { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsItem BsItem { get; set; }
    }
}
