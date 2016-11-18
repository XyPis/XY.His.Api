using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwNfInfectMap : EntityTypeConfiguration<VwNfInfect>
    {
        public VwNfInfectMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.LsInfectType, t.Code, t.HospId, t.LsEffect, t.LsCutType, t.InfectTime, t.PositionId, t.LocationId, t.SpecialityId });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsInfectType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InPatNo)
                .HasMaxLength(13);

            this.Property(t => t.Name)
                .HasMaxLength(30);

            this.Property(t => t.Sex)
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.Residence)
                .HasMaxLength(50);

            this.Property(t => t.LsEffect)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsCutType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PositionId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SpecialityId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IllDesc)
                .HasMaxLength(100);

            this.Property(t => t.LabNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwNfInfect");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LsInfectType).HasColumnName("LsInfectType");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.InPatNo).HasColumnName("InPatNo");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Sex).HasColumnName("Sex");
            this.Property(t => t.InTime).HasColumnName("InTime");
            this.Property(t => t.Residence).HasColumnName("Residence");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.LsInStatus).HasColumnName("LsInStatus");
            this.Property(t => t.LsEffect).HasColumnName("LsEffect");
            this.Property(t => t.LsCutType).HasColumnName("LsCutType");
            this.Property(t => t.InfectTime).HasColumnName("InfectTime");
            this.Property(t => t.PositionId).HasColumnName("PositionId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.SpecialityId).HasColumnName("SpecialityId");
            this.Property(t => t.LsInfluence).HasColumnName("LsInfluence");
            this.Property(t => t.OPSId).HasColumnName("OPSId");
            this.Property(t => t.OPSTime).HasColumnName("OPSTime");
            this.Property(t => t.LsClass).HasColumnName("LsClass");
            this.Property(t => t.LsASA).HasColumnName("LsASA");
            this.Property(t => t.IsEmergency).HasColumnName("IsEmergency");
            this.Property(t => t.AnaesId).HasColumnName("AnaesId");
            this.Property(t => t.Minutes).HasColumnName("Minutes");
            this.Property(t => t.IsImplant).HasColumnName("IsImplant");
            this.Property(t => t.IsImglass).HasColumnName("IsImglass");
            this.Property(t => t.IsOPSDrug).HasColumnName("IsOPSDrug");
            this.Property(t => t.IsUseDrug).HasColumnName("IsUseDrug");
            this.Property(t => t.LsInfectRange).HasColumnName("LsInfectRange");
            this.Property(t => t.LsUseType).HasColumnName("LsUseType");
            this.Property(t => t.LsUnionDrug).HasColumnName("LsUnionDrug");
            this.Property(t => t.LsUsePurpose).HasColumnName("LsUsePurpose");
            this.Property(t => t.BaseDrugId).HasColumnName("BaseDrugId");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.Days).HasColumnName("Days");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.InfReasonId).HasColumnName("InfReasonId");
            this.Property(t => t.IsRelated).HasColumnName("IsRelated");
            this.Property(t => t.LabNo).HasColumnName("LabNo");
            this.Property(t => t.SourceId).HasColumnName("SourceId");
            this.Property(t => t.BacteriaId).HasColumnName("BacteriaId");
            this.Property(t => t.BacteriaDrugId).HasColumnName("BacteriaDrugId");
            this.Property(t => t.LsResult).HasColumnName("LsResult");
        }
    }
}
