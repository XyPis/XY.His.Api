using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class HuStoreLogMap : EntityTypeConfiguration<HuStoreLog>
    {
        public HuStoreLogMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Memo)
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

            // Table & Column Mappings
            this.ToTable("HuStoreLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HappenTime).HasColumnName("HappenTime");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.InBatchId).HasColumnName("InBatchId");
            this.Property(t => t.BeforeStockNum).HasColumnName("BeforeStockNum");
            this.Property(t => t.HappenNum).HasColumnName("HappenNum");
            this.Property(t => t.AfterStockNum).HasColumnName("AfterStockNum");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.LsActType).HasColumnName("LsActType");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsHouse)
                .WithMany(t => t.HuStoreLogs)
                .HasForeignKey(d => d.HouseId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.HuStoreLogs)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.HuStoreLogs)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.HuStore)
                .WithMany(t => t.HuStoreLogs)
                .HasForeignKey(d => d.InBatchId);

        }
    }
}
