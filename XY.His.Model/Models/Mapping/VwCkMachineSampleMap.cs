using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwCkMachineSampleMap : EntityTypeConfiguration<VwCkMachineSample>
    {
        public VwCkMachineSampleMap()
        {
            // Primary Key
            this.HasKey(t => new { t.仪器名称, t.检验项目, t.仪器流水号, t.价格, t.标本号 });

            // Properties
            this.Property(t => t.仪器名称)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.检验项目)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.仪器流水号)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.价格)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.标本号)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.操作员)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("VwCkMachineSample");
            this.Property(t => t.仪器名称).HasColumnName("仪器名称");
            this.Property(t => t.检验项目).HasColumnName("检验项目");
            this.Property(t => t.仪器流水号).HasColumnName("仪器流水号");
            this.Property(t => t.匹配时间).HasColumnName("匹配时间");
            this.Property(t => t.价格).HasColumnName("价格");
            this.Property(t => t.标本号).HasColumnName("标本号");
            this.Property(t => t.操作员).HasColumnName("操作员");
        }
    }
}
