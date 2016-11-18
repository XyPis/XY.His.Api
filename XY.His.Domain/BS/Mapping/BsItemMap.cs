using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Domain.BS.Mapping
{
    public class BsItemMap : EntityTypeConfiguration<BsItem>
    {
        public BsItemMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.WbCode)
                .HasMaxLength(20);

            this.Property(t => t.PyCode)
                .HasMaxLength(20);

            this.Property(t => t.StrokeCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.OtherCode)
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

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.CoverPicture)
                .HasMaxLength(200);

            this.Property(t => t.MemoPicture)
                .HasMaxLength(200);

            this.Property(t => t.Memo)
                .HasMaxLength(3000);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.PackageSpec)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsItem");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LsGroupType).HasColumnName("LsGroupType");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.StrokeCode).HasColumnName("StrokeCode");
            this.Property(t => t.OtherCode).HasColumnName("OtherCode");
            this.Property(t => t.GroupMainId).HasColumnName("GroupMainId");
            this.Property(t => t.GroupSubId).HasColumnName("GroupSubId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.LongDesc).HasColumnName("LongDesc");
            this.Property(t => t.EngDesc).HasColumnName("EngDesc");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.UnitInId).HasColumnName("UnitInId");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.UnitDiagId).HasColumnName("UnitDiagId");
            this.Property(t => t.PriceDiag).HasColumnName("PriceDiag");
            this.Property(t => t.AddPercent).HasColumnName("AddPercent");
            this.Property(t => t.LsRpType).HasColumnName("LsRpType");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.FeeMzId).HasColumnName("FeeMzId");
            this.Property(t => t.FeeZyId).HasColumnName("FeeZyId");
            this.Property(t => t.LsGfType).HasColumnName("LsGfType");
            this.Property(t => t.GfFixDisc).HasColumnName("GfFixDisc");
            this.Property(t => t.OptionPrice).HasColumnName("OptionPrice");
            this.Property(t => t.LimitTotalMz).HasColumnName("LimitTotalMz");
            this.Property(t => t.LimitTotalZy).HasColumnName("LimitTotalZy");
            this.Property(t => t.TypeGFXEId).HasColumnName("TypeGFXEId");
            this.Property(t => t.IsSpecSum).HasColumnName("IsSpecSum");
            this.Property(t => t.IsNew).HasColumnName("IsNew");
            this.Property(t => t.IsOnlyForSys).HasColumnName("IsOnlyForSys");
            this.Property(t => t.IsRpForbid).HasColumnName("IsRpForbid");
            this.Property(t => t.IsChildAdd).HasColumnName("IsChildAdd");
            this.Property(t => t.IsBedFee).HasColumnName("IsBedFee");
            this.Property(t => t.IsOpsAdd).HasColumnName("IsOpsAdd");
            this.Property(t => t.LsfeeTurn).HasColumnName("LsfeeTurn");
            this.Property(t => t.LsAdviceType).HasColumnName("LsAdviceType");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.LISCode).HasColumnName("LISCode");
            this.Property(t => t.CoverPicture).HasColumnName("CoverPicture");
            this.Property(t => t.MemoPicture).HasColumnName("MemoPicture");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IconIndex).HasColumnName("IconIndex");
            this.Property(t => t.IsInoculate).HasColumnName("IsInoculate");
            this.Property(t => t.PriceHighLine).HasColumnName("PriceHighLine");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.GroupSubId2).HasColumnName("GroupSubId2");
            this.Property(t => t.LastTime).HasColumnName("LastTime");
            this.Property(t => t.PriceSub).HasColumnName("PriceSub");
            this.Property(t => t.CheckId).HasColumnName("CheckId");
            this.Property(t => t.NurseId).HasColumnName("NurseId");
            this.Property(t => t.CureId).HasColumnName("CureId");
            this.Property(t => t.DrugID).HasColumnName("DrugID");
            this.Property(t => t.CopyId).HasColumnName("CopyId");
            this.Property(t => t.MzUnitTotal).HasColumnName("MzUnitTotal");
            this.Property(t => t.ZyUnitTotal).HasColumnName("ZyUnitTotal");
            this.Property(t => t.IsMtDrug).HasColumnName("IsMtDrug");
            this.Property(t => t.PackageSpec).HasColumnName("PackageSpec");
            this.Property(t => t.IsCitySum).HasColumnName("IsCitySum");

            // Relationships
        }
    }
}
