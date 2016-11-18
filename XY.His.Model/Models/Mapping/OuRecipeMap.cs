using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuRecipeMap : EntityTypeConfiguration<OuRecipe>
    {
        public OuRecipeMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.RecipeNum)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.Memo)
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("OuRecipe");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.LsRepType).HasColumnName("LsRepType");
            this.Property(t => t.RecipeNum).HasColumnName("RecipeNum");
            this.Property(t => t.RecipeTime).HasColumnName("RecipeTime");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.DoctorId).HasColumnName("DoctorId");
            this.Property(t => t.HowMany).HasColumnName("HowMany");
            this.Property(t => t.IsPriority).HasColumnName("IsPriority");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.IsPend).HasColumnName("IsPend");
            this.Property(t => t.IsExecuted).HasColumnName("IsExecuted");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.IsDosage).HasColumnName("IsDosage");
            this.Property(t => t.DosageOperId).HasColumnName("DosageOperId");
            this.Property(t => t.DosageTime).HasColumnName("DosageTime");

            // Relationships
            this.HasRequired(t => t.BsDoctor)
                .WithMany(t => t.OuRecipes)
                .HasForeignKey(d => d.DoctorId);
            this.HasRequired(t => t.BsLocation)
                .WithMany(t => t.OuRecipes)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.OuHosInfo)
                .WithMany(t => t.OuRecipes)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
