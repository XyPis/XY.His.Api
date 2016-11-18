using System;
using System.Collections.Generic;

namespace XY.His.Domain.BS
{
    public partial class BsItemYb : EntityBase
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public int TallyGroupId { get; set; }
        public string YbCode { get; set; }
        public string YbDesc { get; set; }
        public short LsYbType { get; set; }
        public short IconIndex { get; set; }
        public Nullable<short> LsAuthstatus { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string DrugCode { get; set; }
    }
}
