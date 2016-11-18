using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_DI_OuInvoiceSumMap : EntityTypeConfiguration<Vw_DI_OuInvoiceSum>
    {
        public Vw_DI_OuInvoiceSumMap()
        {
            // Primary Key
            this.HasKey(t => t.科室);

            // Properties
            this.Property(t => t.日期)
                .IsFixedLength()
                .HasMaxLength(10);

            this.Property(t => t.科室)
                .IsRequired()
                .HasMaxLength(30);

            // Table & Column Mappings
            this.ToTable("Vw_DI_OuInvoiceSum");
            this.Property(t => t.总金额).HasColumnName("总金额");
            this.Property(t => t.日期).HasColumnName("日期");
            this.Property(t => t.月份).HasColumnName("月份");
            this.Property(t => t.年份).HasColumnName("年份");
            this.Property(t => t.科室).HasColumnName("科室");
        }
    }
}
