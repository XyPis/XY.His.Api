using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkCompanyManMap : EntityTypeConfiguration<CkCompanyMan>
    {
        public CkCompanyManMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("CkCompanyMan");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CompanyGroupId).HasColumnName("CompanyGroupId");
            this.Property(t => t.PatId).HasColumnName("PatId");

            // Relationships
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.CkCompanyMen)
                .HasForeignKey(d => d.PatId);
            this.HasRequired(t => t.CkCompanyGroup)
                .WithMany(t => t.CkCompanyMen)
                .HasForeignKey(d => d.CompanyGroupId);

        }
    }
}
