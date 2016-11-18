using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsEducationIllMap : EntityTypeConfiguration<BsEducationIll>
    {
        public BsEducationIllMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.IllDesc)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("BsEducationIll");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.EducationId).HasColumnName("EducationId");
            this.Property(t => t.ListNum).HasColumnName("ListNum");
            this.Property(t => t.IcdId).HasColumnName("IcdId");
            this.Property(t => t.IllDesc).HasColumnName("IllDesc");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsEducation)
                .WithMany(t => t.BsEducationIlls)
                .HasForeignKey(d => d.EducationId);
            this.HasOptional(t => t.BsIllness)
                .WithMany(t => t.BsEducationIlls)
                .HasForeignKey(d => d.IcdId);

        }
    }
}
