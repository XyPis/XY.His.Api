using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_zyrydjxx_czMap : EntityTypeConfiguration<Vw_zyrydjxx_cz>
    {
        public Vw_zyrydjxx_czMap()
        {
            // Primary Key
            this.HasKey(t => new { t.住院号, t.姓名, t.性别, t.身份证号, t.职工单位, t.入院日期 });

            // Properties
            this.Property(t => t.住院号)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.姓名)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.性别)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.身份证号)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.家庭医保号)
                .HasMaxLength(18);

            this.Property(t => t.职工单位)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.住院科室)
                .HasMaxLength(30);

            this.Property(t => t.房号床号)
                .HasMaxLength(17);

            this.Property(t => t.病人类别)
                .HasMaxLength(50);

            this.Property(t => t.住院状态)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("Vw_zyrydjxx_cz");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.身份证号).HasColumnName("身份证号");
            this.Property(t => t.家庭医保号).HasColumnName("家庭医保号");
            this.Property(t => t.职工单位).HasColumnName("职工单位");
            this.Property(t => t.住院科室).HasColumnName("住院科室");
            this.Property(t => t.房号床号).HasColumnName("房号床号");
            this.Property(t => t.入院日期).HasColumnName("入院日期");
            this.Property(t => t.病人类别).HasColumnName("病人类别");
            this.Property(t => t.住院状态).HasColumnName("住院状态");
        }
    }
}
