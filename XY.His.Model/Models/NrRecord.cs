using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class NrRecord
    {
        public int ID { get; set; }
        public string Type { get; set; }
        public Nullable<int> MzRegId { get; set; }
        public Nullable<int> HospId { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<decimal> ExamT { get; set; }
        public Nullable<decimal> ExamP { get; set; }
        public Nullable<decimal> ExamR { get; set; }
        public Nullable<decimal> ExamBp { get; set; }
        public Nullable<decimal> ExamBp2 { get; set; }
        public Nullable<decimal> Hight { get; set; }
        public string Mentality { get; set; }
        public string InItem1 { get; set; }
        public Nullable<decimal> InVolumn1 { get; set; }
        public string InItem2 { get; set; }
        public Nullable<decimal> InVolumn2 { get; set; }
        public Nullable<decimal> InVolumnAll { get; set; }
        public string OutItem1 { get; set; }
        public Nullable<decimal> OutVolumn1 { get; set; }
        public string OutItem2 { get; set; }
        public Nullable<decimal> OutVolumn2 { get; set; }
        public Nullable<decimal> OutVolumnAll { get; set; }
        public Nullable<bool> UrineFree { get; set; }
        public string UrineProper { get; set; }
        public string UrineColor { get; set; }
        public Nullable<decimal> OutOther { get; set; }
        public string SpecialMemo { get; set; }
        public string Breast { get; set; }
        public string Milk { get; set; }
        public string UterusHigh { get; set; }
        public string UterusShrink { get; set; }
        public string Wound { get; set; }
        public string Hand { get; set; }
        public string Foot { get; set; }
        public string Buttocks { get; set; }
        public string Mouth { get; set; }
        public string Face { get; set; }
        public string Breath { get; set; }
        public string Blood { get; set; }
        public string BoxTemp { get; set; }
        public string SPO2 { get; set; }
        public string PupilL { get; set; }
        public string PupilR { get; set; }
        public string PupilBright { get; set; }
        public string OxygenBr { get; set; }
        public string OxygenF { get; set; }
        public string OxygenFiO2 { get; set; }
        public string OxygenPipeDeep { get; set; }
        public string OxygenCpap { get; set; }
        public string OxygenPipeNose { get; set; }
        public string OxygenVein { get; set; }
        public string LiePose { get; set; }
        public string Skin { get; set; }
        public string Others { get; set; }
        public string Disposal { get; set; }
        public Nullable<int> OperId { get; set; }
        public Nullable<System.DateTime> OperTime { get; set; }
        public string F1 { get; set; }
        public string F2 { get; set; }
        public string F3 { get; set; }
        public string F4 { get; set; }
        public string PupilLReflex { get; set; }
        public string PupilRReflex { get; set; }
        public string ResultMMO { get; set; }
        public string ChannelName { get; set; }
        public string ChannelSituation { get; set; }
        public string Condition { get; set; }
        public string Puncture { get; set; }
        public string Joint { get; set; }
        public string DropIn { get; set; }
        public string Vein { get; set; }
        public string DrugExudation { get; set; }
        public string TumorExudation { get; set; }
        public string Plaster { get; set; }
        public string HDilution { get; set; }
        public string PSaline { get; set; }
        public string OperName { get; set; }
        public virtual BsLocation BsLocation { get; set; }
        public virtual InHosInfo InHosInfo { get; set; }
        public virtual OuHosInfo OuHosInfo { get; set; }
    }
}
