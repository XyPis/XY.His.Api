using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkCompanyGroupMap : EntityTypeConfiguration<CkCompanyGroup>
    {
        public CkCompanyGroupMap()
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
            this.ToTable("CkCompanyGroup");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.GroupId).HasColumnName("GroupId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.CkCompany)
                .WithMany(t => t.CkCompanyGroups)
                .HasForeignKey(d => d.CompanyId);
            this.HasRequired(t => t.CkGroup)
                .WithMany(t => t.CkCompanyGroups)
                .HasForeignKey(d => d.GroupId);

        }
    }
}
