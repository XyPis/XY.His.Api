using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsHospital
    {
        public BsHospital()
        {
            this.BsDiagRooms = new List<BsDiagRoom>();
            this.BsLocations = new List<BsLocation>();
            this.BsUsers = new List<BsUser>();
            this.DhInAdviceLongs = new List<DhInAdviceLong>();
            this.DhInAdviceTemps = new List<DhInAdviceTemp>();
            this.DhStores = new List<DhStore>();
            this.ElPatForms = new List<ElPatForm>();
            this.ElTipsPats = new List<ElTipsPat>();
            this.OuTransferHosps = new List<OuTransferHosp>();
        }

        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public int AreaId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<decimal> Area { get; set; }
        public Nullable<decimal> Farthest { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public Nullable<int> ResidentPopulation { get; set; }
        public Nullable<int> TentPopulation { get; set; }
        public string Memo { get; set; }
        public short IconIndex { get; set; }
        public virtual BsArea BsArea { get; set; }
        public virtual ICollection<BsDiagRoom> BsDiagRooms { get; set; }
        public virtual ICollection<BsLocation> BsLocations { get; set; }
        public virtual ICollection<BsUser> BsUsers { get; set; }
        public virtual ICollection<DhInAdviceLong> DhInAdviceLongs { get; set; }
        public virtual ICollection<DhInAdviceTemp> DhInAdviceTemps { get; set; }
        public virtual ICollection<DhStore> DhStores { get; set; }
        public virtual ICollection<ElPatForm> ElPatForms { get; set; }
        public virtual ICollection<ElTipsPat> ElTipsPats { get; set; }
        public virtual ICollection<OuTransferHosp> OuTransferHosps { get; set; }
    }
}
