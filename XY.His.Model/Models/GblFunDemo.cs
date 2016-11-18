using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblFunDemo
    {
        public int ID { get; set; }
        public string Purpose { get; set; }
        public Nullable<int> FuntionId { get; set; }
        public string Memo { get; set; }
        public Nullable<int> OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual GblFuction GblFuction { get; set; }
    }
}
