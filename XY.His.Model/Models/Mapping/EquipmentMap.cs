using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class EquipmentMap : EntityTypeConfiguration<Equipment>
    {
        public EquipmentMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CODE)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PyCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.Spec)
                .HasMaxLength(50);

            this.Property(t => t.EqType)
                .HasMaxLength(50);

            this.Property(t => t.SeriesNo)
                .HasMaxLength(50);

            this.Property(t => t.Brand)
                .HasMaxLength(50);

            this.Property(t => t.RepairBy)
                .HasMaxLength(50);

            this.Property(t => t.InActiveReason)
                .HasMaxLength(50);

            this.Property(t => t.LotNo)
                .HasMaxLength(50);

            this.Property(t => t.StoreIn)
                .HasMaxLength(50);

            this.Property(t => t.Manager)
                .HasMaxLength(50);

            this.Property(t => t.Attachment)
                .HasMaxLength(1000);

            this.Property(t => t.UseArea)
                .HasMaxLength(50);

            this.Property(t => t.UseMemo)
                .HasMaxLength(1000);

            this.Property(t => t.Memo)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.VoucherNo)
                .HasMaxLength(50);

            this.Property(t => t.ProduceArea)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Equipment");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CODE).HasColumnName("CODE");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.EqType).HasColumnName("EqType");
            this.Property(t => t.SeriesNo).HasColumnName("SeriesNo");
            this.Property(t => t.Brand).HasColumnName("Brand");
            this.Property(t => t.CountryId).HasColumnName("CountryId");
            this.Property(t => t.ManuId).HasColumnName("ManuId");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.RepairBy).HasColumnName("RepairBy");
            this.Property(t => t.BuyDate).HasColumnName("BuyDate");
            this.Property(t => t.StartDate).HasColumnName("StartDate");
            this.Property(t => t.LimitYears).HasColumnName("LimitYears");
            this.Property(t => t.MnrgLocId).HasColumnName("MnrgLocId");
            this.Property(t => t.UseLocId).HasColumnName("UseLocId");
            this.Property(t => t.LsQuaClass).HasColumnName("LsQuaClass");
            this.Property(t => t.LsEqClass).HasColumnName("LsEqClass");
            this.Property(t => t.InActiveReason).HasColumnName("InActiveReason");
            this.Property(t => t.InActiveTime).HasColumnName("InActiveTime");
            this.Property(t => t.InActiveOperID).HasColumnName("InActiveOperID");
            this.Property(t => t.LotNo).HasColumnName("LotNo");
            this.Property(t => t.StoreIn).HasColumnName("StoreIn");
            this.Property(t => t.Manager).HasColumnName("Manager");
            this.Property(t => t.LsEqStatus).HasColumnName("LsEqStatus");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.HowMany).HasColumnName("HowMany");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.MonthDisc).HasColumnName("MonthDisc");
            this.Property(t => t.LsMoneyFrom).HasColumnName("LsMoneyFrom");
            this.Property(t => t.MoneyGiven).HasColumnName("MoneyGiven");
            this.Property(t => t.MoneySelf).HasColumnName("MoneySelf");
            this.Property(t => t.UnderLine).HasColumnName("UnderLine");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.CostPercent).HasColumnName("CostPercent");
            this.Property(t => t.AlarmLine).HasColumnName("AlarmLine");
            this.Property(t => t.IsCalProfit).HasColumnName("IsCalProfit");
            this.Property(t => t.Attachment).HasColumnName("Attachment");
            this.Property(t => t.UseArea).HasColumnName("UseArea");
            this.Property(t => t.UseMemo).HasColumnName("UseMemo");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.LsEqType).HasColumnName("LsEqType");
            this.Property(t => t.GroupSubId).HasColumnName("GroupSubId");
            this.Property(t => t.CopyId).HasColumnName("CopyId");
            this.Property(t => t.VoucherNo).HasColumnName("VoucherNo");
            this.Property(t => t.ProduceArea).HasColumnName("ProduceArea");

            // Relationships
            this.HasOptional(t => t.BsCompany)
                .WithMany(t => t.Equipments)
                .HasForeignKey(d => d.CompId);
            this.HasOptional(t => t.BsCountry)
                .WithMany(t => t.Equipments)
                .HasForeignKey(d => d.CountryId);
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.Equipments)
                .HasForeignKey(d => d.MnrgLocId);
            this.HasOptional(t => t.BsLocation1)
                .WithMany(t => t.Equipments1)
                .HasForeignKey(d => d.UseLocId);
            this.HasOptional(t => t.BsManufacturer)
                .WithMany(t => t.Equipments)
                .HasForeignKey(d => d.ManuId);
            this.HasOptional(t => t.BsUnit)
                .WithMany(t => t.Equipments)
                .HasForeignKey(d => d.UnitId);
            this.HasOptional(t => t.BsUser)
                .WithMany(t => t.Equipments)
                .HasForeignKey(d => d.InActiveOperID);

        }
    }
}
