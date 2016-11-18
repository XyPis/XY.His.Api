using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_zysfxmhb_ksMap : EntityTypeConfiguration<Vw_zysfxmhb_ks>
    {
        public Vw_zysfxmhb_ksMap()
        {
            // Primary Key
            this.HasKey(t => new { t.数量, t.金额, t.日期, t.性别, t.项目类别 });

            // Properties
            this.Property(t => t.住院号)
                .HasMaxLength(13);

            this.Property(t => t.住院信息)
                .HasMaxLength(44);

            this.Property(t => t.姓名)
                .HasMaxLength(30);

            this.Property(t => t.病人类别)
                .HasMaxLength(50);

            this.Property(t => t.项目名称)
                .HasMaxLength(50);

            this.Property(t => t.项目代码)
                .HasMaxLength(20);

            this.Property(t => t.数量)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.住院状态)
                .HasMaxLength(8);

            this.Property(t => t.性别)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.项目类别)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Vw_zysfxmhb_ks");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.住院次数).HasColumnName("住院次数");
            this.Property(t => t.住院信息).HasColumnName("住院信息");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.病人类别).HasColumnName("病人类别");
            this.Property(t => t.项目名称).HasColumnName("项目名称");
            this.Property(t => t.项目代码).HasColumnName("项目代码");
            this.Property(t => t.单价).HasColumnName("单价");
            this.Property(t => t.数量).HasColumnName("数量");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.住院状态).HasColumnName("住院状态");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.项目类别).HasColumnName("项目类别");
        }
    }
}
