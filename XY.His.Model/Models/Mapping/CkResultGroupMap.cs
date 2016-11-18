using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class CkResultGroupMap : EntityTypeConfiguration<CkResultGroup>
    {
        public CkResultGroupMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.CheckDesc)
                .HasMaxLength(1000);

            this.Property(t => t.Summary)
                .HasMaxLength(1000);

            this.Property(t => t.DoctorAdvice)
                .HasMaxLength(1000);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CkResultGroup");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.TestGroupId).HasColumnName("TestGroupId");
            this.Property(t => t.CheckId).HasColumnName("CheckId");
            this.Property(t => t.CheckDesc).HasColumnName("CheckDesc");
            this.Property(t => t.Summary).HasColumnName("Summary");
            this.Property(t => t.DoctorAdvice).HasColumnName("DoctorAdvice");
            this.Property(t => t.LsStatus).HasColumnName("LsStatus");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.ResultTime).HasColumnName("ResultTime");
            this.Property(t => t.ResultOperId).HasColumnName("ResultOperId");
            this.Property(t => t.AuthTime).HasColumnName("AuthTime");
            this.Property(t => t.AuthOperId).HasColumnName("AuthOperId");

            // Relationships
            this.HasRequired(t => t.CkMain)
                .WithMany(t => t.CkResultGroups)
                .HasForeignKey(d => d.CheckId);
            this.HasRequired(t => t.CkTestGroup)
                .WithMany(t => t.CkResultGroups)
                .HasForeignKey(d => d.TestGroupId);

        }
    }
}
