using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_zysfflhzMap : EntityTypeConfiguration<Vw_zysfflhz>
    {
        public Vw_zysfflhzMap()
        {
            // Primary Key
            this.HasKey(t => t.费用日期);

            // Properties
            this.Property(t => t.基础分类)
                .HasMaxLength(50);

            this.Property(t => t.发票分类)
                .HasMaxLength(50);

            this.Property(t => t.住院号)
                .HasMaxLength(20);

            this.Property(t => t.姓名)
                .HasMaxLength(30);

            this.Property(t => t.住院记录)
                .HasMaxLength(31);

            this.Property(t => t.病区)
                .HasMaxLength(30);

            this.Property(t => t.床号)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Vw_zysfflhz");
            this.Property(t => t.基础分类).HasColumnName("基础分类");
            this.Property(t => t.发票分类).HasColumnName("发票分类");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.入院日期).HasColumnName("入院日期");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.住院次数).HasColumnName("住院次数");
            this.Property(t => t.住院记录).HasColumnName("住院记录");
            this.Property(t => t.费用日期).HasColumnName("费用日期");
            this.Property(t => t.病区).HasColumnName("病区");
            this.Property(t => t.床号).HasColumnName("床号");
        }
    }
}
