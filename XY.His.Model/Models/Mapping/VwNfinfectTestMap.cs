using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwNfinfectTestMap : EntityTypeConfiguration<VwNfinfectTest>
    {
        public VwNfinfectTestMap()
        {
            // Primary Key
            this.HasKey(t => new { t.TestId, t.InfectId, t.LabNo, t.LabTime });

            // Properties
            this.Property(t => t.TestId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.InfectId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LabNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.LsResultName)
                .HasMaxLength(6);

            this.Property(t => t.Bacteria)
                .HasMaxLength(50);

            this.Property(t => t.BaseDrugTest)
                .HasMaxLength(50);

            this.Property(t => t.LabSource)
                .HasMaxLength(50);

            this.Property(t => t.BacteriaGrams)
                .HasMaxLength(20);

            this.Property(t => t.BacteriaShu)
                .HasMaxLength(30);

            this.Property(t => t.BacteriaType)
                .HasMaxLength(20);

            this.Property(t => t.BacteriaStandType)
                .HasMaxLength(20);

            // Table & Column Mappings
            this.ToTable("VwNfinfectTest");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.InfectId).HasColumnName("InfectId");
            this.Property(t => t.LabNo).HasColumnName("LabNo");
            this.Property(t => t.LsResultName).HasColumnName("LsResultName");
            this.Property(t => t.LabTime).HasColumnName("LabTime");
            this.Property(t => t.Bacteria).HasColumnName("Bacteria");
            this.Property(t => t.BaseDrugTest).HasColumnName("BaseDrugTest");
            this.Property(t => t.LabSource).HasColumnName("LabSource");
            this.Property(t => t.BacteriaGrams).HasColumnName("BacteriaGrams");
            this.Property(t => t.BacteriaShu).HasColumnName("BacteriaShu");
            this.Property(t => t.BacteriaType).HasColumnName("BacteriaType");
            this.Property(t => t.BacteriaStandType).HasColumnName("BacteriaStandType");
        }
    }
}
