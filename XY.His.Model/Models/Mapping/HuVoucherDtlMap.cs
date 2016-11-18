using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class HuVoucherDtlMap : EntityTypeConfiguration<HuVoucherDtl>
    {
        public HuVoucherDtlMap()
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
            this.ToTable("HuVoucherDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.VoucherId).HasColumnName("VoucherId");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.HasPay).HasColumnName("HasPay");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.HuStock)
                .WithMany(t => t.HuVoucherDtls)
                .HasForeignKey(d => d.BillId);
            this.HasOptional(t => t.HuVoucher)
                .WithMany(t => t.HuVoucherDtls)
                .HasForeignKey(d => d.VoucherId);

        }
    }
}
