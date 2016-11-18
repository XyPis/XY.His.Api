using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_DI_ClincDiagMap : EntityTypeConfiguration<Vw_DI_ClincDiag>
    {
        public Vw_DI_ClincDiagMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MzRegNo, t.IllDesc });

            // Properties
            this.Property(t => t.MzRegNo)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.IllDesc)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Code)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("Vw_DI_ClincDiag");
            this.Property(t => t.MzRegNo).HasColumnName("MzRegNo");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.Code).HasColumnName("Code");
        }
    }
}
