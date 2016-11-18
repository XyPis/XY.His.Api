using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class InGfReportMap : EntityTypeConfiguration<InGfReport>
    {
        public InGfReportMap()
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
            this.ToTable("InGfReport");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TallyGroupId).HasColumnName("TallyGroupId");
            this.Property(t => t.LsReportFee).HasColumnName("LsReportFee");
            this.Property(t => t.ReportJz).HasColumnName("ReportJz");
            this.Property(t => t.ReportBx).HasColumnName("ReportBx");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsTallyGroup)
                .WithMany(t => t.InGfReports)
                .HasForeignKey(d => d.TallyGroupId);

        }
    }
}
