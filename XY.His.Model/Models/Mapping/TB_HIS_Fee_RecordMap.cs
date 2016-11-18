using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class TB_HIS_Fee_RecordMap : EntityTypeConfiguration<TB_HIS_Fee_Record>
    {
        public TB_HIS_Fee_RecordMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FeeRecordID, t.RefundSign, t.MedicalSettleModeCode, t.MedicalSettleModeName, t.MedicalSettleTime, t.InvoiceNumber, t.InvoiceDate, t.FileNumber, t.HealthCardNumber, t.CardNumber, t.CardType, t.CardTypeName, t.ChinaIDNumber, t.IDNumber, t.IDType, t.IDTypeName, t.PaymentMethod, t.PaymentMethodName, t.Name, t.Gender, t.GenderName, t.VisitingTypeCode, t.VisitingTypeName, t.VisitingSerialNumber, t.DeductibleFee, t.MedicalInsuranceCareBillingAmount, t.RuralCooperativeBillingAmount, t.OtherBillingAmount, t.RadiationTherapyFee });

            // Properties
            this.Property(t => t.MedicalInstitutionCode)
                .HasMaxLength(100);

            this.Property(t => t.MedicalInstitutionName)
                .HasMaxLength(100);

            this.Property(t => t.FeeRecordID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RefundSign)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MedicalSettleModeCode)
                .IsRequired();

            this.Property(t => t.MedicalSettleModeName)
                .IsRequired();

            this.Property(t => t.InvoiceNumber)
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
                .HasMaxLength(1);

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

            this.Property(t => t.VisitingTypeCode)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VisitingTypeName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.VisitingSerialNumber)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.DeductibleFee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MedicalInsuranceCareBillingAmount)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RuralCooperativeBillingAmount)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.OtherBillingAmount)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.RadiationTherapyFee)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TB_HIS_Fee_Record");
            this.Property(t => t.MedicalInstitutionCode).HasColumnName("MedicalInstitutionCode");
            this.Property(t => t.MedicalInstitutionName).HasColumnName("MedicalInstitutionName");
            this.Property(t => t.FeeRecordID).HasColumnName("FeeRecordID");
            this.Property(t => t.RefundSign).HasColumnName("RefundSign");
            this.Property(t => t.MedicalSettleModeCode).HasColumnName("MedicalSettleModeCode");
            this.Property(t => t.MedicalSettleModeName).HasColumnName("MedicalSettleModeName");
            this.Property(t => t.MedicalSettleTime).HasColumnName("MedicalSettleTime");
            this.Property(t => t.InvoiceNumber).HasColumnName("InvoiceNumber");
            this.Property(t => t.InvoiceDate).HasColumnName("InvoiceDate");
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
            this.Property(t => t.VisitingTypeCode).HasColumnName("VisitingTypeCode");
            this.Property(t => t.VisitingTypeName).HasColumnName("VisitingTypeName");
            this.Property(t => t.VisitingSerialNumber).HasColumnName("VisitingSerialNumber");
            this.Property(t => t.TotalInvoiceValue).HasColumnName("TotalInvoiceValue");
            this.Property(t => t.DeductibleFee).HasColumnName("DeductibleFee");
            this.Property(t => t.MedicalInsuranceCareBillingAmount).HasColumnName("MedicalInsuranceCareBillingAmount");
            this.Property(t => t.RuralCooperativeBillingAmount).HasColumnName("RuralCooperativeBillingAmount");
            this.Property(t => t.OtherBillingAmount).HasColumnName("OtherBillingAmount");
            this.Property(t => t.FeeOfWesternMedication).HasColumnName("FeeOfWesternMedication");
            this.Property(t => t.FeeOfChinesePatentMedicine).HasColumnName("FeeOfChinesePatentMedicine");
            this.Property(t => t.FeeOfChineseHerbalMedicine).HasColumnName("FeeOfChineseHerbalMedicine");
            this.Property(t => t.RegistratedFee).HasColumnName("RegistratedFee");
            this.Property(t => t.DiagnosticFee).HasColumnName("DiagnosticFee");
            this.Property(t => t.InspectionFee).HasColumnName("InspectionFee");
            this.Property(t => t.TreatmentFee).HasColumnName("TreatmentFee");
            this.Property(t => t.OperationFee).HasColumnName("OperationFee");
            this.Property(t => t.RadiationTherapyFee).HasColumnName("RadiationTherapyFee");
            this.Property(t => t.LaboratoryFee).HasColumnName("LaboratoryFee");
            this.Property(t => t.OtherFee).HasColumnName("OtherFee");
            this.Property(t => t.DetailCount).HasColumnName("DetailCount");
            this.Property(t => t.OperationMaterialFee).HasColumnName("OperationMaterialFee");
        }
    }
}
