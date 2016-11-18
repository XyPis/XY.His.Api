using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class HuCheckDtlMap : EntityTypeConfiguration<HuCheckDtl>
    {
        public HuCheckDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.compare)
                .IsRequired()
                .IsFixedLength()
                .HasMaxLength(1);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("HuCheckDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BillId).HasColumnName("BillId");
            this.Property(t => t.InBatchId).HasColumnName("InBatchId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.BalanceNum).HasColumnName("BalanceNum");
            this.Property(t => t.StcokNum).HasColumnName("StcokNum");
            this.Property(t => t.InstoreNum).HasColumnName("InstoreNum");
            this.Property(t => t.CheckNum).HasColumnName("CheckNum");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.compare).HasColumnName("compare");
            this.Property(t => t.IsBalance).HasColumnName("IsBalance");
            this.Property(t => t.IsAdjust).HasColumnName("IsAdjust");
            this.Property(t => t.BuyIn).HasColumnName("BuyIn");
            this.Property(t => t.BackIn).HasColumnName("BackIn");
            this.Property(t => t.OtherIn).HasColumnName("OtherIn");
            this.Property(t => t.DeptOut).HasColumnName("DeptOut");
            this.Property(t => t.SaleOut).HasColumnName("SaleOut");
            this.Property(t => t.BackOut).HasColumnName("BackOut");
            this.Property(t => t.LoseOut).HasColumnName("LoseOut");
            this.Property(t => t.AdjustAmouUp).HasColumnName("AdjustAmouUp");
            this.Property(t => t.AdjustAmouDn).HasColumnName("AdjustAmouDn");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsCompany)
                .WithMany(t => t.HuCheckDtls)
                .HasForeignKey(d => d.CompId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.HuCheckDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.HuCheckDtls)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.HuCheck)
                .WithMany(t => t.HuCheckDtls)
                .HasForeignKey(d => d.BillId);
            this.HasRequired(t => t.HuStore)
                .WithMany(t => t.HuCheckDtls)
                .HasForeignKey(d => d.InBatchId);

        }
    }
}
