using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_yfmzgzlMap : EntityTypeConfiguration<Vw_yfmzgzl>
    {
        public Vw_yfmzgzlMap()
        {
            // Primary Key
            this.HasKey(t => new { t.药房名称, t.处方号 });

            // Properties
            this.Property(t => t.药房名称)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.科室)
                .HasMaxLength(30);

            this.Property(t => t.医生)
                .HasMaxLength(40);

            this.Property(t => t.处方号)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.日期)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Vw_yfmzgzl");
            this.Property(t => t.药房名称).HasColumnName("药房名称");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.医生).HasColumnName("医生");
            this.Property(t => t.处方号).HasColumnName("处方号");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.金额).HasColumnName("金额");
        }
    }
}
