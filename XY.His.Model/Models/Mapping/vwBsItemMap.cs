using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class vwBsItemMap : EntityTypeConfiguration<vwBsItem>
    {
        public vwBsItemMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.LsGroupType, t.Code, t.Name, t.LongDesc, t.EngDesc, t.StrokeCode, t.GroupMainId, t.Spec, t.UnitInId, t.PriceIn, t.UnitDiagId, t.PriceDiag, t.AddPercent, t.LsRpType, t.Dosage, t.FeeMzId, t.FeeZyId, t.LsGfType, t.OptionPrice, t.LimitTotalMz, t.LimitTotalZy, t.TypeGFXEId, t.IsSpecSum, t.IsNew, t.IsOnlyForSys, t.IsRpForbid, t.IsChildAdd, t.IsBedFee, t.IsOpsAdd, t.LsfeeTurn, t.LsAdviceType, t.IsActive, t.DiscDiag, t.DiscIn, t.LocationName, t.FeeHsMzId, t.FeeHsZyId, t.FeeHsZyName, t.FeeHsMzName, t.LocationDosage, t.LocationUnitTakeName, t.LocationFrequencyName, t.LocationUsageName, t.IconIndex });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsGroupType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LongDesc)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.EngDesc)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.WbCode)
                .HasMaxLength(20);

            this.Property(t => t.PyCode)
                .HasMaxLength(20);

            this.Property(t => t.StrokeCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.OtherCode)
                .HasMaxLength(20);

            this.Property(t => t.GroupMainId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GroupName)
                .HasMaxLength(50);

            this.Property(t => t.GroupSubName)
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.UnitInId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitInName)
                .HasMaxLength(50);

            this.Property(t => t.PriceIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitDiagId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitDiagName)
                .HasMaxLength(50);

            this.Property(t => t.PriceDiag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.AddPercent)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsRpType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Dosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitTakeName)
                .HasMaxLength(50);

            this.Property(t => t.FrequencyName)
                .HasMaxLength(50);

            this.Property(t => t.FeeMzId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FeeMzName)
                .HasMaxLength(50);

            this.Property(t => t.FeeZyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FeeZyName)
                .HasMaxLength(50);

            this.Property(t => t.LsGfType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LimitTotalMz)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LimitTotalZy)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeGFXEId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TypeGFXEName)
                .HasMaxLength(50);

            this.Property(t => t.LsfeeTurn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsAdviceType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.ExecLocName)
                .HasMaxLength(30);

            this.Property(t => t.Memo)
                .HasMaxLength(3000);

            this.Property(t => t.ChemName)
                .HasMaxLength(50);

            this.Property(t => t.DrugFormName)
                .HasMaxLength(50);

            this.Property(t => t.ManufacturerName)
                .HasMaxLength(50);

            this.Property(t => t.PassNo)
                .HasMaxLength(50);

            this.Property(t => t.AreaKc)
                .HasMaxLength(50);

            this.Property(t => t.HouseName)
                .HasMaxLength(50);

            this.Property(t => t.RoomNameOut)
                .HasMaxLength(50);

            this.Property(t => t.RoomInOut)
                .HasMaxLength(50);

            this.Property(t => t.CompanyName)
                .HasMaxLength(50);

            this.Property(t => t.PatTypeName)
                .HasMaxLength(50);

            this.Property(t => t.DiscDiag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.DiscIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InvInItemName)
                .HasMaxLength(50);

            this.Property(t => t.InvMzItemName)
                .HasMaxLength(50);

            this.Property(t => t.ZyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.LocationName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.FeeHsMzId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FeeHsZyId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.FeeHsZyName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.FeeHsMzName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.LocationDosage)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LocationUnitTakeName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.LocationFrequencyName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.LocationUsageName)
                .IsRequired()
                .HasMaxLength(1);

            this.Property(t => t.UsageName)
                .HasMaxLength(50);

            this.Property(t => t.UnitKcName)
                .HasMaxLength(50);

            this.Property(t => t.TallyGroupName)
                .HasMaxLength(50);

            this.Property(t => t.IconIndex)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("vwBsItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LsGroupType).HasColumnName("LsGroupType");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LongDesc).HasColumnName("LongDesc");
            this.Property(t => t.EngDesc).HasColumnName("EngDesc");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.StrokeCode).HasColumnName("StrokeCode");
            this.Property(t => t.OtherCode).HasColumnName("OtherCode");
            this.Property(t => t.GroupMainId).HasColumnName("GroupMainId");
            this.Property(t => t.GroupName).HasColumnName("GroupName");
            this.Property(t => t.GroupSubId).HasColumnName("GroupSubId");
            this.Property(t => t.GroupSubName).HasColumnName("GroupSubName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.UnitInId).HasColumnName("UnitInId");
            this.Property(t => t.UnitInName).HasColumnName("UnitInName");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.UnitDiagId).HasColumnName("UnitDiagId");
            this.Property(t => t.UnitDiagName).HasColumnName("UnitDiagName");
            this.Property(t => t.PriceDiag).HasColumnName("PriceDiag");
            this.Property(t => t.AddPercent).HasColumnName("AddPercent");
            this.Property(t => t.LsRpType).HasColumnName("LsRpType");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.UnitTakeName).HasColumnName("UnitTakeName");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.FrequencyName).HasColumnName("FrequencyName");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.FeeMzId).HasColumnName("FeeMzId");
            this.Property(t => t.FeeMzName).HasColumnName("FeeMzName");
            this.Property(t => t.FeeZyId).HasColumnName("FeeZyId");
            this.Property(t => t.MzUnitTotal).HasColumnName("MzUnitTotal");
            this.Property(t => t.FeeZyName).HasColumnName("FeeZyName");
            this.Property(t => t.LsGfType).HasColumnName("LsGfType");
            this.Property(t => t.GfFixDisc).HasColumnName("GfFixDisc");
            this.Property(t => t.OptionPrice).HasColumnName("OptionPrice");
            this.Property(t => t.LimitTotalMz).HasColumnName("LimitTotalMz");
            this.Property(t => t.LimitTotalZy).HasColumnName("LimitTotalZy");
            this.Property(t => t.TypeGFXEId).HasColumnName("TypeGFXEId");
            this.Property(t => t.TypeGFXEName).HasColumnName("TypeGFXEName");
            this.Property(t => t.IsSpecSum).HasColumnName("IsSpecSum");
            this.Property(t => t.IsNew).HasColumnName("IsNew");
            this.Property(t => t.IsOnlyForSys).HasColumnName("IsOnlyForSys");
            this.Property(t => t.IsRpForbid).HasColumnName("IsRpForbid");
            this.Property(t => t.IsChildAdd).HasColumnName("IsChildAdd");
            this.Property(t => t.IsBedFee).HasColumnName("IsBedFee");
            this.Property(t => t.IsOpsAdd).HasColumnName("IsOpsAdd");
            this.Property(t => t.LsfeeTurn).HasColumnName("LsfeeTurn");
            this.Property(t => t.LsAdviceType).HasColumnName("LsAdviceType");
            this.Property(t => t.ExecLocId).HasColumnName("ExecLocId");
            this.Property(t => t.ExecLocName).HasColumnName("ExecLocName");
            this.Property(t => t.LISCode).HasColumnName("LISCode");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.ChemName).HasColumnName("ChemName");
            this.Property(t => t.IsRecipe).HasColumnName("IsRecipe");
            this.Property(t => t.IsPoison).HasColumnName("IsPoison");
            this.Property(t => t.IsMental).HasColumnName("IsMental");
            this.Property(t => t.IsExpen).HasColumnName("IsExpen");
            this.Property(t => t.IsSelf).HasColumnName("IsSelf");
            this.Property(t => t.ProArea).HasColumnName("ProArea");
            this.Property(t => t.AheadAlert).HasColumnName("AheadAlert");
            this.Property(t => t.UnderLineKc).HasColumnName("UnderLineKc");
            this.Property(t => t.UperLineKc).HasColumnName("UperLineKc");
            this.Property(t => t.NormalLineKc).HasColumnName("NormalLineKc");
            this.Property(t => t.FormId).HasColumnName("FormId");
            this.Property(t => t.DrugFormName).HasColumnName("DrugFormName");
            this.Property(t => t.ManuId).HasColumnName("ManuId");
            this.Property(t => t.ManufacturerName).HasColumnName("ManufacturerName");
            this.Property(t => t.PassNo).HasColumnName("PassNo");
            this.Property(t => t.AreaKc).HasColumnName("AreaKc");
            this.Property(t => t.LsImport).HasColumnName("LsImport");
            this.Property(t => t.IsInject).HasColumnName("IsInject");
            this.Property(t => t.IsSpecial).HasColumnName("IsSpecial");
            this.Property(t => t.HouseId).HasColumnName("HouseId");
            this.Property(t => t.HouseName).HasColumnName("HouseName");
            this.Property(t => t.RoomIdOut).HasColumnName("RoomIdOut");
            this.Property(t => t.RoomNameOut).HasColumnName("RoomNameOut");
            this.Property(t => t.RoomIdIn).HasColumnName("RoomIdIn");
            this.Property(t => t.RoomInOut).HasColumnName("RoomInOut");
            this.Property(t => t.UnitKc).HasColumnName("UnitKc");
            this.Property(t => t.RetailPriceKc).HasColumnName("RetailPriceKc");
            this.Property(t => t.StockPriceKc).HasColumnName("StockPriceKc");
            this.Property(t => t.IsBid).HasColumnName("IsBid");
            this.Property(t => t.IsLocDrug).HasColumnName("IsLocDrug");
            this.Property(t => t.CompId).HasColumnName("CompId");
            this.Property(t => t.CompanyName).HasColumnName("CompanyName");
            this.Property(t => t.IsBatch).HasColumnName("IsBatch");
            this.Property(t => t.IsSave).HasColumnName("IsSave");
            this.Property(t => t.PatTypeId).HasColumnName("PatTypeId");
            this.Property(t => t.PatTypeName).HasColumnName("PatTypeName");
            this.Property(t => t.DiscDiag).HasColumnName("DiscDiag");
            this.Property(t => t.DiscIn).HasColumnName("DiscIn");
            this.Property(t => t.InvInItemId).HasColumnName("InvInItemId");
            this.Property(t => t.InvInItemName).HasColumnName("InvInItemName");
            this.Property(t => t.InvMzItemId).HasColumnName("InvMzItemId");
            this.Property(t => t.InvMzItemName).HasColumnName("InvMzItemName");
            this.Property(t => t.LimitGroupId).HasColumnName("LimitGroupId");
            this.Property(t => t.ZyGroupName).HasColumnName("ZyGroupName");
            this.Property(t => t.LimitFeeMz).HasColumnName("LimitFeeMz");
            this.Property(t => t.LimitFeeZy).HasColumnName("LimitFeeZy");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LocationName).HasColumnName("LocationName");
            this.Property(t => t.FeeHsMzId).HasColumnName("FeeHsMzId");
            this.Property(t => t.FeeHsZyId).HasColumnName("FeeHsZyId");
            this.Property(t => t.FeeHsZyName).HasColumnName("FeeHsZyName");
            this.Property(t => t.FeeHsMzName).HasColumnName("FeeHsMzName");
            this.Property(t => t.LocationDosage).HasColumnName("LocationDosage");
            this.Property(t => t.LocationUnitTakeId).HasColumnName("LocationUnitTakeId");
            this.Property(t => t.LocationUnitTakeName).HasColumnName("LocationUnitTakeName");
            this.Property(t => t.LocationFrequencyId).HasColumnName("LocationFrequencyId");
            this.Property(t => t.LocationFrequencyName).HasColumnName("LocationFrequencyName");
            this.Property(t => t.LocationUsageId).HasColumnName("LocationUsageId");
            this.Property(t => t.LocationUsageName).HasColumnName("LocationUsageName");
            this.Property(t => t.UsageName).HasColumnName("UsageName");
            this.Property(t => t.UnitKcName).HasColumnName("UnitKcName");
            this.Property(t => t.TallyGroupName).HasColumnName("TallyGroupName");
            this.Property(t => t.LocationIsLocDrug).HasColumnName("LocationIsLocDrug");
            this.Property(t => t.TallyTypeId).HasColumnName("TallyTypeId");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.IsInoculate).HasColumnName("IsInoculate");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.DrugID).HasColumnName("DrugID");
        }
    }
}
