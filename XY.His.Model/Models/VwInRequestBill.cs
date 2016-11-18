using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInRequestBill
    {
        public int RequestID { get; set; }
        public int ListNum { get; set; }
        public Nullable<System.DateTime> fordate { get; set; }
        public int LocationID { get; set; }
        public string LocationName { get; set; }
        public int HospID { get; set; }
        public string HospNO { get; set; }
        public string BedName { get; set; }
        public string PatName { get; set; }
        public short LsMarkType { get; set; }
        public Nullable<int> DoctorID { get; set; }
        public string DoctorName { get; set; }
        public short GroupNum { get; set; }
        public int AdviceID { get; set; }
        public int ItemID { get; set; }
        public string ItemName { get; set; }
        public string Spec { get; set; }
        public decimal Totality { get; set; }
        public int UnitReq { get; set; }
        public string UnitName { get; set; }
        public bool IsIssued { get; set; }
        public int RoomID { get; set; }
        public string RoomName { get; set; }
        public short LsExecLoc { get; set; }
        public Nullable<decimal> BackedNum { get; set; }
        public Nullable<decimal> BackNum { get; set; }
        public Nullable<bool> BackSeq { get; set; }
        public Nullable<bool> IsBack { get; set; }
    }
}
