using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkItemResultMap : EntityTypeConfiguration<CkItemResult>
    {
        public CkItemResultMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Result)
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

            this.Property(t => t.Summary)
                .HasMaxLength(1000);

            this.Property(t => t.DoctorAdvice)
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("CkItemResult");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TestId).HasColumnName("TestId");
            this.Property(t => t.Result).HasColumnName("Result");
            this.Property(t => t.IsBold).HasColumnName("IsBold");
            this.Property(t => t.IsPass).HasColumnName("IsPass");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.DoctorAdvice).HasColumnName("DoctorAdvice");
        }
    }
}
