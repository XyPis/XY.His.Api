using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InDaySumMap : EntityTypeConfiguration<InDaySum>
    {
        public InDaySumMap()
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
            this.ToTable("InDaySum");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.RegDate).HasColumnName("RegDate");
            this.Property(t => t.NotPay).HasColumnName("NotPay");
            this.Property(t => t.HasPay).HasColumnName("HasPay");
            this.Property(t => t.DaySum).HasColumnName("DaySum");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Remain).HasColumnName("Remain");

            // Relationships
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InDaySums)
                .HasForeignKey(d => d.HospId);

        }
    }
}
