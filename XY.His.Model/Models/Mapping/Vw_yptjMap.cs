using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_yptjMap : EntityTypeConfiguration<Vw_yptj>
    {
        public Vw_yptjMap()
        {
            // Primary Key
            this.HasKey(t => new { t.调价日期, t.调价日期字符, t.数量, t.原零售价, t.现零售价, t.零售损益 });

            // Properties
            this.Property(t => t.药品代码)
                .HasMaxLength(20);

            this.Property(t => t.药品名称)
                .HasMaxLength(50);

            this.Property(t => t.规格)
                .HasMaxLength(50);

            this.Property(t => t.数量)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.原零售价)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.现零售价)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.零售损益)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.单位)
                .HasMaxLength(50);

            this.Property(t => t.批号)
                .HasMaxLength(20);

            this.Property(t => t.调价员)
                .HasMaxLength(30);

            this.Property(t => t.采购公司)
                .HasMaxLength(50);

            this.Property(t => t.药品分类)
                .HasMaxLength(50);

            this.Property(t => t.调价地点)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Vw_yptj");
            this.Property(t => t.调价日期).HasColumnName("调价日期");
            this.Property(t => t.调价日期字符).HasColumnName("调价日期字符");
            this.Property(t => t.药品代码).HasColumnName("药品代码");
            this.Property(t => t.药品名称).HasColumnName("药品名称");
            this.Property(t => t.规格).HasColumnName("规格");
            this.Property(t => t.数量).HasColumnName("数量");
            this.Property(t => t.原零售价).HasColumnName("原零售价");
            this.Property(t => t.现零售价).HasColumnName("现零售价");
            this.Property(t => t.零售损益).HasColumnName("零售损益");
            this.Property(t => t.单位).HasColumnName("单位");
            this.Property(t => t.批号).HasColumnName("批号");
            this.Property(t => t.调价员).HasColumnName("调价员");
            this.Property(t => t.采购公司).HasColumnName("采购公司");
            this.Property(t => t.药品分类).HasColumnName("药品分类");
            this.Property(t => t.调价地点).HasColumnName("调价地点");
        }
    }
}
