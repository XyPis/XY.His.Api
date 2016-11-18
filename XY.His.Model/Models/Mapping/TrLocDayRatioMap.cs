using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class TrLocDayRatioMap : EntityTypeConfiguration<TrLocDayRatio>
    {
        public TrLocDayRatioMap()
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
            this.ToTable("TrLocDayRatio");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.RegDate).HasColumnName("RegDate");
            this.Property(t => t.MedicineRatio).HasColumnName("MedicineRatio");
            this.Property(t => t.AntiBiRatio).HasColumnName("AntiBiRatio");
            this.Property(t => t.Ratio1).HasColumnName("Ratio1");
            this.Property(t => t.Ratio2).HasColumnName("Ratio2");
            this.Property(t => t.Ratio3).HasColumnName("Ratio3");
            this.Property(t => t.Ratio4).HasColumnName("Ratio4");
            this.Property(t => t.Ratio5).HasColumnName("Ratio5");
            this.Property(t => t.Ratio6).HasColumnName("Ratio6");
            this.Property(t => t.Ratio7).HasColumnName("Ratio7");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
