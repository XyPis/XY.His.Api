using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class InEMR
    {
        public InEMR()
        {
            this.InEmrXmls = new List<InEmrXml>();
        }

        public int ID { get; set; }
        public string RecNo { get; set; }
        public int HospId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public Nullable<System.DateTime> ModifyOperTime { get; set; }
        public Nullable<int> ModifyOperID { get; set; }
        public int CatalogId { get; set; }
        public byte[] Content { get; set; }
        public string XMLFile { get; set; }
        public bool IsAuth { get; set; }
        public Nullable<System.DateTime> AuthOperTime { get; set; }
        public Nullable<int> AuthOperId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public byte[] XMLContent { get; set; }
        public Nullable<bool> IsRealease { get; set; }
        public Nullable<System.DateTime> RealeaseTime { get; set; }
        public Nullable<int> RealeaseOperId { get; set; }
        public Nullable<bool> IsPrint { get; set; }
        public Nullable<System.DateTime> PrintTime { get; set; }
        public Nullable<int> PrintOperId { get; set; }
        public Nullable<bool> IsClosed { get; set; }
        public Nullable<System.DateTime> ClosedTime { get; set; }
        public Nullable<int> ClosedOperId { get; set; }
        public Nullable<bool> IsCheck { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string F5 { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> OperTime2 { get; set; }
        public string F6 { get; set; }
        public string F7 { get; set; }
        public string F8 { get; set; }
        public virtual BsUser BsUser { get; set; }
        public virtual BsUser BsUser1 { get; set; }
        public virtual GblEMRCatalog GblEMRCatalog { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual ICollection<InEmrXml> InEmrXmls { get; set; }
    }
}
