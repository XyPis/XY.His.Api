using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuInvoicePayMap : EntityTypeConfiguration<OuInvoicePay>
    {
        public OuInvoicePayMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OuInvoicePay");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.PaywayId).HasColumnName("PaywayId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.cancelPaywayId).HasColumnName("cancelPaywayId");

            // Relationships
            this.HasRequired(t => t.BsPayWay)
                .WithMany(t => t.OuInvoicePays)
                .HasForeignKey(d => d.PaywayId);
            this.HasRequired(t => t.OuInvoice)
                .WithMany(t => t.OuInvoicePays)
                .HasForeignKey(d => d.InvoId);

        }
    }
}
