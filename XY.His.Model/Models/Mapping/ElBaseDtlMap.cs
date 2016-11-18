using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class ElBaseDtlMap : EntityTypeConfiguration<ElBaseDtl>
    {
        public ElBaseDtlMap()
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

            // Table & Column Mappings
            this.ToTable("ElBaseDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ElId).HasColumnName("ElId");
            this.Property(t => t.ElId1).HasColumnName("ElId1");
            this.Property(t => t.IsReadOnly).HasColumnName("IsReadOnly");
            this.Property(t => t.IsAllowSort).HasColumnName("IsAllowSort");
            this.Property(t => t.Width).HasColumnName("Width");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
