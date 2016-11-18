using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CKMachineResultDtlMap : EntityTypeConfiguration<CKMachineResultDtl>
    {
        public CKMachineResultDtlMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Result)
                .HasMaxLength(100);

            this.Property(t => t.bench)
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("CKMachineResultDtl");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.ResultID).HasColumnName("ResultID");
            this.Property(t => t.TestID).HasColumnName("TestID");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.bench).HasColumnName("bench");

            // Relationships
            this.HasRequired(t => t.CKMachineResult)
                .WithMany(t => t.CKMachineResultDtls)
                .HasForeignKey(d => d.ResultID);

        }
    }
}
