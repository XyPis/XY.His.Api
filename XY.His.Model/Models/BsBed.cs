using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class BsBed
    {
        public BsBed()
        {
            this.InHosBeds = new List<InHosBed>();
            this.InHosInfoes = new List<InHosInfo>();
            this.InOutLocations = new List<InOutLocation>();
            this.InChangeBeds = new List<InChangeBed>();
            this.InChangeBeds1 = new List<InChangeBed>();
        }

        public int ID { get; set; }
        public string Name { get; set; }
        public string RoomNo { get; set; }
        public int LocationId { get; set; }
        public short LsBALL { get; set; }
        public Nullable<int> ItemId { get; set; }
        public bool IsAdd { get; set; }
        public string Memo { get; set; }
        public int OperID { get; set; }
        public System.DateTime OperTime { get; set; }
        public short OrderBy { get; set; }
        public bool IsActive { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public short LsClass { get; set; }
        public Nullable<bool> IsAddBed { get; set; }
        public virtual ICollection<InHosBed> InHosBeds { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual BsItem BsItem { get; set; }
        public virtual ICollection<InHosInfo> InHosInfoes { get; set; }
        public virtual ICollection<InOutLocation> InOutLocations { get; set; }
        public virtual ICollection<InChangeBed> InChangeBeds { get; set; }
        public virtual ICollection<InChangeBed> InChangeBeds1 { get; set; }
    }
}
