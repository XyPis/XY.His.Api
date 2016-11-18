using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class INBABYBODYHEAT
    {
        public int id { get; set; }
        public int hospid { get; set; }
        public System.DateTime opertime { get; set; }
        public int operid { get; set; }
        public decimal animalheat { get; set; }
        public string heattype { get; set; }
        public short pulse { get; set; }
        public short heart { get; set; }
        public string breath { get; set; }
        public string stool { get; set; }
        public string urine { get; set; }
        public string weight { get; set; }
        public string bldpress0 { get; set; }
        public string bldpress1 { get; set; }
        public string fluidm { get; set; }
        public string totalin { get; set; }
        public string urinem { get; set; }
        public string otherm { get; set; }
        public string totalout { get; set; }
        public string memoup { get; set; }
        public string memodn { get; set; }
        public bool spintest { get; set; }
        public bool lowertemp { get; set; }
        public bool isrecheck { get; set; }
        public bool isoutside { get; set; }
        public bool ismachine { get; set; }
        public string others { get; set; }
        public bool isops { get; set; }
        public Nullable<System.DateTime> birthtime { get; set; }
        public bool isreject { get; set; }
        public Nullable<System.DateTime> deadtime { get; set; }
        public Nullable<int> locationid { get; set; }
        public string f1 { get; set; }
        public string f2 { get; set; }
        public string f3 { get; set; }
        public string f4 { get; set; }
        public Nullable<decimal> bg { get; set; }
        public string cwinject { get; set; }
        public string jminject { get; set; }
        public string cwheight { get; set; }
        public Nullable<bool> ismotherfeed { get; set; }
        public Nullable<bool> ishumanfeed { get; set; }
        public Nullable<int> ubsstool { get; set; }
        public Nullable<int> umbilical { get; set; }
        public string f5 { get; set; }
        public string f6 { get; set; }
    }
}
