using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwBedSearch
    {
        public int ID { get; set; }
        public Nullable<int> BedId { get; set; }
        public string Name { get; set; }
        public string RoomNo { get; set; }
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public Nullable<int> ItemId { get; set; }
        public Nullable<decimal> PriceIn { get; set; }
        public bool IsAdd { get; set; }
        public string Memo { get; set; }
        public int OperID { get; set; }
        public System.DateTime OperTime { get; set; }
        public short OrderBy { get; set; }
        public short IconIndex { get; set; }
        public bool IsActive { get; set; }
        public short LsClass { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<bool> IsTaked { get; set; }
        public int LsBALL { get; set; }
        public string LsBALLName { get; set; }
        public Nullable<int> HospId { get; set; }
        public string HospNo { get; set; }
        public Nullable<int> PatID { get; set; }
        public string InPatNo { get; set; }
        public string PatientName { get; set; }
        public Nullable<int> NTime { get; set; }
        public Nullable<System.DateTime> InTime { get; set; }
        public Nullable<int> Age { get; set; }
        public string Sex { get; set; }
        public string SexName { get; set; }
        public Nullable<bool> IsBaby { get; set; }
        public string CardNo { get; set; }
        public Nullable<int> CaptionIcon { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public Nullable<int> MainBedId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string DoctorName { get; set; }
        public string IllDesc { get; set; }
    }
}
