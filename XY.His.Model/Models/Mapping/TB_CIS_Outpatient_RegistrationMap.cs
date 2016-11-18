using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class TB_CIS_Outpatient_RegistrationMap : EntityTypeConfiguration<TB_CIS_Outpatient_Registration>
    {
        public TB_CIS_Outpatient_RegistrationMap()
        {
            // Primary Key
            this.HasKey(t => new { t.RegistrationSign, t.RegistrationTime, t.VisitingSerialNumber, t.VisitingTypeCode, t.VisitingTypeName, t.FileNumber, t.HealthCardNumber, t.CardNumber, t.CardType, t.CardTypeName, t.ChinaIDNumber, t.IDNumber, t.IDType, t.IDTypeName, t.PaymentMethod, t.PaymentMethodName, t.Name, t.Gender, t.GenderName, t.STFBH, t.ZFZLF, t.ZLF, t.QTF });

            // Properties
            this.Property(t => t.MedicalInstitutionCode)
                .HasMaxLength(100);

            this.Property(t => t.MedicalInstitutionName)
                .HasMaxLength(100);

            this.Property(t => t.RegistrationSign)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.VisitingSerialNumber)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.VisitingTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VisitingTypeName)
                .IsRequired()
                .HasMaxLength(50);

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

            this.Property(t => t.VisitingDepartmentCode)
                .HasMaxLength(6);

            this.Property(t => t.VisitingDepartmentName)
                .HasMaxLength(30);

            this.Property(t => t.VisitingDoctorCode)
                .HasMaxLength(12);

            this.Property(t => t.VisitingDoctorName)
                .HasMaxLength(20);

            this.Property(t => t.STFBH)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ZFZLF)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ZLF)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.QTF)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TB_CIS_Outpatient_Registration");
            this.Property(t => t.MedicalInstitutionCode).HasColumnName("MedicalInstitutionCode");
            this.Property(t => t.MedicalInstitutionName).HasColumnName("MedicalInstitutionName");
            this.Property(t => t.RegistrationSign).HasColumnName("RegistrationSign");
            this.Property(t => t.RegistrationTime).HasColumnName("RegistrationTime");
            this.Property(t => t.VisitingSerialNumber).HasColumnName("VisitingSerialNumber");
            this.Property(t => t.VisitingTypeCode).HasColumnName("VisitingTypeCode");
            this.Property(t => t.VisitingTypeName).HasColumnName("VisitingTypeName");
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
            this.Property(t => t.VisitingDepartmentCode).HasColumnName("VisitingDepartmentCode");
            this.Property(t => t.VisitingDepartmentName).HasColumnName("VisitingDepartmentName");
            this.Property(t => t.VisitingDoctorCode).HasColumnName("VisitingDoctorCode");
            this.Property(t => t.VisitingDoctorName).HasColumnName("VisitingDoctorName");
            this.Property(t => t.STFBH).HasColumnName("STFBH");
            this.Property(t => t.ZFZLF).HasColumnName("ZFZLF");
            this.Property(t => t.ZLF).HasColumnName("ZLF");
            this.Property(t => t.QTF).HasColumnName("QTF");
        }
    }
}
