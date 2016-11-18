using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwHuOutBackMap : EntityTypeConfiguration<VwHuOutBack>
    {
        public VwHuOutBackMap()
        {
            // Primary Key
            this.HasKey(t => new { t.发生日期, t.HouseId, t.药品代码, t.药品名称, t.规格, t.零售价, t.进货价, t.药品类型, t.单号 });

            // Properties
            this.Property(t => t.HouseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.药库名称)
                .HasMaxLength(50);

            this.Property(t => t.药品代码)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.药品名称)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.规格)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.零售价)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.进货价)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.单位)
                .HasMaxLength(50);

            this.Property(t => t.供应商)
                .HasMaxLength(50);

            this.Property(t => t.出入库类型)
                .HasMaxLength(8);

            this.Property(t => t.药品类型)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.领药单位)
                .HasMaxLength(50);

            this.Property(t => t.剂型)
                .HasMaxLength(50);

            this.Property(t => t.单号)
                .IsRequired()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("VwHuOutBack");
            this.Property(t => t.发生日期).HasColumnName("发生日期");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.药库名称).HasColumnName("药库名称");
            this.Property(t => t.药品代码).HasColumnName("药品代码");
            this.Property(t => t.药品名称).HasColumnName("药品名称");
            this.Property(t => t.规格).HasColumnName("规格");
            this.Property(t => t.发生数量).HasColumnName("发生数量");
            this.Property(t => t.零售价).HasColumnName("零售价");
            this.Property(t => t.进货价).HasColumnName("进货价");
            this.Property(t => t.进货金额).HasColumnName("进货金额");
            this.Property(t => t.零售金额).HasColumnName("零售金额");
            this.Property(t => t.单位).HasColumnName("单位");
            this.Property(t => t.供应商).HasColumnName("供应商");
            this.Property(t => t.出入库类型).HasColumnName("出入库类型");
            this.Property(t => t.药品类型).HasColumnName("药品类型");
            this.Property(t => t.领药单位).HasColumnName("领药单位");
            this.Property(t => t.剂型).HasColumnName("剂型");
            this.Property(t => t.单号).HasColumnName("单号");
        }
    }
}
