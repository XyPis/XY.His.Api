using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_mmzy_mzfpMap : EntityTypeConfiguration<Vw_mmzy_mzfp>
    {
        public Vw_mmzy_mzfpMap()
        {
            // Primary Key
            this.HasKey(t => t.单据号);

            // Properties
            this.Property(t => t.付款方式)
                .HasMaxLength(50);

            this.Property(t => t.单据号)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.收费员)
                .HasMaxLength(30);

            this.Property(t => t.病人类别)
                .HasMaxLength(50);

            this.Property(t => t.卡号)
                .HasMaxLength(19);

            this.Property(t => t.姓名)
                .HasMaxLength(30);

            this.Property(t => t.发票状态)
                .HasMaxLength(6);

            // Table & Column Mappings
            this.ToTable("Vw_mmzy_mzfp");
            this.Property(t => t.发票金额).HasColumnName("发票金额");
            this.Property(t => t.付款方式).HasColumnName("付款方式");
            this.Property(t => t.单据号).HasColumnName("单据号");
            this.Property(t => t.收费员).HasColumnName("收费员");
            this.Property(t => t.发票日期).HasColumnName("发票日期");
            this.Property(t => t.病人类别).HasColumnName("病人类别");
            this.Property(t => t.卡号).HasColumnName("卡号");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.退款金额).HasColumnName("退款金额");
            this.Property(t => t.发票状态).HasColumnName("发票状态");
        }
    }
}
