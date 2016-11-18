using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CategoryLog
    {
        public int CategoryLogID { get; set; }
        public int CategoryID { get; set; }
        public int LogID { get; set; }
        public virtual Category Category { get; set; }
        public virtual Log Log { get; set; }
    }
}
