using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class INADVICENURSE
    {
        public int ID { get; set; }
        public System.DateTime ADVICETIME { get; set; }
        public int LocationId { get; set; }
        public int HOSPID { get; set; }
        public int GROUPNUM { get; set; }
        public int ItemID { get; set; }
        public decimal DOSAGE { get; set; }
        public Nullable<int> UNITTAKEID { get; set; }
        public Nullable<int> FREQUENCYID { get; set; }
        public Nullable<int> USAGEID { get; set; }
        public decimal PRICEIN { get; set; }
        public decimal TOTALITY { get; set; }
        public int UNITINID { get; set; }
        public bool ISURGENT { get; set; }
        public int LSEXECLOC { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public bool ISAUTH { get; set; }
        public Nullable<System.DateTime> AUTHOPERTIME { get; set; }
        public Nullable<int> AuthOperId { get; set; }
        public bool ISLONG { get; set; }
        public bool IsCancel { get; set; }
        public Nullable<System.DateTime> CANCELOPERTIME { get; set; }
        public Nullable<int> CancelOperId { get; set; }
        public string Memo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsFrequency BsFrequency { get; set; }
        public virtual BsUnit BsUnit { get; set; }
        public virtual BsUnit BsUnit1 { get; set; }
        public virtual BsUsage BsUsage { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
    }
}
