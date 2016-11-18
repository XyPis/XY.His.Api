using System;
using System.Collections.Generic;

namespace XY.His.Domain.Gbl
{
    public partial class GblSetting : EntityBase
    {
        public int ID { get; set; }
        public string KeyNum { get; set; }
        public string SetValue { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
    }
}
