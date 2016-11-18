using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwHuStoreLog_tempMap : EntityTypeConfiguration<VwHuStoreLog_temp>
    {
        public VwHuStoreLog_tempMap()
        {
            // Primary Key
            this.HasKey(t => new { t.HappenTime, t.HouseId, t.HouseName, t.ItemId, t.ItemCode, t.ItemName, t.Spec, t.BeforeStockNum, t.AfterStockNum, t.HappenNum, t.StockPrice, t.RetailPrice, t.BillNo, t.Memo });

            // Properties
            this.Property(t => t.HouseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HouseName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.BeforeStockNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AfterStockNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HappenNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StockPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RetailPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OperUnitName)
                .HasMaxLength(50);

            this.Property(t => t.LsActType)
                .HasMaxLength(8);

            // Table & Column Mappings
            this.ToTable("VwHuStoreLog_temp");
            this.Property(t => t.HappenTime).HasColumnName("HappenTime");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.HouseName).HasColumnName("HouseName");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.BeforeStockNum).HasColumnName("BeforeStockNum");
            this.Property(t => t.AfterStockNum).HasColumnName("AfterStockNum");
            this.Property(t => t.HappenNum).HasColumnName("HappenNum");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.StockPriceAmount).HasColumnName("StockPriceAmount");
            this.Property(t => t.RetailPriceAmount).HasColumnName("RetailPriceAmount");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.OperUnitName).HasColumnName("OperUnitName");
            this.Property(t => t.LsActType).HasColumnName("LsActType");
        }
    }
}
