using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_ZyLocationFeePayedMap : EntityTypeConfiguration<Vw_ZyLocationFeePayed>
    {
        public Vw_ZyLocationFeePayedMap()
        {
            // Primary Key
            this.HasKey(t => new { t.科室, t.日期, t.金额, t.基础分类, t.项目名称, t.规格, t.价格, t.录入人, t.病人ID, t.病人姓名 });

            // Properties
            this.Property(t => t.科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.基础分类)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.项目名称)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.规格)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.价格)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.录入人)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.病人ID)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.病人姓名)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Vw_ZyLocationFeePayed");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.基础分类).HasColumnName("基础分类");
            this.Property(t => t.项目名称).HasColumnName("项目名称");
            this.Property(t => t.规格).HasColumnName("规格");
            this.Property(t => t.价格).HasColumnName("价格");
            this.Property(t => t.录入人).HasColumnName("录入人");
            this.Property(t => t.病人ID).HasColumnName("病人ID");
            this.Property(t => t.病人姓名).HasColumnName("病人姓名");
        }
    }
}
