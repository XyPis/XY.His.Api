using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwOuIncomeReportGroupMap : EntityTypeConfiguration<VwOuIncomeReportGroup>
    {
        public VwOuIncomeReportGroupMap()
        {
            // Primary Key
            this.HasKey(t => new { t.病人姓名, t.卡号, t.门诊号, t.性别, t.报表分类, t.发票号 });

            // Properties
            this.Property(t => t.执行科室)
                .HasMaxLength(30);

            this.Property(t => t.医嘱医生)
                .HasMaxLength(40);

            this.Property(t => t.病人姓名)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.主诊医生)
                .HasMaxLength(40);

            this.Property(t => t.卡号)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.门诊号)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.性别)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.病人类别)
                .HasMaxLength(50);

            this.Property(t => t.报表分类)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.发票号)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.申请科室)
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("VwOuIncomeReportGroup");
            this.Property(t => t.执行科室).HasColumnName("执行科室");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.实收金额).HasColumnName("实收金额");
            this.Property(t => t.记帐金额).HasColumnName("记帐金额");
            this.Property(t => t.自付金额).HasColumnName("自付金额");
            this.Property(t => t.医嘱医生).HasColumnName("医嘱医生");
            this.Property(t => t.病人姓名).HasColumnName("病人姓名");
            this.Property(t => t.主诊医生).HasColumnName("主诊医生");
            this.Property(t => t.卡号).HasColumnName("卡号");
            this.Property(t => t.门诊号).HasColumnName("门诊号");
            this.Property(t => t.年龄).HasColumnName("年龄");
            this.Property(t => t.性别).HasColumnName("性别");
            this.Property(t => t.病人类别).HasColumnName("病人类别");
            this.Property(t => t.报表分类).HasColumnName("报表分类");
            this.Property(t => t.发票号).HasColumnName("发票号");
            this.Property(t => t.发票日期).HasColumnName("发票日期");
            this.Property(t => t.申请科室).HasColumnName("申请科室");
        }
    }
}
