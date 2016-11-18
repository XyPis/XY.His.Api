using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CKReportDefineMap : EntityTypeConfiguration<CKReportDefine>
    {
        public CKReportDefineMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Code)
                .IsRequired()
                .HasMaxLength(5);

            this.Property(t => t.Name)
                .HasMaxLength(200);

            // Table & Column Mappings
            this.ToTable("CKReportDefine");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Code).HasColumnName("Code");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.TestTypeID).HasColumnName("TestTypeID");
            this.Property(t => t.ReportContent).HasColumnName("ReportContent");
        }
    }
}
