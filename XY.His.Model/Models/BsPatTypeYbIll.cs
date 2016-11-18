using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsPatTypeYbIll
    {
        public BsPatTypeYbIll()
        {
            this.OuInvoices = new List<OuInvoice>();
        }

        public int ID { get; set; }
        public Nullable<int> TallyTypeId { get; set; }
        public Nullable<int> PatTypeId { get; set; }
        public string YbCode { get; set; }
        public string YbDesc { get; set; }
        public string IllIds { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsPatType BsPatType { get; set; }
        public virtual BsTallyType BsTallyType { get; set; }
        public virtual ICollection<OuInvoice> OuInvoices { get; set; }
    }
}
