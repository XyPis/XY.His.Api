using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblFuction
    {
        public GblFuction()
        {
            this.GblFunDemoes = new List<GblFunDemo>();
            this.GblFunTraces = new List<GblFunTrace>();
        }

        public int ID { get; set; }
        public Nullable<int> MenuId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Memo { get; set; }
        public Nullable<bool> IsTest { get; set; }
        public Nullable<short> LsClass { get; set; }
        public int OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Code { get; set; }
        public virtual GblSystemMenu GblSystemMenu { get; set; }
        public virtual ICollection<GblFunDemo> GblFunDemoes { get; set; }
        public virtual ICollection<GblFunTrace> GblFunTraces { get; set; }
    }
}
