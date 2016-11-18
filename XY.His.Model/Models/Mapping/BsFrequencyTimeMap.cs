using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsFrequencyTimeMap : EntityTypeConfiguration<BsFrequencyTime>
    {
        public BsFrequencyTimeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ExecTime)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsFrequencyTime");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.ExecTime).HasColumnName("ExecTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasRequired(t => t.BsFrequency)
                .WithMany(t => t.BsFrequencyTimes)
                .HasForeignKey(d => d.FrequencyId);

        }
    }
}
