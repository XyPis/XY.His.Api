using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class Vw_CKMachineResultDtl_BMap : EntityTypeConfiguration<Vw_CKMachineResultDtl_B>
    {
        public Vw_CKMachineResultDtl_BMap()
        {
            // Primary Key
            this.HasKey(t => new { t.OperDate, t.ID, t.ResultID, t.TestID });

            // Properties
            this.Property(t => t.ID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(t => t.ResultID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.TestID)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Result)
                .HasMaxLength(100);

            this.Property(t => t.bench)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Vw_CKMachineResultDtl_B");
            this.Property(t => t.OperDate).HasColumnName("OperDate");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ResultID).HasColumnName("ResultID");
            this.Property(t => t.TestID).HasColumnName("TestID");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.bench).HasColumnName("bench");
        }
    }
}
