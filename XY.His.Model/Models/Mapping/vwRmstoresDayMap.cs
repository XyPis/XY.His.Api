using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class vwRmstoresDayMap : EntityTypeConfiguration<vwRmstoresDay>
    {
        public vwRmstoresDayMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.RoomId, t.UnitName, t.Spec, t.ItemCode, t.ItemName, t.ItemId, t.RoomName, t.IsSpecSum, t.OptionPrice, t.IsDrug });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RoomName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.IsDrug)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("vwRmstoresDays");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.RoomName).HasColumnName("RoomName");
            this.Property(t => t.StockTime).HasColumnName("StockTime");
            this.Property(t => t.StockNum).HasColumnName("StockNum");
            this.Property(t => t.StockAmount).HasColumnName("StockAmount");
            this.Property(t => t.RetailAmount).HasColumnName("RetailAmount");
            this.Property(t => t.IsAntiBacterial).HasColumnName("IsAntiBacterial");
            this.Property(t => t.IsSpecSum).HasColumnName("IsSpecSum");
            this.Property(t => t.OptionPrice).HasColumnName("OptionPrice");
            this.Property(t => t.IsDrug).HasColumnName("IsDrug");
        }
    }
}
