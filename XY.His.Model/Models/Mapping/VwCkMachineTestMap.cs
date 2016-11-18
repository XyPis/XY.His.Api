using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class VwCkMachineTestMap : EntityTypeConfiguration<VwCkMachineTest>
    {
        public VwCkMachineTestMap()
        {
            // Primary Key
            this.HasKey(t => new { t.MachineName, t.TestName, t.LabId, t.Price, t.LabNum, t.MachineID, t.TestID });

            // Properties
            this.Property(t => t.MachineName)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.TestName)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.LabId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.Price)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.LabNum)
                .IsRequired()
                .HasMaxLength(12);

            this.Property(t => t.OperName)
                .HasMaxLength(30);

            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TestID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("VwCkMachineTest");
            this.Property(t => t.MachineName).HasColumnName("MachineName");
            this.Property(t => t.TestName).HasColumnName("TestName");
            this.Property(t => t.LabId).HasColumnName("LabId");
            this.Property(t => t.ReportTime).HasColumnName("ReportTime");
            this.Property(t => t.Price).HasColumnName("Price");
            this.Property(t => t.LabNum).HasColumnName("LabNum");
            this.Property(t => t.OperName).HasColumnName("OperName");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.TestID).HasColumnName("TestID");
        }
    }
}
