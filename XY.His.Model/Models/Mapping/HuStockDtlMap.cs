using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class HuStockDtlMap : EntityTypeConfiguration<HuStockDtl>
    {
        public HuStockDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.InBatchNo)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.PNo)
                .HasMaxLength(20);

            this.Property(t => t.VoucherNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.PassNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("HuStockDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.InBatchNo).HasColumnName("InBatchNo");
            this.Property(t => t.PNo).HasColumnName("PNo");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.DrugNum).HasColumnName("DrugNum");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.LimitDate).HasColumnName("LimitDate");
            this.Property(t => t.IsBid).HasColumnName("IsBid");
            this.Property(t => t.VoucherNo).HasColumnName("VoucherNo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.ProAreaId).HasColumnName("ProAreaId");
            this.Property(t => t.ManuId).HasColumnName("ManuId");
            this.Property(t => t.PassNo).HasColumnName("PassNo");
            this.Property(t => t.PriceHighLine).HasColumnName("PriceHighLine");

            // Relationships
            this.HasOptional(t => t.BsArea)
                .WithMany(t => t.HuStockDtls)
                .HasForeignKey(d => d.ProAreaId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.HuStockDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasOptional(t => t.BsManufacturer)
                .WithMany(t => t.HuStockDtls)
                .HasForeignKey(d => d.ManuId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.HuStockDtls)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.HuStock)
                .WithMany(t => t.HuStockDtls)
                .HasForeignKey(d => d.BillId);

        }
    }
}
