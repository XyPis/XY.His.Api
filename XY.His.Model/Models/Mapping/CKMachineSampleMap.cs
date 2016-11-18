using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CKMachineSampleMap : EntityTypeConfiguration<CKMachineSample>
    {
        public CKMachineSampleMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.SampleNum)
                .IsRequired()
                .HasMaxLength(14);

            // Table & Column Mappings
            this.ToTable("CKMachineSample");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LabID).HasColumnName("LabID");
            this.Property(t => t.SampleNum).HasColumnName("SampleNum");
            this.Property(t => t.MatchDate).HasColumnName("MatchDate");
            this.Property(t => t.SendStatus).HasColumnName("SendStatus");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.UserID).HasColumnName("UserID");

            // Relationships
            this.HasRequired(t => t.BsUser)
                .WithMany(t => t.CKMachineSamples)
                .HasForeignKey(d => d.UserID);
            this.HasRequired(t => t.CkLab)
                .WithMany(t => t.CKMachineSamples)
                .HasForeignKey(d => d.LabID);
            this.HasOptional(t => t.CKMachine)
                .WithMany(t => t.CKMachineSamples)
                .HasForeignKey(d => d.MachineID);

        }
    }
}
