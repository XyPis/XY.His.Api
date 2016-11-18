using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwBsItemMiniMap : EntityTypeConfiguration<VwBsItemMini>
    {
        public VwBsItemMiniMap()
        {
            // Primary Key
            this.HasKey(t => new { t.ID, t.Code, t.WbCode, t.PyCode, t.StrokeCode, t.IsActive, t.LongDesc, t.EngDesc, t.Spec, t.Name, t.LsGfType, t.IsRpForbid, t.OptionPrice, t.LsRpType, t.UnitDiagName, t.PriceIn, t.PriceDiag });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.WbCode)
                .IsRequired()
                .HasMaxLength(6);

            this.Property(t => t.PyCode)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.StrokeCode)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.OtherCode)
                .HasMaxLength(20);

            this.Property(t => t.LongDesc)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.EngDesc)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(52);

            this.Property(t => t.UnitInName)
                .HasMaxLength(50);

            this.Property(t => t.LsGfType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            this.Property(t => t.LsRpType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitDiagName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PriceIn)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PriceDiag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Memo)
                .HasMaxLength(3000);

            // Table & Column Mappings
            this.ToTable("VwBsItemMini");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.WbCode).HasColumnName("WbCode");
            this.Property(t => t.PyCode).HasColumnName("PyCode");
            this.Property(t => t.StrokeCode).HasColumnName("StrokeCode");
            this.Property(t => t.IsActive).HasColumnName("IsActive");
            this.Property(t => t.OtherCode).HasColumnName("OtherCode");
            this.Property(t => t.LongDesc).HasColumnName("LongDesc");
            this.Property(t => t.EngDesc).HasColumnName("EngDesc");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.UnitInName).HasColumnName("UnitInName");
            this.Property(t => t.LsGfType).HasColumnName("LsGfType");
            this.Property(t => t.IsRpForbid).HasColumnName("IsRpForbid");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.OptionPrice).HasColumnName("OptionPrice");
            this.Property(t => t.IsSpecial).HasColumnName("IsSpecial");
            this.Property(t => t.LsRpType).HasColumnName("LsRpType");
            this.Property(t => t.UnitDiagName).HasColumnName("UnitDiagName");
            this.Property(t => t.PriceIn).HasColumnName("PriceIn");
            this.Property(t => t.PriceDiag).HasColumnName("PriceDiag");
            this.Property(t => t.Memo).HasColumnName("Memo");
        }
    }
}
