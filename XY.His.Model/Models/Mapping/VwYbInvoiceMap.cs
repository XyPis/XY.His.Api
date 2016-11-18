using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwYbInvoiceMap : EntityTypeConfiguration<VwYbInvoice>
    {
        public VwYbInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.结算日期, t.住院号, t.科室, t.总金额, t.特殊病种, t.诊断 });

            // Properties
            this.Property(t => t.序号)
                .HasMaxLength(29);

            this.Property(t => t.住院号)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.发票号)
                .HasMaxLength(20);

            this.Property(t => t.姓名)
                .HasMaxLength(30);

            this.Property(t => t.科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.总金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.病人类别)
                .HasMaxLength(50);

            this.Property(t => t.病人大类)
                .HasMaxLength(50);

            this.Property(t => t.特殊病种)
                .IsRequired()
                .HasMaxLength(2);

            this.Property(t => t.诊断)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.结算日期信息)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.出院日期信息)
                .IsFixedLength()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("VwYbInvoice");
            this.Property(t => t.结算日期).HasColumnName("结算日期");
            this.Property(t => t.序号).HasColumnName("序号");
            this.Property(t => t.住院号).HasColumnName("住院号");
            this.Property(t => t.发票号).HasColumnName("发票号");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.总金额).HasColumnName("总金额");
            this.Property(t => t.统筹支付金额).HasColumnName("统筹支付金额");
            this.Property(t => t.个人自付金额).HasColumnName("个人自付金额");
            this.Property(t => t.病人类别).HasColumnName("病人类别");
            this.Property(t => t.病人大类).HasColumnName("病人大类");
            this.Property(t => t.特殊病种).HasColumnName("特殊病种");
            this.Property(t => t.诊断).HasColumnName("诊断");
            this.Property(t => t.出院日期).HasColumnName("出院日期");
            this.Property(t => t.结算日期信息).HasColumnName("结算日期信息");
            this.Property(t => t.出院日期信息).HasColumnName("出院日期信息");
        }
    }
}
