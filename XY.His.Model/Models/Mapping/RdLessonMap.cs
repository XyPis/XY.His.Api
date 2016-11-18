using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class RdLessonMap : EntityTypeConfiguration<RdLesson>
    {
        public RdLessonMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Location)
                .HasMaxLength(50);

            this.Property(t => t.Company)
                .HasMaxLength(100);

            this.Property(t => t.Occupation)
                .HasMaxLength(20);

            this.Property(t => t.Teacher)
                .HasMaxLength(50);

            this.Property(t => t.Title)
                .HasMaxLength(500);

            this.Property(t => t.Content)
                .HasMaxLength(2000);

            this.Property(t => t.F1)
                .HasMaxLength(100);

            this.Property(t => t.F2)
                .HasMaxLength(100);

            this.Property(t => t.F3)
                .HasMaxLength(100);

            this.Property(t => t.F4)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("RdLesson");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.LessonTypeId).HasColumnName("LessonTypeId");
            this.Property(t => t.LessonTime).HasColumnName("LessonTime");
            this.Property(t => t.Location).HasColumnName("Location");
            this.Property(t => t.Numbers).HasColumnName("Numbers");
            this.Property(t => t.Company).HasColumnName("Company");
            this.Property(t => t.Occupation).HasColumnName("Occupation");
            this.Property(t => t.Teacher).HasColumnName("Teacher");
            this.Property(t => t.Title).HasColumnName("Title");
            this.Property(t => t.Content).HasColumnName("Content");
            this.Property(t => t.OperTime).HasColumnName("OperTime");
            this.Property(t => t.OperID).HasColumnName("OperID");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");
        }
    }
}
