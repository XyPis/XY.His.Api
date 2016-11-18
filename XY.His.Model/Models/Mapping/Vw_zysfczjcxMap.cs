using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_zysfczjcxMap : EntityTypeConfiguration<Vw_zysfczjcx>
    {
        public Vw_zysfczjcxMap()
        {
            // Primary Key
            this.HasKey(t => new { t.金额, t.日期, t.科室 });

            // Properties
            this.Property(t => t.收费员)
                .HasMaxLength(30);

            this.Property(t => t.支付方式)
                .HasMaxLength(50);

            this.Property(t => t.金额)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.收付类型)
                .HasMaxLength(12);

            this.Property(t => t.科室)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Vw_zysfczjcx");
            this.Property(t => t.收费员).HasColumnName("收费员");
            this.Property(t => t.支付方式).HasColumnName("支付方式");
            this.Property(t => t.金额).HasColumnName("金额");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.发票ID).HasColumnName("发票ID");
            this.Property(t => t.收付类型).HasColumnName("收付类型");
            this.Property(t => t.科室).HasColumnName("科室");
        }
    }
}
