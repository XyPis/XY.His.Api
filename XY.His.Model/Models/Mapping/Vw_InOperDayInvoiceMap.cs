using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_InOperDayInvoiceMap : EntityTypeConfiguration<Vw_InOperDayInvoice>
    {
        public Vw_InOperDayInvoiceMap()
        {
            // Primary Key
            this.HasKey(t => new { t.病人ID, t.卡号, t.姓名, t.病人大类, t.病人类别, t.科室, t.收费日期, t.总金额, t.自付金额, t.应交金额, t.凑整费 });

            // Properties
            this.Property(t => t.单据号)
                .HasMaxLength(20);

            this.Property(t => t.病人ID)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.卡号)
                .IsRequired()
                .HasMaxLength(13);

            this.Property(t => t.姓名)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.病人大类)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.病人类别)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.科室)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.收费员)
                .HasMaxLength(30);

            this.Property(t => t.总金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.自付金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.应交金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.凑整费)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Vw_InOperDayInvoice");
            this.Property(t => t.单据号).HasColumnName("单据号");
            this.Property(t => t.病人ID).HasColumnName("病人ID");
            this.Property(t => t.卡号).HasColumnName("卡号");
            this.Property(t => t.姓名).HasColumnName("姓名");
            this.Property(t => t.病人大类).HasColumnName("病人大类");
            this.Property(t => t.病人类别).HasColumnName("病人类别");
            this.Property(t => t.科室).HasColumnName("科室");
            this.Property(t => t.收费员).HasColumnName("收费员");
            this.Property(t => t.收费日期).HasColumnName("收费日期");
            this.Property(t => t.总金额).HasColumnName("总金额");
            this.Property(t => t.自付金额).HasColumnName("自付金额");
            this.Property(t => t.记账金额).HasColumnName("记账金额");
            this.Property(t => t.优惠金额).HasColumnName("优惠金额");
            this.Property(t => t.应交金额).HasColumnName("应交金额");
            this.Property(t => t.凑整费).HasColumnName("凑整费");
        }
    }
}
