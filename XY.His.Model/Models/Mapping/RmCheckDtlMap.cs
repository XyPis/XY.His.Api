using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RmCheckDtlMap : EntityTypeConfiguration<RmCheckDtl>
    {
        public RmCheckDtlMap()
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

            this.Property(t => t.F5)
                .HasMaxLength(100);

            this.Property(t => t.F6)
                .HasMaxLength(100);

            this.Property(t => t.F7)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("RmCheckDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CheckId).HasColumnName("CheckId");
            this.Property(t => t.InBatchId).HasColumnName("InBatchId");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.BalanceNum).HasColumnName("BalanceNum");
            this.Property(t => t.StockNum).HasColumnName("StockNum");
            this.Property(t => t.InstoreNum).HasColumnName("InstoreNum");
            this.Property(t => t.CheckNum).HasColumnName("CheckNum");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.StockPrice).HasColumnName("StockPrice");
            this.Property(t => t.RetailPrice).HasColumnName("RetailPrice");
            this.Property(t => t.compare).HasColumnName("compare");
            this.Property(t => t.balance).HasColumnName("balance");
            this.Property(t => t.isAdjust).HasColumnName("isAdjust");
            this.Property(t => t.ApplyIn).HasColumnName("ApplyIn");
            this.Property(t => t.MzBackIn).HasColumnName("MzBackIn");
            this.Property(t => t.ZyBackIn).HasColumnName("ZyBackIn");
            this.Property(t => t.MoveIn).HasColumnName("MoveIn");
            this.Property(t => t.OtherIn).HasColumnName("OtherIn");
            this.Property(t => t.MoveOut).HasColumnName("MoveOut");
            this.Property(t => t.MzOut).HasColumnName("MzOut");
            this.Property(t => t.ZyOut).HasColumnName("ZyOut");
            this.Property(t => t.LoseOut).HasColumnName("LoseOut");
            this.Property(t => t.BackOut).HasColumnName("BackOut");
            this.Property(t => t.OtherOut).HasColumnName("OtherOut");
            this.Property(t => t.AdjustAmouUp).HasColumnName("AdjustAmouUp");
            this.Property(t => t.AdjustAmouDn).HasColumnName("AdjustAmouDn");
            this.Property(t => t.RecipeOut).HasColumnName("RecipeOut");
            this.Property(t => t.KsBackIn).HasColumnName("KsBackIn");
            this.Property(t => t.KsOut).HasColumnName("KsOut");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.F5).HasColumnName("F5");
            this.Property(t => t.F6).HasColumnName("F6");
            this.Property(t => t.F7).HasColumnName("F7");

            // Relationships
            this.HasOptional(t => t.BsCompany)
                .WithMany(t => t.RmCheckDtls)
                .HasForeignKey(d => d.CompId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.RmCheckDtls)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.RmCheckDtls)
                .HasForeignKey(d => d.UnitId);
            this.HasRequired(t => t.RmCheck)
                .WithMany(t => t.RmCheckDtls)
                .HasForeignKey(d => d.CheckId);
            this.HasRequired(t => t.Rmstore)
                .WithMany(t => t.RmCheckDtls)
                .HasForeignKey(d => d.InBatchId);

        }
    }
}
