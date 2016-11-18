using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class NfInfectTestMap : EntityTypeConfiguration<NfInfectTest>
    {
        public NfInfectTestMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.LabNo)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("NfInfectTest");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.InfectId).HasColumnName("InfectId");
            this.Property(t => t.LabNo).HasColumnName("LabNo");
            this.Property(t => t.SourceId).HasColumnName("SourceId");
            this.Property(t => t.LabTime).HasColumnName("LabTime");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsLabSource)
                .WithMany(t => t.NfInfectTests)
                .HasForeignKey(d => d.SourceId);
            this.HasRequired(t => t.NfInfect)
                .WithMany(t => t.NfInfectTests)
                .HasForeignKey(d => d.InfectId);

        }
    }
}
