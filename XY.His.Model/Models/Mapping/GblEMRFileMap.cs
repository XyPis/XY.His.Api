using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblEMRFileMap : EntityTypeConfiguration<GblEMRFile>
    {
        public GblEMRFileMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.XSDFile)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("GblEMRFile");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LocationId).HasColumnName("LocationId");
            this.Property(t => t.CatalogId).HasColumnName("CatalogId");
            this.Property(t => t.XSDFile).HasColumnName("XSDFile");

            // Relationships
            this.HasOptional(t => t.BsLocation)
                .WithMany(t => t.GblEMRFiles)
                .HasForeignKey(d => d.LocationId);
            this.HasRequired(t => t.GblEMRCatalog)
                .WithMany(t => t.GblEMRFiles)
                .HasForeignKey(d => d.CatalogId);

        }
    }
}
