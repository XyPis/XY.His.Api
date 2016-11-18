using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class GblReportDetailMap : EntityTypeConfiguration<GblReportDetail>
    {
        public GblReportDetailMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("GblReportDetail");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.FeeId).HasColumnName("FeeId");

            // Relationships
            this.HasRequired(t => t.GblReportGroup)
                .WithMany(t => t.GblReportDetails)
                .HasForeignKey(d => d.GroupId);

        }
    }
}
