using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InEmrRtfMap : EntityTypeConfiguration<InEmrRtf>
    {
        public InEmrRtfMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.F1)
                .HasMaxLength(50);

            this.Property(t => t.F2)
                .HasMaxLength(50);

            this.Property(t => t.F3)
                .HasMaxLength(50);

            this.Property(t => t.F4)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("InEmrRtf");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.HospId).HasColumnName("HospId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.CatalogId).HasColumnName("CatalogId");
            this.Property(t => t.Rtf).HasColumnName("Rtf");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.GblEMRCatalog)
                .WithMany(t => t.InEmrRtfs)
                .HasForeignKey(d => d.CatalogId);
            this.HasRequired(t => t.InHosInfo)
                .WithMany(t => t.InEmrRtfs)
                .HasForeignKey(d => d.HospId);

        }
    }
}
