using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class OuRecipeBackMap : EntityTypeConfiguration<OuRecipeBack>
    {
        public OuRecipeBackMap()
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
            this.ToTable("OuRecipeBack");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ReqDtlId).HasColumnName("ReqDtlId");
            this.Property(t => t.Totality).HasColumnName("Totality");
            this.Property(t => t.UnitId).HasColumnName("UnitId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperId).HasColumnName("OperId");
            this.Property(t => t.DetailId).HasColumnName("DetailId");
            this.Property(t => t.IsCharged).HasColumnName("IsCharged");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsUnit)
                .WithMany(t => t.OuRecipeBacks)
                .HasForeignKey(d => d.UnitId);

        }
    }
}
