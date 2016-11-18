using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElPatFormVDtlMap : EntityTypeConfiguration<ElPatFormVDtl>
    {
        public ElPatFormVDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ElValue)
                .HasMaxLength(3500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("ElPatFormVDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatFormId).HasColumnName("PatFormId");
            this.Property(t => t.PatFormValueId).HasColumnName("PatFormValueId");
            this.Property(t => t.ElId).HasColumnName("ElId");
            this.Property(t => t.BsDtlId).HasColumnName("BsDtlId");
            this.Property(t => t.ElValue).HasColumnName("ElValue");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.ElBaseDtl)
                .WithMany(t => t.ElPatFormVDtls)
                .HasForeignKey(d => d.BsDtlId);
            this.HasOptional(t => t.ElBaseFiled)
                .WithMany(t => t.ElPatFormVDtls)
                .HasForeignKey(d => d.ElId);

        }
    }
}
