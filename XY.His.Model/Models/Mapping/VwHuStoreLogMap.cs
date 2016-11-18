using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwHuStoreLogMap : EntityTypeConfiguration<VwHuStoreLog>
    {
        public VwHuStoreLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.HappenTime, t.HouseId, t.HouseName, t.ItemId, t.ItemCode, t.ItemName, t.Spec, t.InBatchId, t.InBatchNo, t.BeforeStockNum, t.HappenNum, t.AfterStockNum, t.RetailPrice, t.StockPrice, t.UnitId, t.Memo, t.BillNo, t.ActType, t.DrugType, t.Code });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.InBatchId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InBatchNo)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.PNo)
                .HasMaxLength(20);

            this.Property(t => t.UnitKcName)
                .HasMaxLength(50);

            this.Property(t => t.BeforeStockNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HappenNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AfterStockNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RetailPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StockPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperUnitName)
                .HasMaxLength(50);

            this.Property(t => t.BsCompanyName)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LsImportName)
                .HasMaxLength(6);

            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LsActType)
                .HasMaxLength(8);

            this.Property(t => t.ActType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DrugType)
                .IsRequired()
                .HasMaxLength(4);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ManufacturerName)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwHuStoreLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HappenTime).HasColumnName("HappenTime");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.HouseName).HasColumnName("HouseName");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.InBatchId).HasColumnName("InBatchId");
            this.Property(t => t.InBatchNo).HasColumnName("InBatchNo");
            this.Property(t => t.PNo).HasColumnName("PNo");
            this.Property(t => t.UnitKc).HasColumnName("UnitKc");
            this.Property(t => t.UnitKcName).HasColumnName("UnitKcName");
            this.Property(t => t.BeforeStockNum).HasColumnName("BeforeStockNum");
            this.Property(t => t.HappenNum).HasColumnName("HappenNum");
            this.Property(t => t.AfterStockNum).HasColumnName("AfterStockNum");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.StockPriceAmount).HasColumnName("StockPriceAmount");
            this.Property(t => t.RetailPriceAmount).HasColumnName("RetailPriceAmount");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.OperUnitName).HasColumnName("OperUnitName");
            this.Property(t => t.IsSpecial).HasColumnName("IsSpecial");
            this.Property(t => t.IsExpen).HasColumnName("IsExpen");
            this.Property(t => t.LsImport).HasColumnName("LsImport");
            this.Property(t => t.BsCompanyName).HasColumnName("BsCompanyName");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.LsImportName).HasColumnName("LsImportName");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.LsActType).HasColumnName("LsActType");
            this.Property(t => t.ActType).HasColumnName("ActType");
            this.Property(t => t.DrugType).HasColumnName("DrugType");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.LimitDate).HasColumnName("LimitDate");
            this.Property(t => t.ManufacturerName).HasColumnName("ManufacturerName");
        }
    }
}
