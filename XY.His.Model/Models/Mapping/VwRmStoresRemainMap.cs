using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwRmStoresRemainMap : EntityTypeConfiguration<VwRmStoresRemain>
    {
        public VwRmStoresRemainMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.InBatchNo, t.ItemId, t.RoomId, t.RoomName, t.UnitName, t.CompanyName, t.StockPrice, t.RetailPrice, t.StockNum, t.InstoreNum, t.ItemName, t.HouseId, t.Spec });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InBatchNo)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PNo)
                .HasMaxLength(20);

            this.Property(t => t.UnitName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CompanyName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.StockPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RetailPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StockNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InstoreNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.HouseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("VwRmStoresRemain");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InBatchNo).HasColumnName("InBatchNo");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.RoomName).HasColumnName("RoomName");
            this.Property(t => t.PNo).HasColumnName("PNo");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.StockNum).HasColumnName("StockNum");
            this.Property(t => t.InstoreNum).HasColumnName("InstoreNum");
            this.Property(t => t.StoreDate).HasColumnName("StoreDate");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.RemainNum).HasColumnName("RemainNum");
            this.Property(t => t.RemainPercent).HasColumnName("RemainPercent");
            this.Property(t => t.StoreDays).HasColumnName("StoreDays");
            this.Property(t => t.LimitDays).HasColumnName("LimitDays");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.LimitDate).HasColumnName("LimitDate");
            this.Property(t => t.Spec).HasColumnName("Spec");
        }
    }
}
