using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsAnaeItemMap : EntityTypeConfiguration<BsAnaeItem>
    {
        public BsAnaeItemMap()
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
            this.ToTable("BsAnaeItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.AnaeId).HasColumnName("AnaeId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasRequired(t => t.BsAnae)
                .WithMany(t => t.BsAnaeItems)
                .HasForeignKey(d => d.AnaeId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.BsAnaeItems)
                .HasForeignKey(d => d.ItemId);

        }
    }
}
