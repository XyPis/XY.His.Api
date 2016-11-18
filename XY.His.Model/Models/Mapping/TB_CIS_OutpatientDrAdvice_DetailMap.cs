using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class TB_CIS_OutpatientDrAdvice_DetailMap : EntityTypeConfiguration<TB_CIS_OutpatientDrAdvice_Detail>
    {
        public TB_CIS_OutpatientDrAdvice_DetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MedicalAdviceID, t.SortNumber, t.PrescriptionGroupNo, t.OrderNote, t.MeidcalAdviceTypeCode, t.MeidcalAdviceTypeName, t.ServiceItemName, t.HospitalServiceItemCode, t.ServiceItemCodeOfMedicalInsurance, t.ApplicationFormNo, t.DrugSign, t.DrugName, t.HospitalDrugCode, t.DrugCodeOfMedicalInsurance, t.DrugCodeOfFoodAndDrugAdministration, t.DrugCodeOfProvincialDrugPurchase, t.DrugType, t.DrugSpecification, t.DrugUseMeansCode, t.DrugUseMeansName, t.DrugUseDays, t.DrugUseFrequency, t.DrugUseFrequencyName, t.DrugFormCode, t.DrugFormName, t.SingleDose, t.DosageUnit, t.TotalDosage, t.TotalDosageUnit });

            // Properties
            this.Property(t => t.MedicalInstitutionCode)
                .HasMaxLength(100);

            this.Property(t => t.MedicalInstitutionName)
                .HasMaxLength(100);

            this.Property(t => t.MedicalAdviceID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PrescriptionID)
                .HasMaxLength(51);

            this.Property(t => t.SortNumber)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PrescriptionGroupNo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OrderNote)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.MeidcalAdviceTypeCode)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.MeidcalAdviceTypeName)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.ServiceItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HospitalServiceItemCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ServiceItemCodeOfPriceBureau)
                .HasMaxLength(100);

            this.Property(t => t.ServiceItemCodeOfMedicalInsurance)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.ApplicationFormNo)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DrugSign)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DrugName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HospitalDrugCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.DrugCodeOfMedicalInsurance)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DrugCodeOfFoodAndDrugAdministration)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DrugCodeOfProvincialDrugPurchase)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DrugType)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DrugSpecification)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.DrugUseMeansCode)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DrugUseMeansName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DrugUseDays)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DrugUseFrequency)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DrugUseFrequencyName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DrugFormCode)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DrugFormName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.SingleDose)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.DosageUnit)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.TotalDosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TotalDosageUnit)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("TB_CIS_OutpatientDrAdvice_Detail");
            this.Property(t => t.MedicalInstitutionCode).HasColumnName("MedicalInstitutionCode");
            this.Property(t => t.MedicalInstitutionName).HasColumnName("MedicalInstitutionName");
            this.Property(t => t.MedicalAdviceID).HasColumnName("MedicalAdviceID");
            this.Property(t => t.PrescriptionID).HasColumnName("PrescriptionID");
            this.Property(t => t.SortNumber).HasColumnName("SortNumber");
            this.Property(t => t.PrescriptionGroupNo).HasColumnName("PrescriptionGroupNo");
            this.Property(t => t.OrderNote).HasColumnName("OrderNote");
            this.Property(t => t.MeidcalAdviceTypeCode).HasColumnName("MeidcalAdviceTypeCode");
            this.Property(t => t.MeidcalAdviceTypeName).HasColumnName("MeidcalAdviceTypeName");
            this.Property(t => t.ServiceItemName).HasColumnName("ServiceItemName");
            this.Property(t => t.HospitalServiceItemCode).HasColumnName("HospitalServiceItemCode");
            this.Property(t => t.ServiceItemCodeOfPriceBureau).HasColumnName("ServiceItemCodeOfPriceBureau");
            this.Property(t => t.ServiceItemCodeOfMedicalInsurance).HasColumnName("ServiceItemCodeOfMedicalInsurance");
            this.Property(t => t.ApplicationFormNo).HasColumnName("ApplicationFormNo");
            this.Property(t => t.DrugSign).HasColumnName("DrugSign");
            this.Property(t => t.DrugName).HasColumnName("DrugName");
            this.Property(t => t.HospitalDrugCode).HasColumnName("HospitalDrugCode");
            this.Property(t => t.DrugCodeOfMedicalInsurance).HasColumnName("DrugCodeOfMedicalInsurance");
            this.Property(t => t.DrugCodeOfFoodAndDrugAdministration).HasColumnName("DrugCodeOfFoodAndDrugAdministration");
            this.Property(t => t.DrugCodeOfProvincialDrugPurchase).HasColumnName("DrugCodeOfProvincialDrugPurchase");
            this.Property(t => t.DrugType).HasColumnName("DrugType");
            this.Property(t => t.DrugSpecification).HasColumnName("DrugSpecification");
            this.Property(t => t.DrugUseMeansCode).HasColumnName("DrugUseMeansCode");
            this.Property(t => t.DrugUseMeansName).HasColumnName("DrugUseMeansName");
            this.Property(t => t.DrugUseDays).HasColumnName("DrugUseDays");
            this.Property(t => t.DrugUseFrequency).HasColumnName("DrugUseFrequency");
            this.Property(t => t.DrugUseFrequencyName).HasColumnName("DrugUseFrequencyName");
            this.Property(t => t.DrugFormCode).HasColumnName("DrugFormCode");
            this.Property(t => t.DrugFormName).HasColumnName("DrugFormName");
            this.Property(t => t.SingleDose).HasColumnName("SingleDose");
            this.Property(t => t.DosageUnit).HasColumnName("DosageUnit");
            this.Property(t => t.TotalDosage).HasColumnName("TotalDosage");
            this.Property(t => t.TotalDosageUnit).HasColumnName("TotalDosageUnit");
        }
    }
}
