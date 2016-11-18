using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsItemEquipmentMap : EntityTypeConfiguration<BsItemEquipment>
    {
        public BsItemEquipmentMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.EqType)
                .HasMaxLength(50);

            this.Property(t => t.SeriesNo)
                .HasMaxLength(50);

            this.Property(t => t.Brand)
                .HasMaxLength(50);

            this.Property(t => t.RepairBy)
                .HasMaxLength(50);

            this.Property(t => t.UseArea)
                .HasMaxLength(50);

            this.Property(t => t.UseMemo)
                .HasMaxLength(1000);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsItemEquipment");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.LsEqType).HasColumnName("LsEqType");
            this.Property(t => t.EqTypeId).HasColumnName("EqTypeId");
            this.Property(t => t.EqType).HasColumnName("EqType");
            this.Property(t => t.SeriesNo).HasColumnName("SeriesNo");
            this.Property(t => t.Brand).HasColumnName("Brand");
            this.Property(t => t.CountryId).HasColumnName("CountryId");
            this.Property(t => t.RepairBy).HasColumnName("RepairBy");
            this.Property(t => t.LimitYears).HasColumnName("LimitYears");
            this.Property(t => t.LsQuaClass).HasColumnName("LsQuaClass");
            this.Property(t => t.LsEqClass).HasColumnName("LsEqClass");
            this.Property(t => t.MonthDisc).HasColumnName("MonthDisc");
            this.Property(t => t.LsMoneyFrom).HasColumnName("LsMoneyFrom");
            this.Property(t => t.MoneyGiven).HasColumnName("MoneyGiven");
            this.Property(t => t.MoneySelf).HasColumnName("MoneySelf");
            this.Property(t => t.UnderLine).HasColumnName("UnderLine");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.CostPercent).HasColumnName("CostPercent");
            this.Property(t => t.AlarmLine).HasColumnName("AlarmLine");
            this.Property(t => t.IsCalProfit).HasColumnName("IsCalProfit");
            this.Property(t => t.UseArea).HasColumnName("UseArea");
            this.Property(t => t.UseMemo).HasColumnName("UseMemo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");

            // Relationships
            this.HasOptional(t => t.BsEqType)
                .WithMany(t => t.BsItemEquipments)
                .HasForeignKey(d => d.EqTypeId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.BsItemEquipments)
                .HasForeignKey(d => d.ItemId);

        }
    }
}
