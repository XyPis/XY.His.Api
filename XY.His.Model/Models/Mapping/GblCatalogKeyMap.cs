using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblCatalogKeyMap : EntityTypeConfiguration<GblCatalogKey>
    {
        public GblCatalogKeyMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.XmlField)
                .HasMaxLength(50);

            this.Property(t => t.KeyFile)
                .HasMaxLength(100);

            this.Property(t => t.TmpWord)
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
            this.ToTable("GblCatalogKey");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CatalogId).HasColumnName("CatalogId");
            this.Property(t => t.XmlField).HasColumnName("XmlField");
            this.Property(t => t.KeyFile).HasColumnName("KeyFile");
            this.Property(t => t.TmpWord).HasColumnName("TmpWord");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.GblEMRCatalog)
                .WithMany(t => t.GblCatalogKeys)
                .HasForeignKey(d => d.CatalogId);

        }
    }
}
