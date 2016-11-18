using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwRmStoreLogMap : EntityTypeConfiguration<VwRmStoreLog>
    {
        public VwRmStoreLogMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.HappenTime, t.RoomId, t.RoomName, t.ItemId, t.ItemName, t.Spec, t.InBatchId, t.InBatchNo, t.BeforeStockNum, t.HappenNum, t.AfterStockNum, t.Code, t.UnitId, t.BillNo, t.ActType, t.DrugType, t.RmUnitId, t.Memo, t.Time_Begin, t.Time_End, t.isjy });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

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

            this.Property(t => t.BeforeStockNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HappenNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AfterStockNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.UnitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperUnitName)
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

            this.Property(t => t.RmUnitId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RmUnitName)
                .HasMaxLength(50);

            this.Property(t => t.Memo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.isjy)
                .IsRequired()
                .HasMaxLength(2);

            // Table & Column Mappings
            this.ToTable("VwRmStoreLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HappenTime).HasColumnName("HappenTime");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.RoomName).HasColumnName("RoomName");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.InBatchId).HasColumnName("InBatchId");
            this.Property(t => t.InBatchNo).HasColumnName("InBatchNo");
            this.Property(t => t.PNo).HasColumnName("PNo");
            this.Property(t => t.BeforeStockNum).HasColumnName("BeforeStockNum");
            this.Property(t => t.HappenNum).HasColumnName("HappenNum");
            this.Property(t => t.AfterStockNum).HasColumnName("AfterStockNum");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.LimitDate).HasColumnName("LimitDate");
            this.Property(t => t.StockPriceAmount).HasColumnName("StockPriceAmount");
            this.Property(t => t.RetailPriceAmount).HasColumnName("RetailPriceAmount");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.OperUnitName).HasColumnName("OperUnitName");
            this.Property(t => t.IsSpecial).HasColumnName("IsSpecial");
            this.Property(t => t.IsExpen).HasColumnName("IsExpen");
            this.Property(t => t.LsImport).HasColumnName("LsImport");
            this.Property(t => t.LsImportName).HasColumnName("LsImportName");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.LsActType).HasColumnName("LsActType");
            this.Property(t => t.ActType).HasColumnName("ActType");
            this.Property(t => t.DrugType).HasColumnName("DrugType");
            this.Property(t => t.RmUnitId).HasColumnName("RmUnitId");
            this.Property(t => t.RmUnitName).HasColumnName("RmUnitName");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.Time_Begin).HasColumnName("Time_Begin");
            this.Property(t => t.Time_End).HasColumnName("Time_End");
            this.Property(t => t.isjy).HasColumnName("isjy");
        }
    }
}
