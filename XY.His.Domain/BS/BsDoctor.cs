using System;
using System.Collections.Generic;

namespace XY.His.Domain.BS
{
    public partial class BsDoctor : EntityBase
    {
        public int ID { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Sex { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string Mobile { get; set; }
        public string Email { get; set; }
        public Nullable<int> LevelId { get; set; }
        public Nullable<int> DocLevId { get; set; }
        public string Introduce { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> RegTypeId { get; set; }
        public string PicturePath { get; set; }
        public short LsStatus { get; set; }
        public short OrderBy { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public short IconIndex { get; set; }
        public Nullable<int> UserId { get; set; }
        public string PyCode { get; set; }
        public string WbCode { get; set; }
        public Nullable<int> SupDoctorId { get; set; }
        public Nullable<int> DiagRoomID { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }     
    }
}
