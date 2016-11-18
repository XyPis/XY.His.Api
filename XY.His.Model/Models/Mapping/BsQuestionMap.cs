using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace XY.His.Model.Models.Mapping
{
    public class BsQuestionMap : EntityTypeConfiguration<BsQuestion>
    {
        public BsQuestionMap()
        {
            // Primary Key
            this.HasKey(t => t.ID);

            // Properties
            this.Property(t => t.Question)
                .IsRequired()
                .HasMaxLength(200);

            this.Property(t => t.Answer)
                .IsRequired()
                .HasMaxLength(50);

            this.Property(t => t.OptionA)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OptionB)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OptionC)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.OptionD)
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
            this.ToTable("BsQuestion");
            this.Property(t => t.ID).HasColumnName("ID");
            this.Property(t => t.Question).HasColumnName("Question");
            this.Property(t => t.Answer).HasColumnName("Answer");
            this.Property(t => t.OptionA).HasColumnName("OptionA");
            this.Property(t => t.OptionB).HasColumnName("OptionB");
            this.Property(t => t.OptionC).HasColumnName("OptionC");
            this.Property(t => t.OptionD).HasColumnName("OptionD");
            this.Property(t => t.SubjectId).HasColumnName("SubjectId");
            this.Property(t => t.F1).HasColumnName("F1");
            this.Property(t => t.F2).HasColumnName("F2");
            this.Property(t => t.F3).HasColumnName("F3");
            this.Property(t => t.F4).HasColumnName("F4");

            // Relationships
            this.HasRequired(t => t.BsSubject)
                .WithMany(t => t.BsQuestions)
                .HasForeignKey(d => d.SubjectId);

        }
    }
}
