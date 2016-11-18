using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsLimitDocLevMap : EntityTypeConfiguration<BsLimitDocLev>
    {
        public BsLimitDocLevMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.LsLimitType)
                .IsFixedLength()
                .HasMaxLength(1);

            // Table & Column Mappings
            this.ToTable("BsLimitDocLev");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LimitGroupId).HasColumnName("LimitGroupId");
            this.Property(t => t.DocLevId).HasColumnName("DocLevId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.TypeGFXEId).HasColumnName("TypeGFXEId");
            this.Property(t => t.LimitFeeMz).HasColumnName("LimitFeeMz");
            this.Property(t => t.LimitFeeZy).HasColumnName("LimitFeeZy");
            this.Property(t => t.LsLimitType).HasColumnName("LsLimitType");
            this.Property(t => t.IsActive).HasColumnName("IsActive");

            // Relationships
            this.HasOptional(t => t.BsDocLevel)
                .WithMany(t => t.BsLimitDocLevs)
                .HasForeignKey(d => d.DocLevId);
            this.HasOptional(t => t.BsGfxe)
                .WithMany(t => t.BsLimitDocLevs)
                .HasForeignKey(d => d.TypeGFXEId);
            this.HasRequired(t => t.BsLimitGroup)
                .WithMany(t => t.BsLimitDocLevs)
                .HasForeignKey(d => d.LimitGroupId);

        }
    }
}
