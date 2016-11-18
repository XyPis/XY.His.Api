using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class NfInfectDrugMap : EntityTypeConfiguration<NfInfectDrug>
    {
        public NfInfectDrugMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            // Table & Column Mappings
            this.ToTable("NfInfectDrug");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InfectId).HasColumnName("InfectId");
            this.Property(t => t.BaseDrugId).HasColumnName("BaseDrugId");
            this.Property(t => t.Dosage).HasColumnName("Dosage");
            this.Property(t => t.UnitTakeId).HasColumnName("UnitTakeId");
            this.Property(t => t.FrequencyId).HasColumnName("FrequencyId");
            this.Property(t => t.UsageId).HasColumnName("UsageId");
            this.Property(t => t.Days).HasColumnName("Days");

            // Relationships
            this.HasRequired(t => t.BsBaseDrug)
                .WithMany(t => t.NfInfectDrugs)
                .HasForeignKey(d => d.BaseDrugId);
            this.HasOptional(t => t.BsFrequency)
                .WithMany(t => t.NfInfectDrugs)
                .HasForeignKey(d => d.FrequencyId);
            this.HasOptional(t => t.BsUnit)
                .WithMany(t => t.NfInfectDrugs)
                .HasForeignKey(d => d.UnitTakeId);
            this.HasOptional(t => t.BsUsage)
                .WithMany(t => t.NfInfectDrugs)
                .HasForeignKey(d => d.UsageId);
            this.HasRequired(t => t.NfInfect)
                .WithMany(t => t.NfInfectDrugs)
                .HasForeignKey(d => d.InfectId);

        }
    }
}
