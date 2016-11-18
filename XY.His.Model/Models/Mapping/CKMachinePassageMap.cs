using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CKMachinePassageMap : EntityTypeConfiguration<CKMachinePassage>
    {
        public CKMachinePassageMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.PassAgeNum)
                .IsRequired()
                .HasMaxLength(20);

            this.Property(t => t.F1)
                .HasMaxLength(50);

            this.Property(t => t.F2)
                .HasMaxLength(50);

            this.Property(t => t.F3)
                .HasMaxLength(50);

            this.Property(t => t.F4)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("CKMachinePassage");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.TestID).HasColumnName("TestID");
            this.Property(t => t.PassAgeNum).HasColumnName("PassAgeNum");
            this.Property(t => t.Modulus).HasColumnName("Modulus");
            this.Property(t => t.IsQc).HasColumnName("IsQc");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.CKMachine)
                .WithMany(t => t.CKMachinePassages)
                .HasForeignKey(d => d.MachineID);

        }
    }
}
