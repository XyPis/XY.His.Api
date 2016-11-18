using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwCkQcResultMap : EntityTypeConfiguration<VwCkQcResult>
    {
        public VwCkQcResultMap()
        {
            // Primary Key
            this.HasKey(t => new { t.标准, t.TestId, t.项目编码, t.检验项目, t.备注, t.批号, t.操作员, t.单位, t.项目类型, t.ID, t.状态 });

            // Properties
            this.Property(t => t.仪器)
                .HasMaxLength(50);

            this.Property(t => t.标准)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.TestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.项目编码)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.检验项目)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.日期)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.备注)
                .IsRequired()
                .HasMaxLength(255);

            this.Property(t => t.批号)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.标本类型)
                .HasMaxLength(50);

            this.Property(t => t.操作员)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.单位)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.项目类型)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.实验方法)
                .HasMaxLength(50);

            this.Property(t => t.状态)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwCkQcResult");
            this.Property(t => t.仪器).HasColumnName("仪器");
            this.Property(t => t.标准).HasColumnName("标准");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.项目编码).HasColumnName("项目编码");
            this.Property(t => t.检验项目).HasColumnName("检验项目");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.结果).HasColumnName("结果");
            this.Property(t => t.备注).HasColumnName("备注");
            this.Property(t => t.批号).HasColumnName("批号");
            this.Property(t => t.标本类型).HasColumnName("标本类型");
            this.Property(t => t.操作员).HasColumnName("操作员");
            this.Property(t => t.单位).HasColumnName("单位");
            this.Property(t => t.项目类型).HasColumnName("项目类型");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.实验方法).HasColumnName("实验方法");
            this.Property(t => t.标准偏差_3).HasColumnName("标准偏差+3");
            this.Property(t => t.标准偏差_2).HasColumnName("标准偏差+2");
            this.Property(t => t.标准偏差_1).HasColumnName("标准偏差+1");
            this.Property(t => t.标准偏差_11).HasColumnName("标准偏差-1");
            this.Property(t => t.标准偏差_21).HasColumnName("标准偏差-2");
            this.Property(t => t.标准偏差_31).HasColumnName("标准偏差-3");
            this.Property(t => t.平均值).HasColumnName("平均值");
            this.Property(t => t.状态).HasColumnName("状态");
        }
    }
}
