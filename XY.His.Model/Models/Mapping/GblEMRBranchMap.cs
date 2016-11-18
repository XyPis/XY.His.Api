using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblEMRBranchMap : EntityTypeConfiguration<GblEMRBranch>
    {
        public GblEMRBranchMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.XSDFile)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GblEMRBranch");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.BranchId).HasColumnName("BranchId");
            this.Property(t => t.CatalogId).HasColumnName("CatalogId");
            this.Property(t => t.XSDFile).HasColumnName("XSDFile");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasOptional(t => t.BsBranch)
                .WithMany(t => t.GblEMRBranches)
                .HasForeignKey(d => d.BranchId);
            this.HasRequired(t => t.GblEMRCatalog)
                .WithMany(t => t.GblEMRBranches)
                .HasForeignKey(d => d.CatalogId);

        }
    }
}
