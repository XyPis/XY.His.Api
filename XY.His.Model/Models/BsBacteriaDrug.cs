using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsBacteriaDrug
    {
        public int ID { get; set; }
        public int BactriaId { get; set; }
        public int DrugId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsBacteria BsBacteria { get; set; }
        public virtual BsBaseDrug BsBaseDrug { get; set; }
    }
}
