using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblReportGroupMap : EntityTypeConfiguration<GblReportGroup>
    {
        public GblReportGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Name)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("GblReportGroup");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ReportId).HasColumnName("ReportId");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.OrderBy).HasColumnName("OrderBy");

            // Relationships
            this.HasRequired(t => t.GblReport)
                .WithMany(t => t.GblReportGroups)
                .HasForeignKey(d => d.ReportId);

        }
    }
}
