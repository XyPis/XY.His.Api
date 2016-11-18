using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwNfinfect_mianMap : EntityTypeConfiguration<VwNfinfect_mian>
    {
        public VwNfinfect_mianMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.HospId, t.Code, t.InfectTime, t.OperTime, t.OperID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HospId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsInfectTypeName)
                .HasMaxLength(10);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.LsEffectName)
                .HasMaxLength(4);

            this.Property(t => t.LsCutTypeName)
                .HasMaxLength(6);

            this.Property(t => t.Position)
                .HasMaxLength(50);

            this.Property(t => t.Location)
                .HasMaxLength(30);

            this.Property(t => t.Speciality)
                .HasMaxLength(50);

            this.Property(t => t.LsInfluenceName)
                .HasMaxLength(8);

            this.Property(t => t.BsOPSName)
                .HasMaxLength(50);

            this.Property(t => t.LsClassName)
                .HasMaxLength(9);

            this.Property(t => t.LsASAName)
                .HasMaxLength(5);

            this.Property(t => t.AnaesName)
                .HasMaxLength(50);

            this.Property(t => t.LsInfectRangeName)
                .HasMaxLength(8);

            this.Property(t => t.LsUseTypeName)
                .HasMaxLength(4);

            this.Property(t => t.LsUnionDrugName)
                .HasMaxLength(14);

            this.Property(t => t.LsUsePurposeName)
                .HasMaxLength(9);

            this.Property(t => t.PositionSystem)
                .HasMaxLength(50);

            this.Property(t => t.OperID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OpDoctor)
                .HasMaxLength(40);

            // Table & Column Mappings
            this.ToTable("VwNfinfect_mian");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LsInfectTypeName).HasColumnName("LsInfectTypeName");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.LsEffectName).HasColumnName("LsEffectName");
            this.Property(t => t.LsCutTypeName).HasColumnName("LsCutTypeName");
            this.Property(t => t.InfectTime).HasColumnName("InfectTime");
            this.Property(t => t.Position).HasColumnName("Position");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Speciality).HasColumnName("Speciality");
            this.Property(t => t.LsInfluenceName).HasColumnName("LsInfluenceName");
            this.Property(t => t.OPSId).HasColumnName("OPSId");
            this.Property(t => t.BsOPSName).HasColumnName("BsOPSName");
            this.Property(t => t.OPSTime).HasColumnName("OPSTime");
            this.Property(t => t.LsClassName).HasColumnName("LsClassName");
            this.Property(t => t.LsASAName).HasColumnName("LsASAName");
            this.Property(t => t.IsEmergency).HasColumnName("IsEmergency");
            this.Property(t => t.AnaesId).HasColumnName("AnaesId");
            this.Property(t => t.AnaesName).HasColumnName("AnaesName");
            this.Property(t => t.Minutes).HasColumnName("Minutes");
            this.Property(t => t.IsImplant).HasColumnName("IsImplant");
            this.Property(t => t.IsImglass).HasColumnName("IsImglass");
            this.Property(t => t.IsOPSDrug).HasColumnName("IsOPSDrug");
            this.Property(t => t.IsUseDrug).HasColumnName("IsUseDrug");
            this.Property(t => t.LsInfectRangeName).HasColumnName("LsInfectRangeName");
            this.Property(t => t.LsUseTypeName).HasColumnName("LsUseTypeName");
            this.Property(t => t.LsUnionDrugName).HasColumnName("LsUnionDrugName");
            this.Property(t => t.LsUsePurposeName).HasColumnName("LsUsePurposeName");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.PositionSystem).HasColumnName("PositionSystem");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.OpDoctor).HasColumnName("OpDoctor");
        }
    }
}
