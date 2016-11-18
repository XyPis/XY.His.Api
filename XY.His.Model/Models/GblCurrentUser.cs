using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class GblCurrentUser
    {
        public int ID { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<int> HouseId { get; set; }
        public Nullable<int> RoomId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public string Hostname { get; set; }
        public Nullable<int> SpecialityId { get; set; }
        public Nullable<System.DateTime> BeginTime { get; set; }
        public Nullable<System.DateTime> EndTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual BsUser BsUser { get; set; }
    }
}
