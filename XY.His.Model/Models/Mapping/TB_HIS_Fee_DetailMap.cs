using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class TB_HIS_Fee_DetailMap : EntityTypeConfiguration<TB_HIS_Fee_Detail>
    {
        public TB_HIS_Fee_DetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.FeeDetailID, t.FeeRecordID, t.MedicalFeeTypeName, t.DetailedFeeType, t.RelatedMedicalAdviceID, t.DrugName, t.HospitalDrugCode, t.ServiceItemName, t.HospitalServiceItemCode, t.MedicalInsuranceCode, t.DetailItemUnit, t.DetailItemUnitPrice, t.DetailItemQuantity, t.DetailItemPrice, t.DetailedItemValueWithMeidcalInsuranceExcepted, t.DeductibleOfDetailedItemCoveredByMedicalInsurance });

            // Properties
            this.Property(t => t.MedicalInstitutionCode)
                .HasMaxLength(100);

            this.Property(t => t.MedicalInstitutionName)
                .HasMaxLength(100);

            this.Property(t => t.FeeDetailID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FeeRecordID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MedicalFeeTypeName)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.DetailedFeeType)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.RelatedMedicalAdviceID)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DrugName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HospitalDrugCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ServiceItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HospitalServiceItemCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.MedicalInsuranceCode)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DetailItemUnit)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DetailItemUnitPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DetailItemQuantity)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DetailItemPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DetailedItemValueWithMeidcalInsuranceExcepted)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DeductibleOfDetailedItemCoveredByMedicalInsurance)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("TB_HIS_Fee_Detail");
            this.Property(t => t.MedicalInstitutionCode).HasColumnName("MedicalInstitutionCode");
            this.Property(t => t.MedicalInstitutionName).HasColumnName("MedicalInstitutionName");
            this.Property(t => t.FeeDetailID).HasColumnName("FeeDetailID");
            this.Property(t => t.FeeRecordID).HasColumnName("FeeRecordID");
            this.Property(t => t.MedicalFeeTypeName).HasColumnName("MedicalFeeTypeName");
            this.Property(t => t.DetailedFeeType).HasColumnName("DetailedFeeType");
            this.Property(t => t.RelatedMedicalAdviceID).HasColumnName("RelatedMedicalAdviceID");
            this.Property(t => t.DrugName).HasColumnName("DrugName");
            this.Property(t => t.HospitalDrugCode).HasColumnName("HospitalDrugCode");
            this.Property(t => t.ServiceItemName).HasColumnName("ServiceItemName");
            this.Property(t => t.HospitalServiceItemCode).HasColumnName("HospitalServiceItemCode");
            this.Property(t => t.MedicalInsuranceCode).HasColumnName("MedicalInsuranceCode");
            this.Property(t => t.DetailItemUnit).HasColumnName("DetailItemUnit");
            this.Property(t => t.DetailItemUnitPrice).HasColumnName("DetailItemUnitPrice");
            this.Property(t => t.DetailItemQuantity).HasColumnName("DetailItemQuantity");
            this.Property(t => t.DetailItemPrice).HasColumnName("DetailItemPrice");
            this.Property(t => t.DeductibleFee).HasColumnName("DeductibleFee");
            this.Property(t => t.DetailedItemValueWithMeidcalInsuranceExcepted).HasColumnName("DetailedItemValueWithMeidcalInsuranceExcepted");
            this.Property(t => t.DeductibleOfDetailedItemCoveredByMedicalInsurance).HasColumnName("DeductibleOfDetailedItemCoveredByMedicalInsurance");
        }
    }
}
