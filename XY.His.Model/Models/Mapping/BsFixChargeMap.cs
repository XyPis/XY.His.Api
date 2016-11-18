using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsFixChargeMap : EntityTypeConfiguration<BsFixCharge>
    {
        public BsFixChargeMap()
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
            this.ToTable("BsFixCharge");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.BsFixCharges)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.BsFixCharges)
                .HasForeignKey(d => d.ItemId);
            this.HasOptional(t => t.BsPatType)
                .WithMany(t => t.BsFixCharges)
                .HasForeignKey(d => d.PatTypeId);

        }
    }
}
