using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_zysfxmmxMap : EntityTypeConfiguration<Vw_zysfxmmx>
    {
        public Vw_zysfxmmxMap()
        {
            // Primary Key
            this.HasKey(t => new { t.单价, t.数量, t.金额, t.日期, t.日期字符, t.性别 });

            // Properties
            this.Property(t => t.住院号)
                .HasMaxLength(13);

            this.Property(t => t.住院信息)
                .HasMaxLength(44);

            this.Property(t => t.姓名)
                .HasMaxLength(30);

            this.Property(t => t.病区)
                .HasMaxLength(30);

            this.Property(t => t.执行科室)
                .HasMaxLength(30);

            this.Property(t => t.项目名称)
                .HasMaxLength(50);

            this.Property(t => t.项目代码)
                .HasMaxLength(20);

            this.Property(t => t.广东统一编码)
                .HasMaxLength(100);

            this.Property(t => t.单位)
                .HasMaxLength(50);

            this.Property(t => t.规格)
                .HasMaxLength(50);

            this.Property(t => t.单价)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.数量)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.操作人)
                .HasMaxLength(30);

            this.Property(t => t.医生)
                .HasMaxLength(40);

            this.Property(t => t.记账单号)
                .HasMaxLength(50);

            this.Property(t => t.病人类别)
                .HasMaxLength(50);

            this.Property(t => t.病人大类)
                .HasMaxLength(50);

            this.Property(t => t.床号)
                .HasMaxLength(10);

            this.Property(t => t.基础分类)
                .HasMaxLength(50);

            this.Property(t => t.发票分类)
                .HasMaxLength(50);

            this.Property(t => t.申请科室)
                .HasMaxLength(30);

            this.Property(t => t.住院状态)
                .HasMaxLength(8);

            this.Property(t => t.结算类型)
                .HasMaxLength(8);

            this.Property(t => t.年月)
                .HasMaxLength(10);

            this.Property(t => t.性别)
                .IsRequired()
                .HasMaxLength(4);

            // Table & Column Mappings
            this.ToTable("Vw_zysfxmmx");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.住院次数).HasColumnName("住院次数");
            this.Property(t => t.住院信息).HasColumnName("住院信息");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.病区).HasColumnName("病区");
            this.Property(t => t.执行科室).HasColumnName("执行科室");
            this.Property(t => t.项目名称).HasColumnName("项目名称");
            this.Property(t => t.项目代码).HasColumnName("项目代码");
            this.Property(t => t.广东统一编码).HasColumnName("广东统一编码");
            this.Property(t => t.单位).HasColumnName("单位");
            this.Property(t => t.规格).HasColumnName("规格");
            this.Property(t => t.单价).HasColumnName("单价");
            this.Property(t => t.数量).HasColumnName("数量");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.操作人).HasColumnName("操作人");
            this.Property(t => t.医生).HasColumnName("医生");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.日期字符).HasColumnName("日期字符");
            this.Property(t => t.记账单号).HasColumnName("记账单号");
            this.Property(t => t.病人类别).HasColumnName("病人类别");
            this.Property(t => t.病人大类).HasColumnName("病人大类");
            this.Property(t => t.床号).HasColumnName("床号");
            this.Property(t => t.基础分类).HasColumnName("基础分类");
            this.Property(t => t.发票分类).HasColumnName("发票分类");
            this.Property(t => t.orderby).HasColumnName("orderby");
            this.Property(t => t.申请科室).HasColumnName("申请科室");
            this.Property(t => t.住院状态).HasColumnName("住院状态");
            this.Property(t => t.结算类型).HasColumnName("结算类型");
            this.Property(t => t.年月).HasColumnName("年月");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.入院日期).HasColumnName("入院日期");
            this.Property(t => t.出院日期).HasColumnName("出院日期");
            this.Property(t => t.住院天数).HasColumnName("住院天数");
        }
    }
}
