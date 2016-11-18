using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.BS.Mapping
{
    public class BsItemNameMultiMap : EntityTypeConfiguration<BsItemNameMulti>
    {
        public BsItemNameMultiMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.NameMulti)
                .HasMaxLength(1000);

            this.Property(t => t.WbMulti)
                .HasMaxLength(1000);

            this.Property(t => t.PyMulti)
                .HasMaxLength(1000);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsItemNameMulti");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.NameMulti).HasColumnName("NameMulti");
            this.Property(t => t.WbMulti).HasColumnName("WbMulti");
            this.Property(t => t.PyMulti).HasColumnName("PyMulti");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
        }
    }
}
