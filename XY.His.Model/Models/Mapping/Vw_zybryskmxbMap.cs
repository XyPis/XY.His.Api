using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_zybryskmxbMap : EntityTypeConfiguration<Vw_zybryskmxb>
    {
        public Vw_zybryskmxbMap()
        {
            // Primary Key
            this.HasKey(t => new { t.日期, t.日期字符, t.单据号 });

            // Properties
            this.Property(t => t.住院号)
                .HasMaxLength(13);

            this.Property(t => t.姓名)
                .HasMaxLength(30);

            this.Property(t => t.单据号)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.收费员)
                .HasMaxLength(30);

            this.Property(t => t.交付方式)
                .HasMaxLength(50);

            this.Property(t => t.病区)
                .HasMaxLength(30);

            this.Property(t => t.床号)
                .HasMaxLength(10);

            this.Property(t => t.病人地址)
                .HasMaxLength(100);

            this.Property(t => t.住院状态)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("Vw_zybryskmxb");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.日期字符).HasColumnName("日期字符");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.单据号).HasColumnName("单据号");
            this.Property(t => t.收费员).HasColumnName("收费员");
            this.Property(t => t.交付方式).HasColumnName("交付方式");
            this.Property(t => t.病区).HasColumnName("病区");
            this.Property(t => t.床号).HasColumnName("床号");
            this.Property(t => t.病人地址).HasColumnName("病人地址");
            this.Property(t => t.住院状态).HasColumnName("住院状态");
        }
    }
}
