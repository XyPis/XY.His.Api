using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_mmzy_mztfMap : EntityTypeConfiguration<Vw_mmzy_mztf>
    {
        public Vw_mmzy_mztfMap()
        {
            // Primary Key
            this.HasKey(t => new { t.单据号, t.原单据号, t.收费日期, t.结算种类, t.自付金额, t.优惠金额, t.ID, t.病人姓名, t.流水号 });

            // Properties
            this.Property(t => t.单据号)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.原单据号)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.退费员)
                .HasMaxLength(30);

            this.Property(t => t.收费员)
                .HasMaxLength(30);

            this.Property(t => t.结算种类)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.自付金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.优惠金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.病人姓名)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.流水号)
                .IsRequired()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("Vw_mmzy_mztf");
            this.Property(t => t.单据号).HasColumnName("单据号");
            this.Property(t => t.原单据号).HasColumnName("原单据号");
            this.Property(t => t.退费员).HasColumnName("退费员");
            this.Property(t => t.收费员).HasColumnName("收费员");
            this.Property(t => t.收费日期).HasColumnName("收费日期");
            this.Property(t => t.结算种类).HasColumnName("结算种类");
            this.Property(t => t.退费日期).HasColumnName("退费日期");
            this.Property(t => t.总金额).HasColumnName("总金额");
            this.Property(t => t.自付金额).HasColumnName("自付金额");
            this.Property(t => t.记账金额).HasColumnName("记账金额");
            this.Property(t => t.优惠金额).HasColumnName("优惠金额");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.病人姓名).HasColumnName("病人姓名");
            this.Property(t => t.流水号).HasColumnName("流水号");
        }
    }
}
