using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RmstoresDayMap : EntityTypeConfiguration<RmstoresDay>
    {
        public RmstoresDayMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.StockTime, t.StockID, t.RoomId, t.ItemId, t.unitid, t.StockPrice, t.RetailPrice, t.StockNum, t.IsBid, t.IsInject, t.OptionPrice, t.IsSpecSum, t.IsAntiBacterial });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.StockID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.unitid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StockPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RetailPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StockNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RmstoresDays");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.StockTime).HasColumnName("StockTime");
            this.Property(t => t.StockID).HasColumnName("StockID");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.unitid).HasColumnName("unitid");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.StockNum).HasColumnName("StockNum");
            this.Property(t => t.IsBid).HasColumnName("IsBid");
            this.Property(t => t.IsInject).HasColumnName("IsInject");
            this.Property(t => t.OptionPrice).HasColumnName("OptionPrice");
            this.Property(t => t.IsSpecSum).HasColumnName("IsSpecSum");
            this.Property(t => t.IsAntiBacterial).HasColumnName("IsAntiBacterial");
        }
    }
}
