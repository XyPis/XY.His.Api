using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class DgDrugTip
    {
        public int ID { get; set; }
        public int DrugID { get; set; }
        public string Sex { get; set; }
        public int AgeFrom { get; set; }
        public int AgeTo { get; set; }
        public Nullable<decimal> Weight { get; set; }
        public Nullable<int> WorktypeId { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<int> IcdId { get; set; }
        public Nullable<short> LsWomenStatus { get; set; }
        public Nullable<int> DropSpeed { get; set; }
        public string LClass { get; set; }
        public string Expain { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<decimal> Dosage { get; set; }
        public virtual BsBaseDrug BsBaseDrug { get; set; }
        public virtual BsWorkType BsWorkType { get; set; }
    }
}
