using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuRecipeChinMap : EntityTypeConfiguration<OuRecipeChin>
    {
        public OuRecipeChinMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OuRecipeChin");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.RecipeId).HasColumnName("RecipeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.DecoctNum).HasColumnName("DecoctNum");
            this.Property(t => t.LsCookSelf).HasColumnName("LsCookSelf");
            this.Property(t => t.CookMinute).HasColumnName("CookMinute");
            this.Property(t => t.LsFire).HasColumnName("LsFire");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsFrequency)
                .WithMany(t => t.OuRecipeChins)
                .HasForeignKey(d => d.FrequencyId);
            this.HasOptional(t => t.BsUsage)
                .WithMany(t => t.OuRecipeChins)
                .HasForeignKey(d => d.UsageId);
            this.HasRequired(t => t.OuRecipe)
                .WithMany(t => t.OuRecipeChins)
                .HasForeignKey(d => d.RecipeId);

        }
    }
}
