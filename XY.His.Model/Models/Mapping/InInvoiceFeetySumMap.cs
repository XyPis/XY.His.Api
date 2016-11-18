using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InInvoiceFeetySumMap : EntityTypeConfiguration<InInvoiceFeetySum>
    {
        public InInvoiceFeetySumMap()
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
            this.ToTable("InInvoiceFeetySum");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.FeeId).HasColumnName("FeeId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.AmountFact).HasColumnName("AmountFact");
            this.Property(t => t.AmountSelf).HasColumnName("AmountSelf");
            this.Property(t => t.AmountTally).HasColumnName("AmountTally");
            this.Property(t => t.AmountPay).HasColumnName("AmountPay");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.MzAmount).HasColumnName("MzAmount");

            // Relationships
            this.HasRequired(t => t.BsZyFeety)
                .WithMany(t => t.InInvoiceFeetySums)
                .HasForeignKey(d => d.FeeId);
            this.HasRequired(t => t.InInvoice)
                .WithMany(t => t.InInvoiceFeetySums)
                .HasForeignKey(d => d.InvoId);

        }
    }
}
