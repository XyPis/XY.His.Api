using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwOuDiagSendDrugMap : EntityTypeConfiguration<VwOuDiagSendDrug>
    {
        public VwOuDiagSendDrugMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MzRegId, t.LsRepType, t.RecipeNum, t.RecipeTime, t.IsPriority, t.IsPend, t.Name, t.ListNum, t.GroupNum, t.Code, t.ItemName, t.Spec, t.Totality, t.UnitName, t.PriceDiag, t.UsageName, t.MzRegNo });

            // Properties
            this.Property(t => t.MzRegId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LsRepType)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RecipeNum)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(30);

            this.Property(t => t.ListNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.GroupNum)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.ItemName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Spec)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Totality)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UnitName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.PriceDiag)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.UsageName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MzRegNo)
                .IsRequired()
                .HasMaxLength(12);

            // Table & Column Mappings
            this.ToTable("VwOuDiagSendDrug");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.LsRepType).HasColumnName("LsRepType");
            this.Property(t => t.RecipeNum).HasColumnName("RecipeNum");
            this.Property(t => t.RecipeTime).HasColumnName("RecipeTime");
            this.Property(t => t.HowMany).HasColumnName("HowMany");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.IsPend).HasColumnName("IsPend");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.ItemName).HasColumnName("ItemName");
            this.Property(t => t.Spec).HasColumnName("Spec");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitName).HasColumnName("UnitName");
            this.Property(t => t.PriceDiag).HasColumnName("PriceDiag");
            this.Property(t => t.UsageName).HasColumnName("UsageName");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
        }
    }
}
