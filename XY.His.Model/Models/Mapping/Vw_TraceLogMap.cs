using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_TraceLogMap : EntityTypeConfiguration<Vw_TraceLog>
    {
        public Vw_TraceLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.操作员, t.日期, t.项目ID, t.项目名称, t.规格, t.操作类别 });

            // Properties
            this.Property(t => t.操作员)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.项目ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.项目名称)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.规格)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.信息)
                .HasMaxLength(4000);

            this.Property(t => t.项目类别)
                .HasMaxLength(6);

            this.Property(t => t.操作类别)
                .IsRequired()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("Vw_TraceLog");
            this.Property(t => t.操作员).HasColumnName("操作员");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.项目ID).HasColumnName("项目ID");
            this.Property(t => t.项目名称).HasColumnName("项目名称");
            this.Property(t => t.规格).HasColumnName("规格");
            this.Property(t => t.信息).HasColumnName("信息");
            this.Property(t => t.项目类别).HasColumnName("项目类别");
            this.Property(t => t.操作类别).HasColumnName("操作类别");
        }
    }
}
