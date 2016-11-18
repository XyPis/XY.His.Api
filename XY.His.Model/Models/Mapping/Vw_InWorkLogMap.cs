using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_InWorkLogMap : EntityTypeConfiguration<Vw_InWorkLog>
    {
        public Vw_InWorkLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.科号, t.科别, t.三级科室 });

            // Properties
            this.Property(t => t.科号)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.科别)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.三级科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.统标)
                .HasMaxLength(10);

            this.Property(t => t.年月)
                .HasMaxLength(10);

            this.Property(t => t.科室_月份)
                .HasMaxLength(17);

            // Table & Column Mappings
            this.ToTable("Vw_InWorkLog");
            this.Property(t => t.科号).HasColumnName("科号");
            this.Property(t => t.科别).HasColumnName("科别");
            this.Property(t => t.三级科室).HasColumnName("三级科室");
            this.Property(t => t.床位数).HasColumnName("床位数");
            this.Property(t => t.期末实有病床数).HasColumnName("期末实有病床数");
            this.Property(t => t.统标).HasColumnName("统标");
            this.Property(t => t.原人数).HasColumnName("原人数");
            this.Property(t => t.期初人数).HasColumnName("期初人数");
            this.Property(t => t.入院人数).HasColumnName("入院人数");
            this.Property(t => t.他科转入).HasColumnName("他科转入");
            this.Property(t => t.转往他科).HasColumnName("转往他科");
            this.Property(t => t.出院人数).HasColumnName("出院人数");
            this.Property(t => t.死亡人数).HasColumnName("死亡人数");
            this.Property(t => t.现有人数).HasColumnName("现有人数");
            this.Property(t => t.期末人数).HasColumnName("期末人数");
            this.Property(t => t.陪人数).HasColumnName("陪人数");
            this.Property(t => t.年月).HasColumnName("年月");
            this.Property(t => t.科室_月份).HasColumnName("科室_月份");
            this.Property(t => t.日期).HasColumnName("日期");
        }
    }
}
