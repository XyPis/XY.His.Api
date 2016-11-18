using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InDayChargeMap : EntityTypeConfiguration<InDayCharge>
    {
        public InDayChargeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BeginTime)
                .IsRequired()
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
            this.ToTable("InDayCharge");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.BeginTime).HasColumnName("BeginTime");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.InDayCharges)
                .HasForeignKey(d => d.ItemId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.InDayCharges)
                .HasForeignKey(d => d.LocationId);
            this.HasOptional(t => t.BsPatType)
                .WithMany(t => t.InDayCharges)
                .HasForeignKey(d => d.PatTypeId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.InDayCharges)
                .HasForeignKey(d => d.UnitId);

        }
    }
}
