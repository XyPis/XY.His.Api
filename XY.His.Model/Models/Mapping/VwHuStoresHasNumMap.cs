using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwHuStoresHasNumMap : EntityTypeConfiguration<VwHuStoresHasNum>
    {
        public VwHuStoresHasNumMap()
        {
            // Primary Key
            this.HasKey(t => new { t.StoreDate, t.PriceIn, t.PriceDiag, t.ItemId, t.InBatchNo });

            // Properties
            this.Property(t => t.PNo)
                .HasMaxLength(20);

            this.Property(t => t.PriceIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PriceDiag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InBatchNo)
                .IsRequired()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("VwHuStoresHasNum");
            this.Property(t => t.PNo).HasColumnName("PNo");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.StoreDate).HasColumnName("StoreDate");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.LimitDate).HasColumnName("LimitDate");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.PriceDiag).HasColumnName("PriceDiag");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.InBatchNo).HasColumnName("InBatchNo");
        }
    }
}
