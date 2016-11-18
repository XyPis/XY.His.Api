using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsPriceAddMap : EntityTypeConfiguration<BsPriceAdd>
    {
        public BsPriceAddMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.FeeIds)
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
            this.ToTable("BsPriceAdd");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PriceLow).HasColumnName("PriceLow");
            this.Property(t => t.PriceHigh).HasColumnName("PriceHigh");
            this.Property(t => t.AddPercent).HasColumnName("AddPercent");
            this.Property(t => t.AddPrice).HasColumnName("AddPrice");
            this.Property(t => t.FeeIds).HasColumnName("FeeIds");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
