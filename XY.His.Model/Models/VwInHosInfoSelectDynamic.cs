using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class VwInHosInfoSelectDynamic
    {
        public int ID { get; set; }
        public int PatTypeId { get; set; }
        public Nullable<int> DoctorId { get; set; }
        public int PatID { get; set; }
        public Nullable<int> LocationId { get; set; }
        public Nullable<int> BedId { get; set; }
        public string PatientName { get; set; }
        public string DoctorName { get; set; }
        public string PatTypeName { get; set; }
        public string BedName { get; set; }
        public string LocationName { get; set; }
        public string HospNo { get; set; }
        public int NTime { get; set; }
        public System.DateTime InTime { get; set; }
        public Nullable<System.DateTime> OutTime { get; set; }
        public Nullable<bool> FirtDay { get; set; }
        public string Sex { get; set; }
        public short LsInStatus { get; set; }
        public string CardNo { get; set; }
        public string InPatNo { get; set; }
        public Nullable<bool> BedIsAdd { get; set; }
        public Nullable<int> BedOrderBy { get; set; }
        public Nullable<int> TallyTypeId { get; set; }
        public string TallyTypeName { get; set; }
        public Nullable<int> TallyGroupId { get; set; }
        public string TallyGroupName { get; set; }
        public System.DateTime BirthDate { get; set; }
        public string GetTallyType { get; set; }
        public Nullable<bool> IsGf { get; set; }
        public Nullable<bool> IsYb { get; set; }
        public string GetTallyTypeName { get; set; }
        public int Age { get; set; }
        public string Native { get; set; }
        public string Residence { get; set; }
        public string Company { get; set; }
        public string Occupation { get; set; }
        public string Mobile { get; set; }
        public string Phone { get; set; }
        public string Sensitive { get; set; }
        public string IdCardNo { get; set; }
        public string MedicareNo { get; set; }
        public string LinkmanName { get; set; }
        public Nullable<decimal> ArrearAmount { get; set; }
        public string AgeString { get; set; }
        public Nullable<int> MotherHospId { get; set; }
        public string WorkTypeName { get; set; }
        public string MarriageName { get; set; }
        public string NationName { get; set; }
    }
}
