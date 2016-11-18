using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class vw_inhosinfoxx
    {
        public int id { get; set; }
        public int patid { get; set; }
        public string inpatno { get; set; }
        public string name { get; set; }
        public string sex { get; set; }
        public string Age { get; set; }
        public int ntime { get; set; }
        public System.DateTime intime { get; set; }
        public Nullable<System.DateTime> outtime { get; set; }
        public Nullable<int> docmz { get; set; }
        public Nullable<int> doctorid { get; set; }
        public Nullable<int> locationid { get; set; }
        public Nullable<int> bedid { get; set; }
        public short lsinstatus { get; set; }
        public System.DateTime opertime { get; set; }
        public int operid { get; set; }
        public Nullable<int> motherhospid { get; set; }
        public Nullable<int> mzregid { get; set; }
        public string company { get; set; }
        public string idcardno { get; set; }
        public string TipsNurse { get; set; }
        public string infoLinkmanName { get; set; }
        public Nullable<System.DateTime> birthdate { get; set; }
        public string Phone { get; set; }
        public string PhoneHome { get; set; }
        public string MedicareNo { get; set; }
        public string PatLinkmanName { get; set; }
        public int pattypeid { get; set; }
        public string pattypename { get; set; }
        public decimal arrearfei { get; set; }
        public decimal discdiag { get; set; }
        public decimal discin { get; set; }
        public string pattypef3 { get; set; }
        public string tallytypename { get; set; }
        public int tallygroupid { get; set; }
        public string tallygroupname { get; set; }
        public int locid { get; set; }
        public string locname { get; set; }
        public Nullable<int> areaid { get; set; }
        public string areaname { get; set; }
        public Nullable<int> areapolicestationid { get; set; }
        public string areapolicestationname { get; set; }
        public string areaCommitteename { get; set; }
    }
}
