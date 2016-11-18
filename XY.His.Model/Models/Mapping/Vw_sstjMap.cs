using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_sstjMap : EntityTypeConfiguration<Vw_sstj>
    {
        public Vw_sstjMap()
        {
            // Primary Key
            this.HasKey(t => new { t.科室, t.择期例数, t.急诊例数, t.门诊例数 });

            // Properties
            this.Property(t => t.科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.日期)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.择期例数)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.急诊例数)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.门诊例数)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Vw_sstj");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.择期例数).HasColumnName("择期例数");
            this.Property(t => t.急诊例数).HasColumnName("急诊例数");
            this.Property(t => t.门诊例数).HasColumnName("门诊例数");
        }
    }
}
