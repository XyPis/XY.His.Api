using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.Gbl.Mapping
{
    public class GblSystemMenuMap : EntityTypeConfiguration<GblSystemMenu>
    {
        public GblSystemMenuMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Hint)
                .HasMaxLength(100);

            this.Property(t => t.Shortcut)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GblSystemMenu");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.SystemId).HasColumnName("SystemId");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.Hint).HasColumnName("Hint");
            this.Property(t => t.Shortcut).HasColumnName("Shortcut");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsMostUsed).HasColumnName("IsMostUsed");
            this.Property(t => t.IsBeginGroup).HasColumnName("IsBeginGroup");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
        }
    }
}
