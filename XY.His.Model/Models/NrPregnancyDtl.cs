using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class NrPregnancyDtl
    {
        public int ID { get; set; }
        public Nullable<int> PregnancyId { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public Nullable<decimal> ExamBp { get; set; }
        public Nullable<decimal> ExamBp2 { get; set; }
        public string Strength { get; set; }
        public string LongTimes { get; set; }
        public string Sometimes { get; set; }
        public string UterusHigh { get; set; }
        public string Post { get; set; }
        public string Speed { get; set; }
        public string Place { get; set; }
        public string FirstHigh { get; set; }
        public string Lengh { get; set; }
        public string Expand { get; set; }
        public string Membrane { get; set; }
        public string Anus { get; set; }
        public string Vagina { get; set; }
        public string Others { get; set; }
        public string CheckMan { get; set; }
        public string CenterTimes { get; set; }
        public string LinkUp { get; set; }
        public string Score { get; set; }
        public string AmniFluid { get; set; }
        public string VaginaBleed { get; set; }
        public string MoveTimes { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public virtual NrPregnancy NrPregnancy { get; set; }
    }
}
