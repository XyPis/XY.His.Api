using System;
using System.Collections.Generic;

namespace XY.His.Domain.BS
{
    public partial class BsItemNameMulti : EntityBase
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public string NameMulti { get; set; }
        public string WbMulti { get; set; }
        public string PyMulti { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
