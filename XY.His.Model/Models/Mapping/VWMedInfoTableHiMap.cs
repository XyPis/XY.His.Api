using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VWMedInfoTableHiMap : EntityTypeConfiguration<VWMedInfoTableHi>
    {
        public VWMedInfoTableHiMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MedName, t.MedPack, t.MedUnitPack, t.Medunit, t.MedPYCode, t.MedFactory, t.MedUnitPrice });

            // Properties
            this.Property(t => t.MedOnlyCode)
                .HasMaxLength(10);

            this.Property(t => t.MedName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MedPack)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MedUnitPack)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.Medunit)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MedPYCode)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.MedFactory)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.MedUnitPrice)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VWMedInfoTableHis");
            this.Property(t => t.MedOnlyCode).HasColumnName("MedOnlyCode");
            this.Property(t => t.MedName).HasColumnName("MedName");
            this.Property(t => t.MedPack).HasColumnName("MedPack");
            this.Property(t => t.MedUnitPack).HasColumnName("MedUnitPack");
            this.Property(t => t.Medunit).HasColumnName("Medunit");
            this.Property(t => t.MedConvercof).HasColumnName("MedConvercof");
            this.Property(t => t.MedPYCode).HasColumnName("MedPYCode");
            this.Property(t => t.MedFactory).HasColumnName("MedFactory");
            this.Property(t => t.MedUnitPrice).HasColumnName("MedUnitPrice");
        }
    }
}
