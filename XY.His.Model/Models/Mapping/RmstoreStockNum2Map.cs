using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RmstoreStockNum2Map : EntityTypeConfiguration<RmstoreStockNum2>
    {
        public RmstoreStockNum2Map()
        {
            // Primary Key
            this.HasKey(t => new { t.opertime, t.HospitalId, t.LsRoomType, t.LsInOut, t.ItemId });

            // Properties
            this.Property(t => t.HospitalId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsRoomType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsInOut)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ItemId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RmstoreStockNum2");
            this.Property(t => t.opertime).HasColumnName("opertime");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.LsRoomType).HasColumnName("LsRoomType");
            this.Property(t => t.LsInOut).HasColumnName("LsInOut");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.StockNum).HasColumnName("StockNum");
        }
    }
}
