using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsItemDrugMap : EntityTypeConfiguration<BsItemDrug>
    {
        public BsItemDrugMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.ChemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PassNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.AreaKc)
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

            this.Property(t => t.BuyInCode)
                .HasMaxLength(100);

            this.Property(t => t.RegNo)
                .HasMaxLength(50);

            this.Property(t => t.ImpotTestBy)
                .HasMaxLength(50);

            this.Property(t => t.TestReportNo)
                .HasMaxLength(50);

            this.Property(t => t.DDDMinValue)
                .HasMaxLength(50);

            this.Property(t => t.DDDValue)
                .HasMaxLength(50);

            this.Property(t => t.DrugsTypes)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("BsItemDrug");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ItemId).HasColumnName("ItemId");
            this.Property(t => t.ChemName).HasColumnName("ChemName");
            this.Property(t => t.IsRecipe).HasColumnName("IsRecipe");
            this.Property(t => t.IsPoison).HasColumnName("IsPoison");
            this.Property(t => t.IsMental).HasColumnName("IsMental");
            this.Property(t => t.IsExpen).HasColumnName("IsExpen");
            this.Property(t => t.IsSelf).HasColumnName("IsSelf");
            this.Property(t => t.ProAreaId).HasColumnName("ProAreaId");
            this.Property(t => t.AheadAlert).HasColumnName("AheadAlert");
            this.Property(t => t.UnderLineKc).HasColumnName("UnderLineKc");
            this.Property(t => t.UperLineKc).HasColumnName("UperLineKc");
            this.Property(t => t.NormalLineKc).HasColumnName("NormalLineKc");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.ManuId).HasColumnName("ManuId");
            this.Property(t => t.PassNo).HasColumnName("PassNo");
            this.Property(t => t.AreaKc).HasColumnName("AreaKc");
            this.Property(t => t.LsImport).HasColumnName("LsImport");
            this.Property(t => t.IsInject).HasColumnName("IsInject");
            this.Property(t => t.IsSpecial).HasColumnName("IsSpecial");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.RoomIdOut).HasColumnName("RoomIdOut");
            this.Property(t => t.RoomIdIn).HasColumnName("RoomIdIn");
            this.Property(t => t.UnitKc).HasColumnName("UnitKc");
            this.Property(t => t.RetailPriceKc).HasColumnName("RetailPriceKc");
            this.Property(t => t.StockPriceKc).HasColumnName("StockPriceKc");
            this.Property(t => t.IsBid).HasColumnName("IsBid");
            this.Property(t => t.IsLocDrug).HasColumnName("IsLocDrug");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.IsBatch).HasColumnName("IsBatch");
            this.Property(t => t.IsSave).HasColumnName("IsSave");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.DrugID).HasColumnName("DrugID");
            this.Property(t => t.BuyInCode).HasColumnName("BuyInCode");
            this.Property(t => t.IsSecMental).HasColumnName("IsSecMental");
            this.Property(t => t.IsSkin).HasColumnName("IsSkin");
            this.Property(t => t.IsAntiBacterial).HasColumnName("IsAntiBacterial");
            this.Property(t => t.IsHighDanger).HasColumnName("IsHighDanger");
            this.Property(t => t.IsDanger).HasColumnName("IsDanger");
            this.Property(t => t.IsVaccine).HasColumnName("IsVaccine");
            this.Property(t => t.IsTestReport).HasColumnName("IsTestReport");
            this.Property(t => t.IsAnaes).HasColumnName("IsAnaes");
            this.Property(t => t.IsMeetingUse).HasColumnName("IsMeetingUse");
            this.Property(t => t.RegNo).HasColumnName("RegNo");
            this.Property(t => t.ImpotTestBy).HasColumnName("ImpotTestBy");
            this.Property(t => t.TestReportNo).HasColumnName("TestReportNo");
            this.Property(t => t.IsParity).HasColumnName("IsParity");
            this.Property(t => t.DDDMinValue).HasColumnName("DDDMinValue");
            this.Property(t => t.DDDValue).HasColumnName("DDDValue");
            this.Property(t => t.DrugsTypes).HasColumnName("DrugsTypes");
            this.Property(t => t.NotXZjDrug).HasColumnName("NotXZjDrug");
            this.Property(t => t.XZjDrug).HasColumnName("XZjDrug");
            this.Property(t => t.TSjDrug).HasColumnName("TSjDrug");
            this.Property(t => t.IsAz).HasColumnName("IsAz");
            this.Property(t => t.IsJH).HasColumnName("IsJH");

            // Relationships
            this.HasOptional(t => t.BsBaseDrug)
                .WithMany(t => t.BsItemDrugs)
                .HasForeignKey(d => d.DrugID);
            this.HasOptional(t => t.BsCompany)
                .WithMany(t => t.BsItemDrugs)
                .HasForeignKey(d => d.CompId);
            this.HasRequired(t => t.BsDrugForm)
                .WithMany(t => t.BsItemDrugs)
                .HasForeignKey(d => d.FormId);
            this.HasRequired(t => t.BsHouse)
                .WithMany(t => t.BsItemDrugs)
                .HasForeignKey(d => d.HouseId);
            this.HasRequired(t => t.BsItem)
                .WithMany(t => t.BsItemDrugs)
                .HasForeignKey(d => d.ItemId);
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.BsItemDrugs)
                .HasForeignKey(d => d.UnitKc);
            this.HasOptional(t => t.BsManufacturer)
                .WithMany(t => t.BsItemDrugs)
                .HasForeignKey(d => d.ManuId);
            this.HasRequired(t => t.BsRoom)
                .WithMany(t => t.BsItemDrugs)
                .HasForeignKey(d => d.RoomIdOut);
            this.HasRequired(t => t.BsRoom1)
                .WithMany(t => t.BsItemDrugs1)
                .HasForeignKey(d => d.RoomIdIn);

        }
    }
}
