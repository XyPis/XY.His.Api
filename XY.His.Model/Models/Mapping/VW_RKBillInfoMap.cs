using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VW_RKBillInfoMap : EntityTypeConfiguration<VW_RKBillInfo>
    {
        public VW_RKBillInfoMap()
        {
            // Primary Key
            this.HasKey(t => new { t.BillNo, t.OperTime, t.IsSign, t.BillId, t.HouseId, t.CompId, t.OperId });

            // Properties
            this.Property(t => t.VoucherNo)
                .HasMaxLength(50);

            this.Property(t => t.PNo)
                .HasMaxLength(20);

            this.Property(t => t.ItemCode)
                .HasMaxLength(20);

            this.Property(t => t.ItemName)
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.ManufactureryName)
                .HasMaxLength(50);

            this.Property(t => t.UnitName)
                .HasMaxLength(50);

            this.Property(t => t.BillNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.InBatchNo)
                .HasMaxLength(14);

            this.Property(t => t.BillId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.HouseId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CompId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.OperId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VW_RKBillInfo");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.VoucherNo).HasColumnName("VoucherNo");
            this.Property(t => t.PNo).HasColumnName("PNo");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.ManufactureryName).HasColumnName("ManufactureryName");
            this.Property(t => t.DrugNum).HasColumnName("DrugNum");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.TotalPrice).HasColumnName("TotalPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.TotalRetail).HasColumnName("TotalRetail");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.LimitDate).HasColumnName("LimitDate");
            this.Property(t => t.BillNo).HasColumnName("BillNo");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.SignTime).HasColumnName("SignTime");
            this.Property(t => t.IsSign).HasColumnName("IsSign");
            this.Property(t => t.InBatchNo).HasColumnName("InBatchNo");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.SignOperId).HasColumnName("SignOperId");
        }
    }
}
