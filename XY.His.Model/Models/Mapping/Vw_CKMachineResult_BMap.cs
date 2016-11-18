using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_CKMachineResult_BMap : EntityTypeConfiguration<Vw_CKMachineResult_B>
    {
        public Vw_CKMachineResult_BMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OperDate, t.ID, t.LabID, t.SampleNum, t.TestDate, t.MachineID, t.TestTypeID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.LabID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.SampleNum)
                .IsRequired()
                .HasMaxLength(14);

            this.Property(t => t.MachineID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TestTypeID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("Vw_CKMachineResult_B");
            this.Property(t => t.OperDate).HasColumnName("OperDate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LabID).HasColumnName("LabID");
            this.Property(t => t.SampleNum).HasColumnName("SampleNum");
            this.Property(t => t.TestDate).HasColumnName("TestDate");
            this.Property(t => t.MachineID).HasColumnName("MachineID");
            this.Property(t => t.TestTypeID).HasColumnName("TestTypeID");
        }
    }
}
