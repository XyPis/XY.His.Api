using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TmpOuEmr
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string GroupMain { get; set; }
        public string GroupSub { get; set; }
        public Nullable<short> OrderBy { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public string WbCode { get; set; }
        public string PyCode { get; set; }
        public Nullable<short> LsOpenType { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<int> LocationId { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string MainInform { get; set; }
        public string SickHist { get; set; }
        public Nullable<decimal> ExamT { get; set; }
        public Nullable<decimal> ExamP { get; set; }
        public Nullable<decimal> ExamR { get; set; }
        public Nullable<decimal> ExamBp { get; set; }
        public Nullable<decimal> ExamBp2 { get; set; }
        public string CheckUp { get; set; }
        public string CheckCT { get; set; }
        public string Disposal { get; set; }
        public string Impression { get; set; }
        public string Analys { get; set; }
        public string Others { get; set; }
        public string Tongue { get; set; }
        public string Pulse { get; set; }
        public string Moss { get; set; }
    }
}
