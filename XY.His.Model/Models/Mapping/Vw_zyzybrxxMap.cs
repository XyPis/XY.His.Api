using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_zyzybrxxMap : EntityTypeConfiguration<Vw_zyzybrxx>
    {
        public Vw_zyzybrxxMap()
        {
            // Primary Key
            this.HasKey(t => new { t.住院号, t.姓名, t.性别, t.住院次数, t.入院日期 });

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

            this.Property(t => t.住院次数)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.病人类别)
                .HasMaxLength(50);

            this.Property(t => t.入院科室)
                .HasMaxLength(30);

            this.Property(t => t.住院科室)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Vw_zyzybrxx");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.住院次数).HasColumnName("住院次数");
            this.Property(t => t.入院日期).HasColumnName("入院日期");
            this.Property(t => t.病人类别).HasColumnName("病人类别");
            this.Property(t => t.入院科室).HasColumnName("入院科室");
            this.Property(t => t.住院科室).HasColumnName("住院科室");
        }
    }
}
