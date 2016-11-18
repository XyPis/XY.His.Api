using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RdLessonManMap : EntityTypeConfiguration<RdLessonMan>
    {
        public RdLessonManMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Memo)
                .HasMaxLength(50);

            this.Property(t => t.F1)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("RdLessonMan");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.PatId).HasColumnName("PatId");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.Memo).HasColumnName("Memo");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
            this.Property(t => t.LessonId).HasColumnName("LessonId");

            // Relationships
            this.HasRequired(t => t.BsPatient)
                .WithMany(t => t.RdLessonMen)
                .HasForeignKey(d => d.PatId);

        }
    }
}
