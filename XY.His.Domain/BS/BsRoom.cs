using System;
using System.Collections.Generic;
using XY.His.Domain.RM;

namespace XY.His.Domain.BS
{
    public partial class BsRoom : EntityBase
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short LsInOut { get; set; }
        public int LocationId { get; set; }
        public short LsRoomType { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
    }
}
