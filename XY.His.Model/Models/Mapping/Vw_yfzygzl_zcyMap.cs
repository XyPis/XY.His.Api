using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_yfzygzl_zcyMap : EntityTypeConfiguration<Vw_yfzygzl_zcy>
    {
        public Vw_yfzygzl_zcyMap()
        {
            // Primary Key
            this.HasKey(t => new { t.进出类别, t.申请科室, t.医嘱号, t.药房名称 });

            // Properties
            this.Property(t => t.进出类别)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.申请科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.日期)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.医嘱号)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.药房名称)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Vw_yfzygzl_zcy");
            this.Property(t => t.进出类别).HasColumnName("进出类别");
            this.Property(t => t.申请科室).HasColumnName("申请科室");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.医嘱号).HasColumnName("医嘱号");
            this.Property(t => t.药房名称).HasColumnName("药房名称");
            this.Property(t => t.金额).HasColumnName("金额");
        }
    }
}
