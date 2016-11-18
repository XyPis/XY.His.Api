using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsUsageItemMap : EntityTypeConfiguration<BsUsageItem>
    {
        public BsUsageItemMap()
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

            this.Property(t => t.Memo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BsUsageItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.LsUseArea).HasColumnName("LsUseArea");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.IsBaby).HasColumnName("IsBaby");
            this.Property(t => t.IsWomen).HasColumnName("IsWomen");
            this.Property(t => t.IsMen).HasColumnName("IsMen");
            this.Property(t => t.IsOlder).HasColumnName("IsOlder");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsDrugTwoDay).HasColumnName("IsDrugTwoDay");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.BsUsageItems)
                .HasForeignKey(d => d.ItemId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.BsUsageItems)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsUsage)
                .WithMany(t => t.BsUsageItems)
                .HasForeignKey(d => d.UsageId);

        }
    }
}
