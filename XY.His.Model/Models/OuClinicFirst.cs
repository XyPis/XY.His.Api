using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class OuClinicFirst
    {
        public int ID { get; set; }
        public int MzRegId { get; set; }
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
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string Impression { get; set; }
        public string Analys { get; set; }
        public string Others { get; set; }
        public string Tongue { get; set; }
        public string Pulse { get; set; }
        public string Moss { get; set; }
        public byte[] XMLEMR { get; set; }
        public byte[] XMLCancer { get; set; }
        public byte[] XMLSex { get; set; }
        public byte[] XMLTuberculosis { get; set; }
        public byte[] XMLContagion { get; set; }
        public Nullable<decimal> ExamSugar { get; set; }
        public Nullable<System.DateTime> FirstDate { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
    }
}
