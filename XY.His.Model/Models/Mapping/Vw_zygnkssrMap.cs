using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_zygnkssrMap : EntityTypeConfiguration<Vw_zygnkssr>
    {
        public Vw_zygnkssrMap()
        {
            // Primary Key
            this.HasKey(t => new { t.科室, t.基础分类 });

            // Properties
            this.Property(t => t.科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.日期)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.基础分类)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Vw_zygnkssr");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.基础分类).HasColumnName("基础分类");
        }
    }
}
