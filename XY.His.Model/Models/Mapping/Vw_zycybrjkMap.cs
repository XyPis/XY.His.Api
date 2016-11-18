using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_zycybrjkMap : EntityTypeConfiguration<Vw_zycybrjk>
    {
        public Vw_zycybrjkMap()
        {
            // Primary Key
            this.HasKey(t => new { t.单据号, t.收费日期, t.总金额, t.应交金额, t.预收金额, t.结欠费用, t.补款, t.凑整费, t.住院天数, t.入院诊断 });

            // Properties
            this.Property(t => t.单据号)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.住院号)
                .HasMaxLength(13);

            this.Property(t => t.住院信息)
                .HasMaxLength(44);

            this.Property(t => t.姓名)
                .HasMaxLength(30);

            this.Property(t => t.住院状态)
                .HasMaxLength(8);

            this.Property(t => t.结算类型)
                .HasMaxLength(8);

            this.Property(t => t.病人类别)
                .HasMaxLength(50);

            this.Property(t => t.病学中心)
                .HasMaxLength(100);

            this.Property(t => t.住院科室)
                .HasMaxLength(30);

            this.Property(t => t.收费员)
                .HasMaxLength(30);

            this.Property(t => t.总金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.应交金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.预收金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.结欠费用)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.补款)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.凑整费)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.结算方式)
                .HasMaxLength(50);

            this.Property(t => t.病人大类)
                .HasMaxLength(50);

            this.Property(t => t.住院天数)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.入院诊断)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Vw_zycybrjk");
            this.Property(t => t.单据号).HasColumnName("单据号");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.住院信息).HasColumnName("住院信息");
            this.Property(t => t.住院次数).HasColumnName("住院次数");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.出院日期).HasColumnName("出院日期");
            this.Property(t => t.住院状态).HasColumnName("住院状态");
            this.Property(t => t.结算类型).HasColumnName("结算类型");
            this.Property(t => t.病人类别).HasColumnName("病人类别");
            this.Property(t => t.病学中心).HasColumnName("病学中心");
            this.Property(t => t.住院科室).HasColumnName("住院科室");
            this.Property(t => t.收费员).HasColumnName("收费员");
            this.Property(t => t.收费日期).HasColumnName("收费日期");
            this.Property(t => t.总金额).HasColumnName("总金额");
            this.Property(t => t.记账金额).HasColumnName("记账金额");
            this.Property(t => t.应交金额).HasColumnName("应交金额");
            this.Property(t => t.预收金额).HasColumnName("预收金额");
            this.Property(t => t.结欠费用).HasColumnName("结欠费用");
            this.Property(t => t.退款).HasColumnName("退款");
            this.Property(t => t.补款).HasColumnName("补款");
            this.Property(t => t.凑整费).HasColumnName("凑整费");
            this.Property(t => t.结算方式).HasColumnName("结算方式");
            this.Property(t => t.病人大类).HasColumnName("病人大类");
            this.Property(t => t.住院天数).HasColumnName("住院天数");
            this.Property(t => t.入院诊断).HasColumnName("入院诊断");
        }
    }
}
