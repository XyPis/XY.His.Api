using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class DhStoreMap : EntityTypeConfiguration<DhStore>
    {
        public DhStoreMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.InBatchNo)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.ItemCode)
                .HasMaxLength(50);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.PassNo)
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
            this.ToTable("DhStores");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospitalId).HasColumnName("HospitalId");
            this.Property(t => t.InBatchNo).HasColumnName("InBatchNo");
            this.Property(t => t.ItemCode).HasColumnName("ItemCode");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.UnitKcId).HasColumnName("UnitKcId");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.ManuId).HasColumnName("ManuId");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.IsRecipe).HasColumnName("IsRecipe");
            this.Property(t => t.IsPoison).HasColumnName("IsPoison");
            this.Property(t => t.IsMental).HasColumnName("IsMental");
            this.Property(t => t.IsExpen).HasColumnName("IsExpen");
            this.Property(t => t.IsSelf).HasColumnName("IsSelf");
            this.Property(t => t.LsImport).HasColumnName("LsImport");
            this.Property(t => t.IsCountry).HasColumnName("IsCountry");
            this.Property(t => t.IsProvince).HasColumnName("IsProvince");
            this.Property(t => t.IsBid).HasColumnName("IsBid");
            this.Property(t => t.PassNo).HasColumnName("PassNo");
            this.Property(t => t.StockNum).HasColumnName("StockNum");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.StoreDate).HasColumnName("StoreDate");
            this.Property(t => t.ProduceDate).HasColumnName("ProduceDate");
            this.Property(t => t.LimitDate).HasColumnName("LimitDate");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsCompany)
                .WithMany(t => t.DhStores)
                .HasForeignKey(d => d.CompId);
            this.HasRequired(t => t.BsDrugForm)
                .WithMany(t => t.DhStores)
                .HasForeignKey(d => d.FormId);
            this.HasOptional(t => t.BsHospital)
                .WithMany(t => t.DhStores)
                .HasForeignKey(d => d.HospitalId);
            this.HasOptional(t => t.BsManufacturer)
                .WithMany(t => t.DhStores)
                .HasForeignKey(d => d.ManuId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.DhStores)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.BsUnit1)
                .WithMany(t => t.DhStores1)
                .HasForeignKey(d => d.UnitKcId);

        }
    }
}
