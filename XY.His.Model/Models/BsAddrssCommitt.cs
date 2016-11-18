using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsAddrssCommitt
    {
        public int ID { get; set; }
        public string AdrressKey { get; set; }
        public int CommitteeId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public virtual BsAreaCommittee BsAreaCommittee { get; set; }
    }
}
