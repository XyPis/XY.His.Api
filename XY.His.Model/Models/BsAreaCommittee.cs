using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsAreaCommittee
    {
        public BsAreaCommittee()
        {
            this.BsAddrssCommitts = new List<BsAddrssCommitt>();
            this.BsCommitteeRoads = new List<BsCommitteeRoad>();
            this.BsFamilies = new List<BsFamily>();
            this.RdNewBirths = new List<RdNewBirth>();
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
        public short IconIndex { get; set; }
        public Nullable<int> PoliceStationId { get; set; }
        public virtual ICollection<BsAddrssCommitt> BsAddrssCommitts { get; set; }
        public virtual ICollection<BsCommitteeRoad> BsCommitteeRoads { get; set; }
        public virtual ICollection<BsFamily> BsFamilies { get; set; }
        public virtual ICollection<RdNewBirth> RdNewBirths { get; set; }
    }
}
