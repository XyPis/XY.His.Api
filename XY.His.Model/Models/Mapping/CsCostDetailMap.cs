using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CsCostDetailMap : EntityTypeConfiguration<CsCostDetail>
    {
        public CsCostDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Summary)
                .HasMaxLength(200);

            this.Property(t => t.ItemName)
                .HasMaxLength(50);

            this.Property(t => t.Unit)
                .HasMaxLength(10);

            this.Property(t => t.VoucherType)
                .HasMaxLength(50);

            this.Property(t => t.VoucherNo)
                .HasMaxLength(40);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CsCostDetail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.PayDate).HasColumnName("PayDate");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.LocId).HasColumnName("LocId");
            this.Property(t => t.CostSubjId).HasColumnName("CostSubjId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.VoucherType).HasColumnName("VoucherType");
            this.Property(t => t.VoucherNo).HasColumnName("VoucherNo");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.IsAcct).HasColumnName("IsAcct");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.CsCostDetails)
                .HasForeignKey(d => d.LocId);
            this.HasOptional(t => t.CsCostSubj)
                .WithMany(t => t.CsCostDetails)
                .HasForeignKey(d => d.CostSubjId);

        }
    }
}
