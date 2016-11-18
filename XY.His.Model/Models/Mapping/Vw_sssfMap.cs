using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_sssfMap : EntityTypeConfiguration<Vw_sssf>
    {
        public Vw_sssfMap()
        {
            // Primary Key
            this.HasKey(t => new { t.执行科室, t.发票分类, t.基础分类, t.住院号, t.住院次数, t.姓名 });

            // Properties
            this.Property(t => t.申请科室)
                .HasMaxLength(30);

            this.Property(t => t.执行科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.日期)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.发票分类)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.基础分类)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.住院号)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.住院次数)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.姓名)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Vw_sssf");
            this.Property(t => t.申请科室).HasColumnName("申请科室");
            this.Property(t => t.执行科室).HasColumnName("执行科室");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.发票分类).HasColumnName("发票分类");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.基础分类).HasColumnName("基础分类");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.住院次数).HasColumnName("住院次数");
            this.Property(t => t.姓名).HasColumnName("姓名");
        }
    }
}
