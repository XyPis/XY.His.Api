using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class TB_CIS_Outpatient_PrescriptionMap : EntityTypeConfiguration<TB_CIS_Outpatient_Prescription>
    {
        public TB_CIS_Outpatient_PrescriptionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.PrescriptionID, t.PrescriptionProperty, t.VisitingTypeCode, t.VisitingTypeName, t.VisitingSerialNumber, t.FileNumber, t.HealthCardNumber, t.CardNumber, t.CardType, t.CardTypeName, t.ChinaIDNumber, t.IDNumber, t.IDType, t.IDTypeName, t.PaymentMethod, t.PaymentMethodName, t.Name, t.Gender, t.GenderName, t.DiseaseDiagnosisCode, t.DiagnosisCode, t.DiseaseDiagnosisDescription, t.OrderCreateTime, t.PrescriptionNote, t.PrescriptionDays, t.TCMTypeCode, t.TCMSign, t.TCMPrescriptionDetail, t.TCMCount, t.TCMDecoctionMethod, t.TCMRouteCode, t.InvoiceNumber });

            // Properties
            this.Property(t => t.MedicalInstitutionCode)
                .HasMaxLength(100);

            this.Property(t => t.MedicalInstitutionName)
                .HasMaxLength(100);

            this.Property(t => t.PrescriptionID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PrescriptionNumber)
                .HasMaxLength(51);

            this.Property(t => t.PrescriptionProperty)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VisitingTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VisitingTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VisitingSerialNumber)
                .IsRequired()
                .HasMaxLength(12);

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

            this.Property(t => t.DiseaseDiagnosisCode)
                .IsRequired();

            this.Property(t => t.DiagnosisCode)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiseaseDiagnosisDescription)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.OrderCreateDepartmentCode)
                .HasMaxLength(6);

            this.Property(t => t.OrderCreateDepartment)
                .HasMaxLength(30);

            this.Property(t => t.OrderCreatorCode)
                .HasMaxLength(12);

            this.Property(t => t.OrderCreator)
                .HasMaxLength(20);

            this.Property(t => t.PrescriptionNote)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.PrescriptionDays)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TCMTypeCode)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.TCMSign)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.TCMPrescriptionDetail)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.TCMCount)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.TCMDecoctionMethod)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.TCMRouteCode)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.InvoiceNumber)
                .IsRequired()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("TB_CIS_Outpatient_Prescription");
            this.Property(t => t.MedicalInstitutionCode).HasColumnName("MedicalInstitutionCode");
            this.Property(t => t.MedicalInstitutionName).HasColumnName("MedicalInstitutionName");
            this.Property(t => t.PrescriptionID).HasColumnName("PrescriptionID");
            this.Property(t => t.PrescriptionNumber).HasColumnName("PrescriptionNumber");
            this.Property(t => t.PrescriptionProperty).HasColumnName("PrescriptionProperty");
            this.Property(t => t.VisitingTypeCode).HasColumnName("VisitingTypeCode");
            this.Property(t => t.VisitingTypeName).HasColumnName("VisitingTypeName");
            this.Property(t => t.VisitingSerialNumber).HasColumnName("VisitingSerialNumber");
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
            this.Property(t => t.NameOfDiseaseDiagnosis).HasColumnName("NameOfDiseaseDiagnosis");
            this.Property(t => t.DiseaseDiagnosisCode).HasColumnName("DiseaseDiagnosisCode");
            this.Property(t => t.DiagnosisCode).HasColumnName("DiagnosisCode");
            this.Property(t => t.DiseaseDiagnosisDescription).HasColumnName("DiseaseDiagnosisDescription");
            this.Property(t => t.OrderCreateDepartmentCode).HasColumnName("OrderCreateDepartmentCode");
            this.Property(t => t.OrderCreateDepartment).HasColumnName("OrderCreateDepartment");
            this.Property(t => t.OrderCreatorCode).HasColumnName("OrderCreatorCode");
            this.Property(t => t.OrderCreator).HasColumnName("OrderCreator");
            this.Property(t => t.OrderCreateTime).HasColumnName("OrderCreateTime");
            this.Property(t => t.PrescriptionNote).HasColumnName("PrescriptionNote");
            this.Property(t => t.PrescriptionDays).HasColumnName("PrescriptionDays");
            this.Property(t => t.TCMTypeCode).HasColumnName("TCMTypeCode");
            this.Property(t => t.TCMSign).HasColumnName("TCMSign");
            this.Property(t => t.TCMPrescriptionDetail).HasColumnName("TCMPrescriptionDetail");
            this.Property(t => t.TCMCount).HasColumnName("TCMCount");
            this.Property(t => t.TCMDecoctionMethod).HasColumnName("TCMDecoctionMethod");
            this.Property(t => t.TCMRouteCode).HasColumnName("TCMRouteCode");
            this.Property(t => t.InvoiceNumber).HasColumnName("InvoiceNumber");
            this.Property(t => t.PrescriptionMoney).HasColumnName("PrescriptionMoney");
            this.Property(t => t.DetailCount).HasColumnName("DetailCount");
        }
    }
}
