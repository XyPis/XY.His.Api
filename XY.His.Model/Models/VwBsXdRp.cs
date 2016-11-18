using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwBsXdRp
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string GroupMain { get; set; }
        public string GroupSub { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public string LocationName { get; set; }
        public string ItemName { get; set; }
        public string UserName { get; set; }
        public int ItemId { get; set; }
        public int LocationId { get; set; }
        public int OperId { get; set; }
        public short LsOpenType { get; set; }
    }
}
