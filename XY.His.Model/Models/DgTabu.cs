using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DgTabu
    {
        public int ID { get; set; }
        public int DrugID { get; set; }
        public int DrugID1 { get; set; }
        public Nullable<int> DrugID2 { get; set; }
        public Nullable<int> DrugID3 { get; set; }
        public Nullable<int> DrugID4 { get; set; }
        public string LClass { get; set; }
        public string Expain { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsBaseDrug BsBaseDrug { get; set; }
    }
}
