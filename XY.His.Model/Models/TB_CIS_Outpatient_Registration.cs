using System;
using System.Collections.Generic;

namespace XY.His.Model.Models
{
    public partial class TB_CIS_Outpatient_Registration
    {
        public string MedicalInstitutionCode { get; set; }
        public string MedicalInstitutionName { get; set; }
        public int RegistrationSign { get; set; }
        public System.DateTime RegistrationTime { get; set; }
        public string VisitingSerialNumber { get; set; }
        public string VisitingTypeCode { get; set; }
        public string VisitingTypeName { get; set; }
        public int FileNumber { get; set; }
        public string HealthCardNumber { get; set; }
        public string CardNumber { get; set; }
        public string CardType { get; set; }
        public string CardTypeName { get; set; }
        public string ChinaIDNumber { get; set; }
        public string IDNumber { get; set; }
        public string IDType { get; set; }
        public string IDTypeName { get; set; }
        public string PaymentMethod { get; set; }
        public string PaymentMethodName { get; set; }
        public string Name { get; set; }
        public string BirthDate { get; set; }
        public string Age { get; set; }
        public string Gender { get; set; }
        public string GenderName { get; set; }
        public string VisitingDepartmentCode { get; set; }
        public string VisitingDepartmentName { get; set; }
        public string VisitingDoctorCode { get; set; }
        public string VisitingDoctorName { get; set; }
        public string STFBH { get; set; }
        public int ZFZLF { get; set; }
        public int ZLF { get; set; }
        public int QTF { get; set; }
    }
}
