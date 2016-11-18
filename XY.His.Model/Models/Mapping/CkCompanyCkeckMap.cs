using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkCompanyCkeckMap : EntityTypeConfiguration<CkCompanyCkeck>
    {
        public CkCompanyCkeckMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CkeckNo)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CkCompanyCkeck");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.CompanyId).HasColumnName("CompanyId");
            this.Property(t => t.CkeckDate).HasColumnName("CkeckDate");
            this.Property(t => t.CkeckNo).HasColumnName("CkeckNo");

            // Relationships
            this.HasRequired(t => t.CkCompany)
                .WithMany(t => t.CkCompanyCkecks)
                .HasForeignKey(d => d.CompanyId);

        }
    }
}
