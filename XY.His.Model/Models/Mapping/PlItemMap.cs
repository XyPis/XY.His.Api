using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class PlItemMap : EntityTypeConfiguration<PlItem>
    {
        public PlItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.Memo)
                .HasMaxLength(3000);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("PlItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.GroupType).HasColumnName("GroupType");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.Hours).HasColumnName("Hours");
            this.Property(t => t.ParentID).HasColumnName("ParentID");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
