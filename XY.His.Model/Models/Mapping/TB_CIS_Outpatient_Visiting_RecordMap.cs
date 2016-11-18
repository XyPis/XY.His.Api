using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class TB_CIS_Outpatient_Visiting_RecordMap : EntityTypeConfiguration<TB_CIS_Outpatient_Visiting_Record>
    {
        public TB_CIS_Outpatient_Visiting_RecordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.VisitingSerialNumber, t.VisitingTypeCode, t.VisitingTypeName, t.OutpatientSerialNumber, t.FileNumber, t.HealthCardNumber, t.CardNumber, t.CardType, t.CardTypeName, t.ChinaIDNumber, t.IDNumber, t.IDType, t.IDTypeName, t.PaymentMethod, t.PaymentMethodName, t.Name, t.Gender, t.GenderName, t.VisitingSign, t.ReferralSign, t.VisitingDate, t.ChiefComplaint, t.PrsentHistory, t.PastHistory, t.DrugAllergy, t.PhysicalSign, t.OutpatientSymptomName, t.OutpatientSymptomDiagnosticCode, t.DateOfOnset, t.SymptomDuration, t.DiseaseDiagnosisCode, t.DiagnosisCode, t.Description, t.DiagnosisDate, t.TreatmentProcess, t.ConsultProblem, t.HealthServiceDemand, t.HealthProblemAccess, t.HandlePlan, t.ChineseMedicineUtilizationCategoryCode });

            // Properties
            this.Property(t => t.MedicalInstitutionCode)
                .HasMaxLength(100);

            this.Property(t => t.MedicalInstitutionName)
                .HasMaxLength(100);

            this.Property(t => t.VisitingSerialNumber)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.VisitingTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VisitingTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OutpatientSerialNumber)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.FileNumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HealthCardNumber)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.CardNumber)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.CardType)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.CardTypeName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ChinaIDNumber)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IDNumber)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.IDType)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.IDTypeName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PaymentMethod)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.PaymentMethodName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.BirthDate)
                .IsFixedLength()
                .HasMaxLength(8);

            this.Property(t => t.Age)
                .HasMaxLength(50);

            this.Property(t => t.Gender)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.GenderName)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.VisitingSign)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ReferralSign)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VisitingDepartmentCode)
                .HasMaxLength(6);

            this.Property(t => t.VisitingDepartmentName)
                .HasMaxLength(30);

            this.Property(t => t.ChiefComplaint)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PrsentHistory)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PastHistory)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DrugAllergy)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PhysicalSign)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.OutpatientSymptomName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.OutpatientSymptomDiagnosticCode)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DateOfOnset)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.SymptomDuration)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DiseaseDiagnosisCode)
                .IsRequired();

            this.Property(t => t.DiagnosisCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Description)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DiagnosticianCode)
                .HasMaxLength(12);

            this.Property(t => t.NameOfDiagnostician)
                .HasMaxLength(20);

            this.Property(t => t.TreatmentProcess)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ConsultProblem)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.HealthServiceDemand)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.HealthProblemAccess)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.HandlePlan)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ChineseMedicineUtilizationCategoryCode)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("TB_CIS_Outpatient_Visiting_Record");
            this.Property(t => t.MedicalInstitutionCode).HasColumnName("MedicalInstitutionCode");
            this.Property(t => t.MedicalInstitutionName).HasColumnName("MedicalInstitutionName");
            this.Property(t => t.VisitingSerialNumber).HasColumnName("VisitingSerialNumber");
            this.Property(t => t.VisitingTypeCode).HasColumnName("VisitingTypeCode");
            this.Property(t => t.VisitingTypeName).HasColumnName("VisitingTypeName");
            this.Property(t => t.OutpatientSerialNumber).HasColumnName("OutpatientSerialNumber");
            this.Property(t => t.FileNumber).HasColumnName("FileNumber");
            this.Property(t => t.HealthCardNumber).HasColumnName("HealthCardNumber");
            this.Property(t => t.CardNumber).HasColumnName("CardNumber");
            this.Property(t => t.CardType).HasColumnName("CardType");
            this.Property(t => t.CardTypeName).HasColumnName("CardTypeName");
            this.Property(t => t.ChinaIDNumber).HasColumnName("ChinaIDNumber");
            this.Property(t => t.IDNumber).HasColumnName("IDNumber");
            this.Property(t => t.IDType).HasColumnName("IDType");
            this.Property(t => t.IDTypeName).HasColumnName("IDTypeName");
            this.Property(t => t.PaymentMethod).HasColumnName("PaymentMethod");
            this.Property(t => t.PaymentMethodName).HasColumnName("PaymentMethodName");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.BirthDate).HasColumnName("BirthDate");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.Gender).HasColumnName("Gender");
            this.Property(t => t.GenderName).HasColumnName("GenderName");
            this.Property(t => t.VisitingSign).HasColumnName("VisitingSign");
            this.Property(t => t.ReferralSign).HasColumnName("ReferralSign");
            this.Property(t => t.VisitingDepartmentCode).HasColumnName("VisitingDepartmentCode");
            this.Property(t => t.VisitingDepartmentName).HasColumnName("VisitingDepartmentName");
            this.Property(t => t.VisitingDate).HasColumnName("VisitingDate");
            this.Property(t => t.ChiefComplaint).HasColumnName("ChiefComplaint");
            this.Property(t => t.PrsentHistory).HasColumnName("PrsentHistory");
            this.Property(t => t.PastHistory).HasColumnName("PastHistory");
            this.Property(t => t.DrugAllergy).HasColumnName("DrugAllergy");
            this.Property(t => t.PhysicalSign).HasColumnName("PhysicalSign");
            this.Property(t => t.OutpatientSymptomName).HasColumnName("OutpatientSymptomName");
            this.Property(t => t.OutpatientSymptomDiagnosticCode).HasColumnName("OutpatientSymptomDiagnosticCode");
            this.Property(t => t.DateOfOnset).HasColumnName("DateOfOnset");
            this.Property(t => t.SymptomDuration).HasColumnName("SymptomDuration");
            this.Property(t => t.NameOfDiseaseDiagnosis).HasColumnName("NameOfDiseaseDiagnosis");
            this.Property(t => t.DiseaseDiagnosisCode).HasColumnName("DiseaseDiagnosisCode");
            this.Property(t => t.DiagnosisCode).HasColumnName("DiagnosisCode");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.DiagnosticianCode).HasColumnName("DiagnosticianCode");
            this.Property(t => t.NameOfDiagnostician).HasColumnName("NameOfDiagnostician");
            this.Property(t => t.DiagnosisDate).HasColumnName("DiagnosisDate");
            this.Property(t => t.TreatmentProcess).HasColumnName("TreatmentProcess");
            this.Property(t => t.ConsultProblem).HasColumnName("ConsultProblem");
            this.Property(t => t.HealthServiceDemand).HasColumnName("HealthServiceDemand");
            this.Property(t => t.HealthProblemAccess).HasColumnName("HealthProblemAccess");
            this.Property(t => t.HandlePlan).HasColumnName("HandlePlan");
            this.Property(t => t.ChineseMedicineUtilizationCategoryCode).HasColumnName("ChineseMedicineUtilizationCategoryCode");
        }
    }
}
