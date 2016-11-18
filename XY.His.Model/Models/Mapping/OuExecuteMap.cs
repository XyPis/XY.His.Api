using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuExecuteMap : EntityTypeConfiguration<OuExecute>
    {
        public OuExecuteMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
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
            this.ToTable("OuExecute");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MzRegId).HasColumnName("MzRegId");
            this.Property(t => t.LsRepType).HasColumnName("LsRepType");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.RecipeId).HasColumnName("RecipeId");
            this.Property(t => t.GroupNum).HasColumnName("GroupNum");
            this.Property(t => t.NDay).HasColumnName("NDay");
            this.Property(t => t.NTime).HasColumnName("NTime");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.IsExecuted).HasColumnName("IsExecuted");

            // Relationships
            this.HasRequired(t => t.BsUsage)
                .WithMany(t => t.OuExecutes)
                .HasForeignKey(d => d.UsageId);
            this.HasRequired(t => t.OuRecipe)
                .WithMany(t => t.OuExecutes)
                .HasForeignKey(d => d.RecipeId);
            this.HasRequired(t => t.OuHosInfo)
                .WithMany(t => t.OuExecutes)
                .HasForeignKey(d => d.MzRegId);

        }
    }
}
