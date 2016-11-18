using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsPatientYBIllMap : EntityTypeConfiguration<BsPatientYBIll>
    {
        public BsPatientYBIllMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.MedicareNo)
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsPatientYBIll");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatTyeId).HasColumnName("PatTyeId");
            this.Property(t => t.YbIllId).HasColumnName("YbIllId");
            this.Property(t => t.MedicareNo).HasColumnName("MedicareNo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.HospId).HasColumnName("HospId");

            // Relationships
            this.HasOptional(t => t.InHosInfo)
                .WithMany(t => t.BsPatientYBIlls)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.OuHosInfo)
                .WithMany(t => t.BsPatientYBIlls)
                .HasForeignKey(d => d.MzRegId);
            this.HasRequired(t => t.BsYbIllType)
                .WithMany(t => t.BsPatientYBIlls)
                .HasForeignKey(d => d.YbIllId);
            this.HasRequired(t => t.BsPatType)
                .WithMany(t => t.BsPatientYBIlls)
                .HasForeignKey(d => d.PatTyeId);

        }
    }
}
