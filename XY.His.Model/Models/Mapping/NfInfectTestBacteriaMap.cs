using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class NfInfectTestBacteriaMap : EntityTypeConfiguration<NfInfectTestBacteria>
    {
        public NfInfectTestBacteriaMap()
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
            this.ToTable("NfInfectTestBacteria");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.BacteriaId).HasColumnName("BacteriaId");
            this.Property(t => t.BaseDrugId).HasColumnName("BaseDrugId");
            this.Property(t => t.LsResult).HasColumnName("LsResult");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsBacteria)
                .WithMany(t => t.NfInfectTestBacterias)
                .HasForeignKey(d => d.BacteriaId);
            this.HasOptional(t => t.BsBaseDrug)
                .WithMany(t => t.NfInfectTestBacterias)
                .HasForeignKey(d => d.BaseDrugId);
            this.HasRequired(t => t.NfInfectTest)
                .WithMany(t => t.NfInfectTestBacterias)
                .HasForeignKey(d => d.TestId);

        }
    }
}
