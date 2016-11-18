using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class RdBrainDead
    {
        public int ID { get; set; }
        public int PatId { get; set; }
        public System.DateTime OperTime { get; set; }
        public int OperID { get; set; }
        public string Code { get; set; }
        public Nullable<int> ICDId { get; set; }
        public Nullable<short> LsCardType { get; set; }
        public Nullable<short> LsCensus { get; set; }
        public Nullable<int> IllId { get; set; }
        public Nullable<System.DateTime> DiagDate { get; set; }
        public Nullable<short> LsIllBase { get; set; }
        public string LsIllType { get; set; }
        public Nullable<System.DateTime> IllDate { get; set; }
        public Nullable<short> LsLastTime { get; set; }
        public Nullable<int> IllTimes { get; set; }
        public Nullable<System.DateTime> DeadDate { get; set; }
        public string ImmediacyDead { get; set; }
        public string ElseIllness { get; set; }
        public string FormerlyIllness { get; set; }
        public Nullable<System.DateTime> YDiagDate { get; set; }
        public string DeadCause { get; set; }
        public Nullable<int> LocId { get; set; }
        public Nullable<int> DeadICD { get; set; }
        public Nullable<int> ElseIllnessICD { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> ReciOperId { get; set; }
        public string ReportUnit { get; set; }
        public Nullable<System.DateTime> ReportDate { get; set; }
        public virtual BsPatient BsPatient { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
    }
}
