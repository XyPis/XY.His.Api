using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_zyanjMap : EntityTypeConfiguration<Vw_zyanj>
    {
        public Vw_zyanjMap()
        {
            // Primary Key
            this.HasKey(t => new { t.住院号, t.姓名, t.住院次数, t.日期, t.单据号 });

            // Properties
            this.Property(t => t.住院号)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.姓名)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.住院次数)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.科室)
                .HasMaxLength(30);

            this.Property(t => t.交付方式)
                .HasMaxLength(50);

            this.Property(t => t.单据号)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.住院状态)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("Vw_zyanj");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.住院次数).HasColumnName("住院次数");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.交付方式).HasColumnName("交付方式");
            this.Property(t => t.单据号).HasColumnName("单据号");
            this.Property(t => t.住院状态).HasColumnName("住院状态");
        }
    }
}
