using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InPayMap : EntityTypeConfiguration<InPay>
    {
        public InPayMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("InPay");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.InvoId).HasColumnName("InvoId");
            this.Property(t => t.DepositId).HasColumnName("DepositId");
            this.Property(t => t.LsChargeType).HasColumnName("LsChargeType");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.PayWayId).HasColumnName("PayWayId");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.Remain).HasColumnName("Remain");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.CancelPaywayId).HasColumnName("CancelPaywayId");

            // Relationships
            this.HasRequired(t => t.BsPayWay)
                .WithMany(t => t.InPays)
                .HasForeignKey(d => d.PayWayId);
            this.HasOptional(t => t.InDeposit)
                .WithMany(t => t.InPays)
                .HasForeignKey(d => d.DepositId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InPays)
                .HasForeignKey(d => d.HospId);
            this.HasOptional(t => t.InInvoice)
                .WithMany(t => t.InPays)
                .HasForeignKey(d => d.InvoId);

        }
    }
}
