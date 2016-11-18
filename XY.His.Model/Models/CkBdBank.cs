using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class CkBdBank
    {
        public CkBdBank()
        {
            this.CkBldReactions = new List<CkBldReaction>();
            this.CkBldToStations = new List<CkBldToStation>();
            this.CkBloodBacks = new List<CkBloodBack>();
            this.CkBloodSends = new List<CkBloodSend>();
        }

        public int ID { get; set; }
        public string SerialNo { get; set; }
        public short BloodTypeId { get; set; }
        public string BloodGroup { get; set; }
        public string RHD { get; set; }
        public System.DateTime RecieveDate { get; set; }
        public int RecieveOperId { get; set; }
        public short LsSource { get; set; }
        public string Account { get; set; }
        public Nullable<System.DateTime> ExpireDate { get; set; }
        public string OfferMan { get; set; }
        public Nullable<System.DateTime> CollectDate { get; set; }
        public string CollectMan { get; set; }
        public Nullable<decimal> Vollume { get; set; }
        public Nullable<decimal> Price { get; set; }
        public short LsStatus { get; set; }
        public Nullable<System.DateTime> BackDate { get; set; }
        public Nullable<int> BackOperId { get; set; }
        public string BackMemo { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Unit { get; set; }
        public string DiscardReason { get; set; }
        public Nullable<System.DateTime> DiscardTime { get; set; }
        public Nullable<int> DiscardOperID { get; set; }
        public virtual ICollection<CkBldReaction> CkBldReactions { get; set; }
        public virtual ICollection<CkBldToStation> CkBldToStations { get; set; }
        public virtual ICollection<CkBloodBack> CkBloodBacks { get; set; }
        public virtual ICollection<CkBloodSend> CkBloodSends { get; set; }
    }
}
