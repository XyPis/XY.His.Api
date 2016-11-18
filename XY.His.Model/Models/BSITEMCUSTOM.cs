using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BSITEMCUSTOM
    {
        public int ID { get; set; }
        public int ITEMID { get; set; }
        public Nullable<int> REPORTID { get; set; }
        public string CUSTOMTYPE { get; set; }
        public Nullable<int> ORDERBY { get; set; }
        public Nullable<int> ICONINDEX { get; set; }
        public string MEMO { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BSITEMCUSTOMGROUP BSITEMCUSTOMGROUP { get; set; }
    }
}
