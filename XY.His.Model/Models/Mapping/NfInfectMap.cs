using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class NfInfectMap : EntityTypeConfiguration<NfInfect>
    {
        public NfInfectMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NfInfect");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LsInfectType).HasColumnName("LsInfectType");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.LsEffect).HasColumnName("LsEffect");
            this.Property(t => t.LsCutType).HasColumnName("LsCutType");
            this.Property(t => t.InfectTime).HasColumnName("InfectTime");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.PositionId).HasColumnName("PositionId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.SpecialityId).HasColumnName("SpecialityId");
            this.Property(t => t.LsInfluence).HasColumnName("LsInfluence");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
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
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");

            // Relationships
            this.HasOptional(t => t.BsAnae)
                .WithMany(t => t.NfInfects)
                .HasForeignKey(d => d.AnaesId);
            this.HasOptional(t => t.BsDoctor)
                .WithMany(t => t.NfInfects)
                .HasForeignKey(d => d.DoctorId);
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.NfInfects)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.BsOP)
                .WithMany(t => t.NfInfects)
                .HasForeignKey(d => d.OPSId);
            this.HasRequired(t => t.BsPosition)
                .WithMany(t => t.NfInfects)
                .HasForeignKey(d => d.PositionId);
            this.HasRequired(t => t.BsSpeciality)
                .WithMany(t => t.NfInfects)
                .HasForeignKey(d => d.SpecialityId);
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.NfInfects)
                .HasForeignKey(d => d.OperID);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.NfInfects)
                .HasForeignKey(d => d.HospId);

        }
    }
}
