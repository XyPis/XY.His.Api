using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblCatalogJoinMap : EntityTypeConfiguration<GblCatalogJoin>
    {
        public GblCatalogJoinMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.XmlField1)
                .HasMaxLength(500);

            this.Property(t => t.XmlField2)
                .HasMaxLength(500);

            this.Property(t => t.F1)
                .HasMaxLength(50);

            this.Property(t => t.F2)
                .HasMaxLength(50);

            this.Property(t => t.F3)
                .HasMaxLength(50);

            this.Property(t => t.F4)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GblCatalogJoin");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CatalogId1).HasColumnName("CatalogId1");
            this.Property(t => t.XmlField1).HasColumnName("XmlField1");
            this.Property(t => t.CatalogId2).HasColumnName("CatalogId2");
            this.Property(t => t.XmlField2).HasColumnName("XmlField2");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.GblEMRCatalog)
                .WithMany(t => t.GblCatalogJoins)
                .HasForeignKey(d => d.CatalogId1);
            this.HasRequired(t => t.GblEMRCatalog1)
                .WithMany(t => t.GblCatalogJoins1)
                .HasForeignKey(d => d.CatalogId2);

        }
    }
}
