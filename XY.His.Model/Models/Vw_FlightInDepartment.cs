using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class Vw_FlightInDepartment
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string 科室简称或别名 { get; set; }
        public string 临床科室属性 { get; set; }
        public short LsInOut { get; set; }
        public string 内外科标志 { get; set; }
        public string 输入码 { get; set; }
    }
}
