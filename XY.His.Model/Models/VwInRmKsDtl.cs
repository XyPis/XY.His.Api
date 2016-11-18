using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInRmKsDtl
    {
        public int ID { get; set; }
        public int ItemId { get; set; }
        public decimal Totality { get; set; }
        public int UnitId { get; set; }
        public int HospId { get; set; }
        public string Name { get; set; }
        public decimal PriceIn { get; set; }
        public decimal Amount { get; set; }
        public int ExecLocId { get; set; }
        public int ExecOperId { get; set; }
        public Nullable<bool> IsPoison { get; set; }
        public Nullable<bool> IsMental { get; set; }
        public Nullable<bool> IsExpen { get; set; }
        public Nullable<short> LsImport { get; set; }
        public Nullable<bool> IsInject { get; set; }
        public Nullable<bool> IsSpecial { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperId { get; set; }
        public string LocationName { get; set; }
        public string InPatNo { get; set; }
        public string Spec { get; set; }
        public string BsUserName { get; set; }
        public int BsUserID { get; set; }
        public string PatientName { get; set; }
        public Nullable<System.DateTime> SignTime { get; set; }
        public int RoomId { get; set; }
    }
}
