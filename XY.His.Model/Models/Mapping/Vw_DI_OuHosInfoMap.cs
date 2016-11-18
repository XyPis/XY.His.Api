using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_DI_OuHosInfoMap : EntityTypeConfiguration<Vw_DI_OuHosInfo>
    {
        public Vw_DI_OuHosInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.MzRegNo, t.HasDiag, t.HasRecipe, t.PatientName, t.CardNo, t.Sex, t.RegTime, t.GetTallyType, t.GetTallyTypeName, t.IsInPatient });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.MzRegNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.HasDiag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HasRecipe)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PatientName)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.CardNo)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.Sex)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.RegTypeName)
                .HasMaxLength(50);

            this.Property(t => t.LocationName)
                .HasMaxLength(30);

            this.Property(t => t.DoctorName)
                .HasMaxLength(40);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyTypeName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.GetTallyType)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.GetTallyTypeName)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Vw_DI_OuHosInfo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.HasDiag).HasColumnName("HasDiag");
            this.Property(t => t.HasRecipe).HasColumnName("HasRecipe");
            this.Property(t => t.PatientName).HasColumnName("PatientName");
            this.Property(t => t.CardNo).HasColumnName("CardNo");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.Age).HasColumnName("Age");
            this.Property(t => t.BabyMonth).HasColumnName("BabyMonth");
            this.Property(t => t.RegTime).HasColumnName("RegTime");
            this.Property(t => t.RegTypeName).HasColumnName("RegTypeName");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.IsCancel).HasColumnName("IsCancel");
            this.Property(t => t.DoctorName).HasColumnName("DoctorName");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.TallyTypeName).HasColumnName("TallyTypeName");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.IsGf).HasColumnName("IsGf");
            this.Property(t => t.IsYb).HasColumnName("IsYb");
            this.Property(t => t.GetTallyType).HasColumnName("GetTallyType");
            this.Property(t => t.GetTallyTypeName).HasColumnName("GetTallyTypeName");
            this.Property(t => t.ArrearAmount).HasColumnName("ArrearAmount");
            this.Property(t => t.IsInPatient).HasColumnName("IsInPatient");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.IsDiagnosed).HasColumnName("IsDiagnosed");
        }
    }
}
