using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CKMachineResultMap : EntityTypeConfiguration<CKMachineResult>
    {
        public CKMachineResultMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SampleNum)
                .IsRequired()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("CKMachineResult");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LabID).HasColumnName("LabID");
            this.Property(t => t.SampleNum).HasColumnName("SampleNum");
            this.Property(t => t.TestDate).HasColumnName("TestDate");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.TestTypeID).HasColumnName("TestTypeID");

            // Relationships
            this.HasRequired(t => t.CKMachine)
                .WithMany(t => t.CKMachineResults)
                .HasForeignKey(d => d.MachineID);

        }
    }
}
