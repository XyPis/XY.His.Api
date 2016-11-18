using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RmStoreLogMap : EntityTypeConfiguration<RmStoreLog>
    {
        public RmStoreLogMap()
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
            this.ToTable("RmStoreLog");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HappenTime).HasColumnName("HappenTime");
            this.Property(t => t.RoomId).HasColumnName("RoomId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.InBatchId).HasColumnName("InBatchId");
            this.Property(t => t.BeforeStockNum).HasColumnName("BeforeStockNum");
            this.Property(t => t.HappenNum).HasColumnName("HappenNum");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.LsActType).HasColumnName("LsActType");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.AfterStockNum).HasColumnName("AfterStockNum");

            // Relationships
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.RmStoreLogs)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsRoom)
                .WithMany(t => t.RmStoreLogs)
                .HasForeignKey(d => d.RoomId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.RmStoreLogs)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.Rmstore)
                .WithMany(t => t.RmStoreLogs)
                .HasForeignKey(d => d.InBatchId);

        }
    }
}
